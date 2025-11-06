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
            Console.WriteLine("Invoer jouw wachtword");
            string userWachtword = Console.ReadLine();
        }

        public static void GebruikersDataInvoeren ( ref string input, Predicate<string> conditie) 
        {
            int counter = 0;
            while (!conditie(input)) 
            {
                Console.WriteLine($"{nameof(input)} niet juist is , jij hebt nog {3 - counter} keer ");
                counter++;
                    input = Console.ReadLine();
                  
                    
                
               if (counter == 3) 
                {
                    Console.WriteLine("Sorry maar je kan niet doorgaan");
                    break;
                }

            };
        }

    }
}
