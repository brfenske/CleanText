
namespace CleanText
{
    internal static class Constants
    {
        internal const string Replace = "&Replace";
        internal const string Sort = "&Sort";
        internal const string SortAndTrimWhiteSpace = "Sort (&trim white space)";
        internal const string RemoveDupesAndSort = "Remove &Dupes and Sort";
        internal const string RemoveDupesAndSortAndTrimWhiteSpace = "Remove Dupes and Sort (trim &white space)";
        internal const string DupeColumn = "Dupe &Column";
        internal const string RemoveAllLinesContainingText = "Remove &All Lines Containing Text...";
        internal const string RemoveAllLinesWithoutText = "Remove All &Lines Without Text...";
        internal const string Options = "&Options...";
        internal const string Help = "&About CleanText";
        internal const string Exit = "E&xit";

        // Keyboard modifier keys
        //public const int NOMOD = 0x0000;
        //public const int ALT = 0x0001;
        //public const int CTRL = 0x0002;
        //public const int SHIFT = 0x0004;
        //public const int WIN = 0x0008;

        public const int NOMOD = 0;
        public const int ALT = 1;
        public const int CTRL = 2;
        public const int SHIFT = 4;
        public const int WIN = 8;

        // Windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }
}
