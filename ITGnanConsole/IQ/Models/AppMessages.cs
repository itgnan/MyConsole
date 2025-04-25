using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGnanConsole.IQ.Models
{
    public class AppMessages
    {
        public string Name { get; set; }
        public string Published { get; set; }
        public List<Message> Message { get; set; }
    }

    public class Message
    {
        public string Name { get; set; }
        public MessageField MessageId { get; set; }
        public MessageField Title { get; set; }
        public MessageField SubTitle { get; set; }
        public MessageField Body { get; set; }
    }

    public class MessageField
    {
        public string Type { get; set; }
        public string Text { get; set; }
    }
}
