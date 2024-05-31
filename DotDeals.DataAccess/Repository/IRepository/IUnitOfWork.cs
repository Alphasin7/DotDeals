using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDeals.DataAccess.Repository.IRepository
{
    internal interface IUnitOfWork
    {
        ICategoryRepository Category { get; }
        void Save();

    }
}
