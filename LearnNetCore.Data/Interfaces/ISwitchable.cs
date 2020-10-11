using LearnNetCore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnNetCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
