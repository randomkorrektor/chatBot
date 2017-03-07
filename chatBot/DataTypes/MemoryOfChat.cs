using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class MemoryOfChat
    {
        public long ID { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }

        public MemoryOfChat(string messageIn)
        {
            message = messageIn;
            date = DateTime.Now;
        }

        public MemoryOfChat() {
        }
    }
}
