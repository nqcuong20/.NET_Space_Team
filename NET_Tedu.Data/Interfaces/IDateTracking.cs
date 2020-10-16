using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Tedu.Data.Interfaces
{
    public interface IDateTracking
    {
           DateTime DateCreate { set; get; }

           DateTime DateModified { set; get; }

    }
}
