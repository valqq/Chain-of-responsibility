using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail
{
   public  class Email
    {
        public EmailType Type { get; private set; }
        public string Message { get; private set; }

        public Email(EmailType type, string message)
        {
            Type = type;
            Message = message;
        }
    }
}
