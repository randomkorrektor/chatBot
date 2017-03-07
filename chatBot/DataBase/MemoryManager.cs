using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes;

namespace DataBase
{
    public static class MemoryManager
    {
        public static void AddMessage(string message)
        {
            Context.Instanse.MemoryOfChat.Add(new MemoryOfChat(message));
            Context.Instanse.SaveChanges();
        }

        public static List<MemoryOfChat> GetAllMessages()
        {
            return Context.Instanse.MemoryOfChat.ToList();
        }
    }
}
