using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ITGnanConsole.IQ.Models
{
    public class AppMessages
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("published")]
        public string Published { get; set; }

        [JsonPropertyName("message")]
        public List<MessageItem> Message { get; set; }
    }

    public class MessageItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("messageId")]
        public TypeAndText MessageId { get; set; }

        [JsonPropertyName("title")]
        public TypeAndText Title { get; set; }

        [JsonPropertyName("subTitle")]
        public TypeAndText SubTitle { get; set; }

        [JsonPropertyName("body")]
        public TypeAndText Body { get; set; }
    }

    public class TypeAndText
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
