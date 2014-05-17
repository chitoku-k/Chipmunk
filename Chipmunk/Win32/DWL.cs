using System;

namespace Chipmunk.Win32
{
    [Flags]
    internal enum DWL
    {
        MSGRESULT = 0,
        DLGPROC = 4,
        USER = 8
    }
}
