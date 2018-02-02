using SimpleJudge;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BashSoft
{
    public static class InputReader
    {
        private const string endCommand = "quit";

        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
            string input = Console.ReadLine();
            input = input.Trim();
            bool isInputQuit = false;

            while (!isInputQuit)
            {
                if (input == endCommand)
                {
                    isInputQuit = true;
                    break;
                }
                CommandInterpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }
    }
}

