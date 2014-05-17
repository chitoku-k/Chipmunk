using System;

namespace Chipmunk.Win32
{
    [Flags]
    internal enum MF
    {
        BYCOMMAND = 0x00000000,
        BYPOSITION = 0x00000400,
        BITMAP = 0x00000004,
        CHECKED = 0x00000008,
        DISABLED = 0x00000002,
        ENABLED = 0x00000000,
        GRAYED = 0x00000001,
        MENUBARBREAK = 0x00000020,
        MENUBREAK = 0x00000040,
        OWNERDRAW = 0x00000100,
        POPUP = 0x00000010,
        SEPARATOR = 0x00000800,
        STRING = 0x00000000,
        UNCHECKED = 0x00000000
    }
}
