using NET_Tedu.DataEF;
using NET_Tedu.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Tedu.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {

        private readonly AppDbContext _context;

        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
