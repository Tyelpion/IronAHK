﻿
namespace IronAHK.Rusty
{
    partial class Core
    {
        static readonly char[] Keyword_Spaces = { '\r', '\n', ' ', '\t', '\xA0' };

        const string Keyword_Pixel = "pixel";
        const string Keyword_Mouse = "mouse";
        const string Keyword_Screen = "screen";
        const string Keyword_Relative = "relative";
        const string Keyword_RGB = "rgb";
        const string Keyword_LTrim = "ltrim";
        const string Keyword_RTrim = "rtrim";
        const string Keyword_Join = "join";
        const string Keyword_Low = "low";
        const string Keyword_BelowNormal = "belownormal";
        const string Keyword_Normal = "normal";
        const string Keyword_AboveNormal = "abovenormal";
        const string Keyword_High = "high";
        const string Keyword_Realtime = "realtime";
        const string Keyword_ahk_id = "ahk_id";
        const string Keyword_ahk_pid = "ahk_pid";
        const string Keyword_ahk_class = "ahk_class";
        const string Keyword_ahk_group = "ahk_group";
        const string Keyword_Between = "between";
        const string Keyword_Contains = "contains";
        const string Keyword_In = "in";
        const string Keyword_Is = "is";
        const string Keyword_Integer = "integer";
        const string Keyword_Float = "float";
        const string Keyword_Number = "number";
        const string Keyword_Digit = "digit";
        const string Keyword_XDigit = "xdigit";
        const string Keyword_Alpha = "alpha";
        const string Keyword_Upper = "upper";
        const string Keyword_Lower = "lower";
        const string Keyword_Alnum = "alnum";
        const string Keyword_Time = "time";
        const string Keyword_Date = "date";
        const string Keyword_Not = "not";
        const string Keyword_Or = "or";
        const string Keyword_And = "and";
        const string Keyword_AlwaysOnTop = "alwaysontop";
        const string Keyword_Topmost = "topmost";
        const string Keyword_Top = "top";
        const string Keyword_Bottom = "bottom";
        const string Keyword_Transparent = "transparent";
        const string Keyword_Transcolor = "transcolor";
        const string Keyword_Redraw = "redraw";
        const string Keyword_Region = "region";
        const string Keyword_ID = "id";
        const string Keyword_IDLast = "idlast";
        const string Keyword_ProcessName = "processname";
        const string Keyword_MinMax = "minmax";
        const string Keyword_ControlList = "controllist";
        const string Keyword_Count = "count";
        const string Keyword_List = "list";
        const string Keyword_Capacity = "capacity";
        const string Keyword_StatusCD = "statuscd";
        const string Keyword_Eject = "eject";
        const string Keyword_Lock = "lock";
        const string Keyword_Unlock = "unlock";
        const string Keyword_Label = "label";
        const string Keyword_FileSystem = "filesystem";
        const string Keyword_SetLabel = "setlabel";
        const string Keyword_Serial = "serial";
        const string Keyword_Type = "type";
        const string Keyword_Status = "status";
        const string Keyword_Static = "static";
        const string Keyword_Global = "global";
        const string Keyword_Local = "local";
        const string Keyword_ByRef = "byref";
        const string Keyword_Seconds = "seconds";
        const string Keyword_Minutes = "minutes";
        const string Keyword_Hours = "hours";
        const string Keyword_Days = "days";
        const string Keyword_Read = "read";
        const string Keyword_Parse = "parse";
        const string Keyword_Logoff = "logoff";
        const string Keyword_Close = "close";
        const string Keyword_Error = "error";
        const string Keyword_Single = "single";
        const string Keyword_Tray = "tray";
        const string Keyword_Add = "add";
        const string Keyword_Rename = "rename";
        const string Keyword_Check = "check";
        const string Keyword_Uncheck = "uncheck";
        const string Keyword_ToggleCheck = "togglecheck";
        const string Keyword_Enable = "enable";
        const string Keyword_Disable = "disable";
        const string Keyword_ToggleEnable = "toggleenable";
        const string Keyword_Default = "default";
        const string Keyword_NoDefault = "nodefault";
        const string Keyword_Standard = "standard";
        const string Keyword_NoStandard = "nostandard";
        const string Keyword_Color = "color";
        const string Keyword_Delete = "delete";
        const string Keyword_DeleteAll = "deleteall";
        const string Keyword_Icon = "icon";
        const string Keyword_NoIcon = "noicon";
        const string Keyword_Tip = "tip";
        const string Keyword_Click = "click";
        const string Keyword_Show = "show";
        const string Keyword_MainWindow = "mainwindow";
        const string Keyword_NoMainWindow = "nomainwindow";
        const string Keyword_UseErrorLevel = "useerrorlevel";
        const string Keyword_Text = "text";
        const string Keyword_Picture = "picture";
        const string Keyword_Pic = "pic";
        const string Keyword_GroupBox = "groupbox";
        const string Keyword_Button = "button";
        const string Keyword_CheckBox = "checkbox";
        const string Keyword_Radio = "radio";
        const string Keyword_DropDownList = "dropdownlist";
        const string Keyword_DDL = "ddl";
        const string Keyword_ComboBox = "combobox";
        const string Keyword_ListBox = "listbox";
        const string Keyword_ListView = "listview";
        const string Keyword_DateTime = "datetime";
        const string Keyword_MonthCal = "monthcal";
        const string Keyword_Slider = "slider";
        const string Keyword_StatusBar = "statusbar";
        const string Keyword_Tab = "tab";
        const string Keyword_Tab2 = "tab2";
        const string Keyword_TreeView = "treeview";
        const string Keyword_UpDown = "updown";
        const string Keyword_IconSmall = "iconsmall";
        const string Keyword_Tile = "tile";
        const string Keyword_Report = "report";
        const string Keyword_SortDesc = "sortdesc";
        const string Keyword_NoSort = "nosort";
        const string Keyword_NoSortHdr = "nosorthdr";
        const string Keyword_Grid = "grid";
        const string Keyword_Hdr = "hdr";
        const string Keyword_AutoSize = "autosize";
        const string Keyword_Range = "range";
        const string Keyword_xm = "xm";
        const string Keyword_ym = "ym";
        const string Keyword_ys = "ys";
        const string Keyword_xs = "xs";
        const string Keyword_xp = "xp";
        const string Keyword_yp = "yp";
        const string Keyword_Font = "font";
        const string Keyword_Resize = "resize";
        const string Keyword_Owner = "owner";
        const string Keyword_Submit = "submit";
        const string Keyword_NoHide = "nohide";
        const string Keyword_Minimize = "minimize";
        const string Keyword_Maximize = "maximize";
        const string Keyword_Restore = "restore";
        const string Keyword_NoActivate = "noactivate";
        const string Keyword_NA = "na";
        const string Keyword_Cancel = "cancel";
        const string Keyword_Destroy = "destroy";
        const string Keyword_Center = "center";
        const string Keyword_Margin = "margin";
        const string Keyword_MaxSize = "maxsize";
        const string Keyword_MinSize = "minsize";
        const string Keyword_OwnDialogs = "owndialogs";
        const string Keyword_GuiEscape = "escape";
        const string Keyword_GuiClose = "close";
        const string Keyword_GuiSize = "size";
        const string Keyword_GuiContextMenu = "contextmenu";
        const string Keyword_GuiDropFiles = "dropfiles";
        const string Keyword_TabStop = "tabstop";
        const string Keyword_Section = "section";
        const string Keyword_AltSubmit = "altsubmit";
        const string Keyword_Wrap = "wrap";
        const string Keyword_HScroll = "hscroll";
        const string Keyword_VScroll = "vscroll";
        const string Keyword_Border = "border";
        const string Keyword_Buttons = "buttons";
        const string Keyword_Expand = "expand";
        const string Keyword_First = "first";
        const string Keyword_ImageList = "imagelist";
        const string Keyword_Lines = "lines";
        const string Keyword_WantCtrlA = "wantctrla";
        const string Keyword_WantF2 = "wantf2";
        const string Keyword_Vis = "vis";
        const string Keyword_VisFirst = "visfirst";
        const string Keyword_Uppercase = "uppercase";
        const string Keyword_Lowercase = "lowercase";
        const string Keyword_Limit = "limit";
        const string Keyword_Password = "password";
        const string Keyword_Multi = "multi";
        const string Keyword_WantReturn = "wantreturn";
        const string Keyword_Group = "group";
        const string Keyword_Background = "background";
        const string Keyword_Bold = "bold";
        const string Keyword_Italic = "italic";
        const string Keyword_Strike = "strike";
        const string Keyword_Underline = "underline";
        const string Keyword_Norm = "norm";
        const string Keyword_BackgroundTrans = "backgroundtrans";
        const string Keyword_Theme = "theme";
        const string Keyword_Caption = "caption";
        const string Keyword_Delimiter = "delimiter";
        const string Keyword_MinimizeBox = "minimizebox";
        const string Keyword_MaximizeBox = "maximizebox";
        const string Keyword_SysMenu = "sysmenu";
        const string Keyword_ToolWindow = "toolwindow";
        const string Keyword_Flash = "flash";
        const string Keyword_Style = "style";
        const string Keyword_ExStyle = "exstyle";
        const string Keyword_Check3 = "check3";
        const string Keyword_Checked = "checked";
        const string Keyword_CheckedGray = "checkedgray";
        const string Keyword_Readonly = "readonly";
        const string Keyword_Hidden = "hidden";
        const string Keyword_Left = "left";
        const string Keyword_Right = "right";
        const string Keyword_NoTab = "notab";
        const string Keyword_Move = "move";
        const string Keyword_Focus = "focus";
        const string Keyword_Hide = "hide";
        const string Keyword_Choose = "choose";
        const string Keyword_ChooseString = "choosestring";
        const string Keyword_Pos = "pos";
        const string Keyword_Enabled = "enabled";
        const string Keyword_Disabled = "disabled";
        const string Keyword_Visible = "visible";
        const string Keyword_LastFound = "lastfound";
        const string Keyword_LastFoundExist = "lastfoundexist";
        const string Keyword_AltTab = "alttab";
        const string Keyword_ShiftAltAab = "shiftalttab";
        const string Keyword_AltTabmenu = "alttabmenu";
        const string Keyword_AltTabAndMenu = "alttabandmenu";
        const string Keyword_AltTabMenuDismiss = "alttabmenudismiss";
        const string Keyword_NoTimers = "notimers";
        const string Keyword_Interrupt = "interrupt";
        const string Keyword_Priority = "priority";
        const string Keyword_WaitClose = "waitclose";
        const string Keyword_Wait = "wait";
        const string Keyword_Exist = "exist";
        const string Keyword_Unicode = "unicode";
        const string Keyword_Asc = "asc";
        const string Keyword_Chr = "chr";
        const string Keyword_Deref = "deref";
        const string Keyword_Mod = "mod";
        const string Keyword_Pow = "pow";
        const string Keyword_Exp = "exp";
        const string Keyword_Sqrt = "sqrt";
        const string Keyword_Log = "log";
        const string Keyword_Ln = "ln";
        const string Keyword_Round = "round";
        const string Keyword_Ceil = "ceil";
        const string Keyword_Floor = "floor";
        const string Keyword_Abs = "abs";
        const string Keyword_Sin = "sin";
        const string Keyword_Cos = "cos";
        const string Keyword_Tan = "tan";
        const string Keyword_Asin = "asin";
        const string Keyword_Acos = "acos";
        const string Keyword_Atan = "atan";
        const string Keyword_BitNot = "bitnot";
        const string Keyword_BitAnd = "bitand";
        const string Keyword_BitOr = "bitor";
        const string Keyword_BitXor = "bitxor";
        const string Keyword_BitShiftLeft = "bitshiftleft";
        const string Keyword_BitShiftRight = "bitshiftright";
        const string Keyword_Yes = "yes";
        const string Keyword_No = "no";
        const string Keyword_Ok = "ok";
        const string Keyword_Abort = "abort";
        const string Keyword_Retry = "retry";
        const string Keyword_Ignore = "ignore";
        const string Keyword_TryAgain = "tryagain";
        const string Keyword_On = "on";
        const string Keyword_Off = "off";
        const string Keyword_All = "all";
        const string Keyword_HKey_Local_Machine = "hkey_local_machine";
        const string Keyword_HKey_Users = "hkey_users";
        const string Keyword_HKey_Current_User = "hkey_current_user";
        const string Keyword_HKey_Classes_Root = "hkey_classes_root";
        const string Keyword_HKey_Current_Config = "hkey_current_config";
        const string Keyword_HKLM = "hklm";
        const string Keyword_HKU = "hku";
        const string Keyword_HKCU = "hkcu";
        const string Keyword_HKCR = "hkcr";
        const string Keyword_HKCC = "hkcc";
        const string Keyword_Reg_Sz = "reg_sz";
        const string Keyword_Reg_Expand_Sz = "reg_expand_sz";
        const string Keyword_Reg_Multi_Sz = "reg_multi_sz";
        const string Keyword_Reg_Dword = "reg_dword";
        const string Keyword_Reg_Binary = "reg_binary";

        const string Keyword_None = "none";
        const string Keyword_Selected = "selected";
        const string Keyword_Select = "select";
        const string Keyword_Column = "column";
        const string Keyword_RegEx = "regex";
        const string Keyword_Fast = "fast";
        const string Keyword_Slow = "slow";
        const string Keyword_ToolTip = "tooltip";
        const string Keyword_Caret = "caret";
        const string Keyword_Menu = "menu";
        const string Keyword_Locale = "locale";
        const string Keyword_CSV = "csv";
        const string Keyword_Up = "up";
        const string Keyword_Down = "down";
        const string Keyword_Toggle = "toggle";
        const string Keyword_Edit = "edit";
        const string Keyword_Hotkey = "hotkey";
        const string Keyword_Progress = "progress";
        const string Keyword_WebBrowser = "webbrowser";
        const string Keyword_WantTab = "wanttab";
        const string Keyword_Smooth = "smooth";
        const string Keyword_Vertical = "vertical";
        const string Keyword_ShortDate = "shortdate";
        const string Keyword_LongDate = "longdate";
        const string Keyword_YearMonth = "yearmonth";
        const string Keyword_YDay = "yday";
        const string Keyword_YDay0 = "yday0";
        const string Keyword_WDay = "wday";
        const string Keyword_YWeek = "yweek";
        const string Keyword_Random = "random";
        const string Keyword_Sort = "sort";

        const char Keyword_ModifierWin = '#';
        const char Keyword_ModifierAlt = '!';
        const char Keyword_ModifierCtrl = '^';
        const char Keyword_ModifierShift = '+';
        const char Keyword_ModifierLeftPair = '<';
        const char Keyword_ModifierRightPair = '>';
        const char Keyword_HotkeyIgnoreModifiers = '*';
        const char Keyword_HotkeyPassThrough = '~';
        const char Keyword_HotkeyCombination = '&';
        const char Keyword_HotkeyNoRecurse = '$';

        const char Keyword_HotstringAuto = '*';
        const char Keyword_HotstringNested = '?';
        const char Keyword_HotstringBackspace = 'B';
        const char Keyword_HotstringCase = 'C';
        const char Keyword_HotstringOmitEnding = 'O';
        const char Keyword_HotstringReset = 'Z';
        const char Keyword_HotstringOff = '0';

        const string Keyword_IfWinActive = "ifwinactive";
        const string Keyword_IfWinNotActive = "ifwinnotactive";
        const string Keyword_IfWinExist = "ifwinexist";
        const string Keyword_IfWinNotExit = "ifwinnotexist";
    }
}
