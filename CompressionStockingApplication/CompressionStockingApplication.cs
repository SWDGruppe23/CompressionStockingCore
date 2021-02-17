using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking;
using CompressionStocking.Interfaces;
using CompressionStocking.Classes;

namespace CompressionStockingApplication
{

    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
            // Det virker lidt underligt, at det er en ConsoleInput, der skal oprettes for at koere systemet, men det er saadan det virker//
            ConsoleInput Cinput = new ConsoleInput();   
            
            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            while (true)
            {
                Cinput.AwaitInput();
            }

          
        }
    }
}
