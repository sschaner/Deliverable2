using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean finished = true;
            string message;
            string messageRepeat = "I'm sorry but you have already said that." + Environment.NewLine;
            int helloCount = 0;
            int supCount = 0;
            int helloThereCount = 0;

            Console.WriteLine("Hello and welcome to Deliverable 2." + Environment.NewLine + "In this deliverable, you will be chatting with a chat bot. The bot's vocabulary is limited so your conversation might not be too deep. Enjoy!" + Environment.NewLine);

            do
            {
                Console.Write("What do you wish to say? ");
                string input = Console.ReadLine();

                // response to 'hello'
                if (input.ToLower() == "hello")
                {
                    helloCount++;
                    message = "Hi, good to see you." + Environment.NewLine;
                    if (helloCount > 1)
                    {
                        message = messageRepeat;
                    }
                }
                // response to 'bye'
                else if (input.ToLower() == "bye")
                {
                    message = "Good bye!";
                    finished = false;
                }
                // response to 'sup'
                else if (input.ToLower() == "sup")
                {
                    supCount++;
                    message = "I am good." + Environment.NewLine;
                    if (supCount > 1)
                    {
                        message = messageRepeat;
                    }
                }
                // response to 'hello there'
                else if (input.ToLower() == "hello there")
                {
                    helloThereCount++;
                    message = "General Kenobi" + Environment.NewLine;
                    if (helloThereCount > 1)
                    {
                        message = messageRepeat;
                    }
                }
                else
                {
                    message = "I have a limited vocabulary. Please say someting that I understand." + Environment.NewLine;
                }

                Console.WriteLine(message);

            } while (finished);
        }
    }
}
