using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_bye_device
{
    public class WelcomingMessage
    {

        public static string [] GenerateWelcomeList()
        {
            string[] welcomingMessage = new[]
            {
             "Hi",
             "Hello",
             "Hi! What are you doing here?",
             "Hello! Who are you and why are you here?",
             "Hi! Where are you going?",
             "Hi!***Are you ok?",
             "Hello! Who are you *** and why are you here ***?",
             "Hi,*!",
             "Hello, ***"

            };

            return welcomingMessage;
        }
        
        





    }
}
