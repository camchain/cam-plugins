using System;

namespace Cam.Plugins
{
    [Flags]
    internal enum PersistActions : byte
    {
        StorageChanges = 0b00000001
    }
}
