using ITGnanConsole.IQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGnanConsole.IQ
{
    public class ZTesting
    {
        public (string? toastMessage, string? inlineMessage) GetMessages(List<MessageItem>? msgs)
        {
            string? toastMessage = null;
            string? inlineMessage = null;

            toastMessage = msgs?
       .Where(m => string.Equals(m?.MessageId?.Text, "restrictedCreditCardToastMessage", StringComparison.OrdinalIgnoreCase))
       .Select(m => m?.Body?.Text)
       .FirstOrDefault();

            inlineMessage = msgs?
       .Where(m => string.Equals(m?.MessageId?.Text, "restrictedCreditCardInlineMessage", StringComparison.OrdinalIgnoreCase))
       .Select(m => m?.Body?.Text)
       .FirstOrDefault();

            return (toastMessage, inlineMessage);
        }

        public void test()
        {

        }
    }
}
