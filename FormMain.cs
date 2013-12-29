using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CleanText
{
    public partial class FormMain : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        #region Properties
        private char[] whiteSpace = { ' ', '\t' };

        private const uint WM_PASTE = 0x0302;

        private ContextMenuStrip contextMenu = null;

        private delegate void SortDelegate(string[] lines, string output);

        private GlobalHotkey hotKey;

        private IContainer trayComponents = new Container();

        private IntPtr hwnd;

        private NotifyIcon notifyIcon = null;

        private string[] newLine = { "\n", "\r" };
        #endregion

        public FormMain()
        {
            InitializeComponent();

            try
            {
                this.hotKey = new GlobalHotkey(Constants.CTRL + Constants.SHIFT, Keys.Insert, this);

                this.notifyIcon = new NotifyIcon(this.trayComponents);
                this.contextMenu = new ContextMenuStrip();

                ToolStripMenuItem command = null;

                command = new ToolStripMenuItem();
                command.Text = Constants.Replace;
                command.Click += delegate
                {
                    Replace();
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = Constants.Sort;
                command.Click += delegate
                {
                    Action(Constants.Sort);
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = "Sort (trim white space)";
                command.Click += delegate
                {
                    Action(Constants.SortAndTrimWhiteSpace);
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = "Remove Dupes and Sort";
                command.Click += delegate
                {
                    Action(Constants.RemoveDupesAndSort);
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = "Remove Dupes and Sort (trim white space)";
                command.Click += delegate
                {
                    Action(Constants.RemoveDupesAndSortAndTrimWhiteSpace);
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = "Dupe Column";
                command.Click += delegate
                {
                    Action(Constants.DupeColumn);
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = "Remove All Lines Containing Text...";
                command.Click += delegate
                {
                    Action(Constants.RemoveAllLinesContainingText);
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = "Remove All Lines Without Text...";
                command.Click += delegate
                {
                    Action(Constants.RemoveAllLinesWithoutText);
                };
                this.contextMenu.Items.Add(command);

                this.contextMenu.Items.Add("-");

                command = new ToolStripMenuItem();
                command.Text = Constants.Help;
                command.Click += delegate
                {
                    DialogHelp help = new DialogHelp();
                    help.ShowDialog();
                };
                this.contextMenu.Items.Add(command);

                command = new ToolStripMenuItem();
                command.Text = Constants.Exit;
                command.Click += delegate
                {
                    this.trayComponents.Dispose();
                    this.Close();
                };
                this.contextMenu.Items.Add(command);

                this.notifyIcon.Icon = Properties.Resources.CleanText;
                this.notifyIcon.Text = "Clean Text";
                this.notifyIcon.MouseUp += new MouseEventHandler(notifyIcon_MouseUp);
                this.notifyIcon.ContextMenuStrip = this.contextMenu;
                this.notifyIcon.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Events
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.trayComponents.Dispose();
            this.Close();
        }

        private void lblOptions_Click(object sender, EventArgs e)
        {
            DialogOptions dlgOptions = new DialogOptions();
            dlgOptions.TopMost = true;
            dlgOptions.ShowDialog();
            string keyCombo = dlgOptions.KeyCombo;
        }

        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // NotifyIcon's ShowContextMenu method is internal, so we run it via Reflection - lame.
                MethodInfo method = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                method.Invoke(this.notifyIcon, null);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!this.hotKey.Register())
            {
                MessageBox.Show("Hotkey failed to register!");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.hotKey.Unregister())
            {
                MessageBox.Show("Hotkey failed to unregister!");
            }
        }

        private void Action_Click(object sender, EventArgs e)
        {
            string action = ((Label)sender).Name;
            Action(action.Replace("lbl", string.Empty));
            SetForegroundWindow(this.hwnd);
            SendKeys.Send("^v");
            this.Visible = false;
        }

        private void lblIntro_Click(object sender, EventArgs e)
        {
            lblIntro.Visible = false;
            panel1.Visible = true;
            this.Visible = false;
        }
        #endregion

        #region Methods
        private void Action(string command)
        {
            if (Clipboard.ContainsText())
            {
                Working();

                switch (command)
                {
                    case Constants.Sort:
                        Sort();
                        break;

                    case Constants.SortAndTrimWhiteSpace:
                        SortAndTrimWhiteSpace();
                        break;

                    case Constants.RemoveDupesAndSort:
                        RemoveDupesAndSort();
                        break;

                    case Constants.RemoveDupesAndSortAndTrimWhiteSpace:
                        RemoveDupesAndSortAndTrimWhiteSpace();
                        break;

                    case Constants.DupeColumn:
                        DupeColumn();
                        break;

                    case Constants.RemoveAllLinesContainingText:
                        RemoveAllLinesContainingText();
                        break;

                    case Constants.RemoveAllLinesWithoutText:
                        RemoveAllLinesWithoutText();
                        break;

                    default:
                        break;
                }
            }
            else
            {
                ErrorNoText();
            }

            Ready();
        }

        private void Replace()
        {
            string text = Clipboard.GetText();
            DialogReplace replaceDialog = new DialogReplace();
            replaceDialog.ShowDialog();

            string[] unwantedText = null;
            string replacementText = string.Empty;
            string output = string.Empty;

            if (replaceDialog.UnwantedText.Length > 0)
            {
                unwantedText = new string[] { replaceDialog.UnwantedText };
                replacementText = replaceDialog.ReplacementText;

                string[] lines = text.Split(unwantedText, StringSplitOptions.RemoveEmptyEntries);
                output = string.Join(replacementText, lines);
            }

            if (!string.IsNullOrEmpty(output))
            {
                Clipboard.SetText(output);
            }
        }

        private void Sort()
        {
            List<string> output = new List<string>();
            string text = Clipboard.GetText();
            if (text.Length != 0)
            {
                string[] lines = text.Split(this.newLine, StringSplitOptions.RemoveEmptyEntries);
                SortDelegateAction(output, lines);
                SaveResult(output);
            }
        }

        private void SortAndTrimWhiteSpace()
        {
            List<string> output = new List<string>();
            string text = Clipboard.GetText();
            if (text.Length != 0)
            {
                string[] lines = text.Split(this.newLine, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string value = line;
                    value = value.TrimStart(this.whiteSpace);
                    value = value.TrimEnd(this.whiteSpace);
                    output.Add(value);
                }

                output.Sort();
                SaveResult(output);
            }
        }

        private void RemoveDupesAndSort()
        {
            List<string> output = new List<string>();
            string text = Clipboard.GetText();
            if (text.Length != 0)
            {
                string[] lines = text.Split(this.newLine, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if (!output.Contains(line))
                    {
                        output.Add(line);
                    }
                }

                output.Sort();
                SaveResult(output);
            }
        }

        private void RemoveDupesAndSortAndTrimWhiteSpace()
        {
            List<string> output = new List<string>();
            string text = Clipboard.GetText();
            if (text.Length != 0)
            {
                string[] lines = text.Split(this.newLine, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string value = line;
                    value = value.TrimStart(this.whiteSpace);
                    value = value.TrimEnd(this.whiteSpace);
                    if (!output.Contains(value))
                    {
                        output.Add(value);
                    }
                }

                output.Sort();
                SaveResult(output);
            }
        }

        private void DupeColumn()
        {
            List<string> output = new List<string>();
            string text = Clipboard.GetText();
            if (text.Length != 0)
            {
                string[] lines = text.Split(this.newLine, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    string value = line + "\t" + line;
                    output.Add(value);
                }

                SaveResult(output);
            }
        }

        private void RemoveAllLinesWithoutText()
        {
            List<string> output = new List<string>();
            string text = Clipboard.GetText();
            if (text.Length != 0)
            {
                string value = string.Empty;
                if (InputBox("Clean Text", "Remove all lines without this text:", ref value) == DialogResult.OK)
                {
                    string[] lines = text.Split(this.newLine, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        if (line.Contains(value))
                        {
                            output.Add(line);
                        }
                    }

                    SaveResult(output);
                }
            }
        }

        private void RemoveAllLinesContainingText()
        {
            List<string> output = new List<string>();
            string text = Clipboard.GetText();
            if (text.Length != 0)
            {
                string value = string.Empty;
                if (InputBox("Clean Text", "Remove all lines containing this text:", ref value) == DialogResult.OK)
                {
                    string[] lines = text.Split(this.newLine, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        if (!line.Contains(value))
                        {
                            output.Add(line);
                        }
                    }

                    SaveResult(output);
                }
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Label label = new Label();
            label.Font = SystemFonts.MessageBoxFont;
            label.Text = promptText;
            label.SetBounds(9, 20, 372, 13);
            label.AutoSize = true;

            TextBox textBox = new TextBox();
            textBox.Font = SystemFonts.MessageBoxFont;
            textBox.Text = value;
            textBox.SetBounds(12, 36, 372, 20);
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;

            Button buttonOk = new Button();
            buttonOk.Font = SystemFonts.MessageBoxFont;
            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            Button buttonCancel = new Button();
            buttonCancel.Font = SystemFonts.MessageBoxFont;
            buttonCancel.Text = "Cancel";
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.SetBounds(309, 72, 75, 23);
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            Form form = new Form();
            form.Text = title;
            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void ErrorNoText()
        {
            MessageBox.Show("The Clipboard does not contain any text.", "CleanText", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void SaveResult(List<string> output)
        {
            string temp = string.Empty;
            foreach (string line in output)
            {
                temp += line + Environment.NewLine;
            }

            Clipboard.SetText(temp);
        }

        private static void SortDelegateAction(List<string> output, string[] lines)
        {
            foreach (string line in lines)
            {
                output.Add(line);
            }

            output.Sort();
        }

        private void Ready()
        {
            this.notifyIcon.Icon = Properties.Resources.CleanText;
            Cursor.Current = Cursors.Default;
            Application.DoEvents();
        }

        private void Working()
        {
            this.notifyIcon.Icon = Properties.Resources.CleanTextRunning;
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                HandleHotkey();
            }

            base.WndProc(ref m);
        }

        private void HandleHotkey()
        {
            // Save the current foreground window.
            // This will be restored and result pasted into it.
            this.hwnd = GetForegroundWindow();
            this.Visible = true;
            this.Focus();
        }
        #endregion
    }
}
