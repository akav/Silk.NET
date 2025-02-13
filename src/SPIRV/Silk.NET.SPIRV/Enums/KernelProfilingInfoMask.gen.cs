// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvKernelProfilingInfoMask_")]
    public enum KernelProfilingInfoMask : int
    {
        [NativeName("Name", "SpvKernelProfilingInfoMaskNone")]
        MaskNone = 0x0,
        [NativeName("Name", "SpvKernelProfilingInfoCmdExecTimeMask")]
        CmdExecTimeMask = 0x1,
    }
}
