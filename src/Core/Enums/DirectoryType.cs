﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit.Core.Enums
{
    public enum DirectoryType : byte
    {
        ActiveDirectory = 0,
        AzureActiveDirectory = 1,
        Other = 2,
        GSuite = 3
    }
}
