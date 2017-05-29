using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp.DBControl
{
    class DbControl<TEntity> where TEntity: new()
    {
        public TEntity Add(string Fie)
        {
            return new TEntity();
        }
    }
}
