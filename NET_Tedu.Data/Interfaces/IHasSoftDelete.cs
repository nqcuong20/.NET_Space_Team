using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Tedu.Data.Interfaces
{
    public interface IHasSoftDelete
    {
           bool IsDelete { set; get; }
    }
}
