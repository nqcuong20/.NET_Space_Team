using NET_Tedu.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Tedu.Data.Interfaces
{
    public interface ISwitchable
    {
           Status Status { set; get; }
    }
}
