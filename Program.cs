using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Username_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string> { "alice", "BobSmith", "charlie99", "david_b", "EveMiller" };

            Console.WriteLine("Stored usernames:");
            
            foreach (string username in usernames)
            {
                Console.WriteLine($"- {username}");
            }
            
            Console.Write("\nEnter a character to search: ");
            
            char searchChar;
            
            while (!char.TryParse(Console.ReadLine(), out searchChar))
            {
                Console.WriteLine("Invalid input. Please enter a single character.");
                Console.Write("Enter a character to search: ");
            }
            
            List<string> matches = new List<string>();
            
            foreach (string username in usernames)
            {
                if (username.ToLower().Contains(char.ToLower(searchChar)))
                {
                    matches.Add(username);
                }
            }
            
            Console.WriteLine("\nMatching usernames:");
            
            if (matches.Count > 0)
            {
                foreach (string match in matches)
                {
                    Console.WriteLine($"- {match}");
                }
            }
            else
            {
                Console.WriteLine("No usernames contain that character.");
            }
        }
    }
}
