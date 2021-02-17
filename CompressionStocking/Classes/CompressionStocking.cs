using System;
using System.Collections.Generic;
using System.Text;
using CompressionStocking.Interfaces;

namespace CompressionStocking.Classes
{
    class CompressionStocking : ICompressionStocking
    {
        private ICompressionCtrl compressionCtrl;
        private bool IsCompressed;
        private bool IsDecompressed;

        public CompressionStocking()
        {
            compressionCtrl = new StockingCompressionCtrl();
            IsCompressed = false;
            IsDecompressed = true;
        }

        public void Compress()
        {
            compressionCtrl.Compress();
        }

        public void Decompress()
        {
            compressionCtrl.Decompress();
        }
    }
}
