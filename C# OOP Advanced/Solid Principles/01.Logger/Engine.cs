using Logger.App.Models.Contracts;
using Logger.Models.Factories;
using System;

namespace Logger
{
    public class Engine
    {
        private ILogger logger;
        private MessageFactory messageFactory;

        public Engine(ILogger logger,MessageFactory messageFactory)
        {
            this.logger = logger;
            this.messageFactory = messageFactory;
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] arguments = input.Split('|');
                string messageType = arguments[0];
                string dateTime = arguments[1];
                string messageText = arguments[2];

                
                IMessage message = messageFactory.CreateMessage(dateTime, messageType, messageText);
                logger.Log(message);

                input = Console.ReadLine();
            }
            Console.WriteLine("Logger info");
            foreach (IAppender appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
