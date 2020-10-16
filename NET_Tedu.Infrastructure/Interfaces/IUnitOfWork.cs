using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Tedu.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call Save change from db Context
        /// </summary>
        void Commit();
    }
}
