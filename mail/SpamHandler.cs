using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mail
{
    class SpamHandler : Handler
    {
        public SpamHandler(Handler seccessor) : base(seccessor)
        {
        }

        public override void HandleRequest(Email email)
        {
            if (email.Type == EmailType.Spam)
            {
                Console.WriteLine("Spam Handler is handing the following messafe ... ");
                Console.WriteLine("Deleting the following e-mail ... ");
                Console.WriteLine(email.Message);
                Console.WriteLine();
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(email);
            }
        }
    }
}
