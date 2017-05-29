﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class UserContext: DbContext
    {
        public UserContext()
            :base("UserDB")    
        { }

        public DbSet<User>Users { get; set; }
    }
}
