﻿using System;

namespace IronAHK.Rusty
{
    partial class Core
    {
        // TODO: organise StatusBar.cs

        /// <summary>
        /// Displays a small icon to the left of the text in the specified part (if PartNumber is omitted, it defaults to 1). Filename is the name of an icon (.ICO), cursor (.CUR), or animated cursor (.ANI) file (animated cursors will not actually be animated in the bar). Other sources of icons include the following types of files: EXE, DLL, CPL, SCR, and other types that contain icon resources. To use an icon group other than the first one in the file, specify its number for IconNumber. For example, SB_SetIcon("Shell32.dll", 2) would use the default icon from the second icon group. SB_SetIcon() returns the icon's HICON upon success and 0 upon failure. The HICON is a system resource that can be safely ignored by most scripts because it is destroyed automatically when the status bar's window is destroyed. Similarly, any old icon is destroyed when SB_SetIcon() replaces it with a new one.
        /// </summary>
        /// <param name="Filename"></param>
        /// <param name="IconNumber"></param>
        /// <param name="PartNumber"></param>
        /// <returns></returns>
        public static int SB_SetIcon(string Filename, int IconNumber, int PartNumber)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Divides the bar into multiple sections according to the specified widths (in pixels). If all parameters are omitted, the bar is restored to having only a single, long part. Otherwise, specify the width of each part except the last (the last will fill the remaining width of the bar). For example, SB_SetParts(50, 50) would create three parts: the first two of width 50 and the last one of all the remaining width. Note: Any parts "deleted" by SB_SetParts() will start off with no text the next time they are shown (furthermore, their icons are automatically destroyed). Upon success, SB_SetParts() returns a non-zero value (the status bar's HWND). Upon failure it returns 0.
        /// </summary>
        /// <param name="WidthN"></param>
        public static void SB_SetParts(int[] WidthN)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Displays NewText in the specified part of the status bar. If PartNumber is omitted, it defaults to 1. Otherwise, specify an integer between 1 and 256. If Style is omitted, it defaults to 0, which uses a traditional border that makes that part of the bar look sunken. Otherwise, specify 1 to have no border or 2 to have border that makes that part of the bar look raised. Finally, up to two tab characters (`t) may be present anywhere in NewText: anything to the right of the first tab is centered within the part, and anything to the right of the second tab is right-justified. SB_SetText() returns 1 upon success and 0 upon failure.
        /// </summary>
        /// <param name="NewText"></param>
        /// <param name="PartNumber"></param>
        /// <param name="Style"></param>
        /// <returns></returns>
        public static bool SB_SetText(string NewText, int PartNumber, int Style)
        {
            throw new NotImplementedException();
        }
    }
}