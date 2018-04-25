using Logger;
using Logger.App.Layouts;
using Logger.App.Models;
using Logger.App.Models.Contracts;
using Logger.App.Models.Layouts;
using Logger.Models.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.Logger.App
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ILogger logger = InitializeLogger();
            MessageFactory messageFactory = new MessageFactory();
            Engine engine = new Engine(logger, messageFactory);
            engine.Run();
        }

        static ILogger InitializeLogger()
        {
            ICollection<IAppender> appenders = new List<IAppender>();

            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);

            int appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                string[] args = Console.ReadLine().Split();
                string appenderType = args[0];
                string layoutType = args[1];
                string messageLevel = "INFO";

                if (args.Length == 3)
                    messageLevel = args[2];

                IAppender appender = appenderFactory.CreateAppender(appenderType, layoutType, messageLevel);
                appenders.Add(appender);
            }
            ILogger logger = new MyLogger(appenders);
            return logger;
        }
    }
}
