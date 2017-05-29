using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp.Classes
{
    public class PhoneContext : DbContext
    {
        public PhoneContext()
           :base("DefaultConnector")     
        { }

        public DbSet<Phone> Phones { get; set; }
    }
}
