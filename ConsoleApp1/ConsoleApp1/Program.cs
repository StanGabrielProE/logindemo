using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoer jouw username");
            string username = Console.ReadLine();
            GebruikersDataInvoeren(ref username, (user) => Regex.IsMatch(user, @"\w{8}"));
            Console.WriteLine(username);
          
        
            if (!string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Invoer jouw wachtword");
                string userWachtword = Console.ReadLine();
                GebruikersDataInvoeren(ref userWachtword, (wachtwoord) => Regex.IsMatch(wachtwoord, @"\w{8}[1-9]"));
                if (!string.IsNullOrEmpty(userWachtword)) 
                {
                    Console.WriteLine($"Welkom {username}");
                }
            }else 
            {
                Console.WriteLine("Sorry  maar je kan niet doorgaan");
            }


            
        }

        public static void GebruikersDataInvoeren ( ref string input, Predicate<string> conditie) 
        {
            int counter = 1;
            while (!conditie(input)) 
            {
                if (counter == 3)
                {
                    input = string.Empty;
                    Console.WriteLine("Sorry maar je kan niet doorgaan");
                    break;
                }

                Console.WriteLine($"{nameof(input)} niet juist is , jij hebt nog {3 - counter} keer ");
                counter++;
             
                input = Console.ReadLine();
                  
                    
                
            

            };
        }

    }
}
