using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagsExample
{
    [Flags]
    public enum Role
    {
        None=0,
        Customer=1,
        Programmer=2,
        SeniorProgrammer=4,
        Architect=8,
        BusinessAnalyst=16,
        TestProgrammer=32,
        TestArchitect=64,
    }
}
