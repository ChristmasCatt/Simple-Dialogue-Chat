using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] keywords = { "hi", "how are you", "goodbye", "bye", "are you gay" };
        string[] responses = { "Hello!", "I'm fine, thank you.", "Goodbye! Let me know if there's anything else I can help you with.", "Goodbye! Let me know if there's anything else I can help you with.", "As a machine learning model, I do not have the ability to have a sexual orientation. My purpose is to assist users in generating human-like text based on the input given to me." };
        Console.WriteLine("AI: Hi, how can I help you today?");
        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine().ToLower();
            int index = Array.IndexOf(keywords, input);

            if (index != -1)
            {
                Console.WriteLine("AI: " + responses[index]);
                if (input == "goodbye")
                  break; 
            }
            else
            {
                Console.WriteLine("AI: I'm sorry, I didn't understand.");
            }

        }
    }
}
