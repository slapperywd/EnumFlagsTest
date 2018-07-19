using System;

namespace EnumFlagsTest
{
    [Flags]
    public enum ExecutionSettings : uint
    {
        None = 0,

        AllowUiPostconditions = 0x00000001,

        AllowUiPreconditions = 0x00000002,

        AllowAutoLogIn = 0x00000004
    }
}
