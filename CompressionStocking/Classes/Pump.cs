using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking.Classes
{
    class Pump
    {
        public void Compress()
        {
            Console.WriteLine("Pump is Compressing");
        }

        public void Decompress()
        {
            Console.WriteLine("Pump is Decompressing");
        }

        public void Stop()
        {
            Console.WriteLine("Pump stopped");
        }
    }
}
