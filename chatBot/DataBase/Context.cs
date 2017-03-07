using DataTypes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Context : DbContext
    {
        public static Context Instanse = new Context();
        public DbSet<KeyWords> KeyWords { get; set; }
        public DbSet<MemoryOfChat> MemoryOfChat { get; set; }

        public Context(): base("name=ChatBotServer")
        {  }

    }
}
