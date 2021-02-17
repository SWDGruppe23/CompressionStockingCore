using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CompressionStocking.Interfaces;
using Timer = System.Timers.Timer;

namespace CompressionStocking.Classes
{
    class StockingCompressionCtrl : ICompressionCtrl
    {
        private readonly Pump _pump;
        private const int CompressionTime = 5, DecompressionTime = 2;

        public StockingCompressionCtrl()
        {
            _pump = new Pump();
        }
        public void Compress()
        {
            _pump.Compress();
            for (int i = 0; i < CompressionTime; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Pump compressing for {i+1} seconds");
            }
            _pump.Stop();
        }

        public void Decompress()
        {
            _pump.Decompress();
            for (int i = 0; i < DecompressionTime; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Pump decompressing for {i+1} seconds");
            }
            _pump.Stop();
        }
    }
}
