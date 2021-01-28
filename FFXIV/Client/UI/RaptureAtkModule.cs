using System.Runtime.InteropServices;

namespace FFXIVClientStructs.FFXIV.Client.UI
{
    // Client::UI::RaptureAtkModule
    //   Component::GUI::AtkModule
    //     Component::GUI::AtkModuleInterface

    [StructLayout(LayoutKind.Explicit)]  // either this is tiny, or huge
    public unsafe struct RaptureAtkModule
    {
        [FieldOffset(0x0)] public void* vtbl;
        [FieldOffset(0x1A248)] public fixed byte NamePlateInfo[0x248 * 50];
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x248)]
    unsafe struct NamePlateInfo
    {
        [FieldOffset(0x00)] public int ActorID;
        [FieldOffset(0x52)] public fixed char ActorName[0x40];
    }
}
