
namespace CleanText
{
    internal static class Constants
    {
        internal const string Replace = "Replace";
        internal const string Sort = "Sort";
        internal const string SortAndTrimWhiteSpace = "SortAndTrimWhiteSpace";
        internal const string RemoveDupesAndSort = "RemoveDupesAndSort";
        internal const string RemoveDupesAndSortAndTrimWhiteSpace = "RemoveDupesAndSortAndTrimWhiteSpace";
        internal const string DupeColumn = "DupeColumn";
        internal const string RemoveAllLinesContainingText = "RemoveAllLinesContainingText";
        internal const string RemoveAllLinesWithoutText = "RemoveAllLinesWithoutText";
        internal const string Help = "Help...";
        internal const string Exit = "Exit";

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
