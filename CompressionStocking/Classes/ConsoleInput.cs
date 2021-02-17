using System;
using CompressionStocking.Interfaces;

namespace CompressionStocking.Classes
{
    public class ConsoleInput : IUserInput
    {
        private IInputHandler inputHandler;

        public ConsoleInput()
        {
            inputHandler = new StockingInputHandler();
        }
        public void HandleInput(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.Z:
                    inputHandler.StopPushed();
                    break;
                case ConsoleKey.A:
                    inputHandler.StartPushed();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    break;

            }
        }

        public void AwaitInput()
        {
            ConsoleKeyInfo input = Console.ReadKey();
            HandleInput(input.Key);
        }
    }
}
