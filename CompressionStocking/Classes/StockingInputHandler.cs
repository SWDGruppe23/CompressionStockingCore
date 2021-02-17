using CompressionStocking.Interfaces;

namespace CompressionStocking.Classes
{
    class StockingInputHandler : IInputHandler
    {
        private ICompressionStocking compressionStocking;

        public StockingInputHandler()
        {
            compressionStocking = new CompressionStocking();
        }
        public void StartPushed()
        {
            compressionStocking.Compress();
        }

        public void StopPushed()
        {
            compressionStocking.Decompress();
        }
    }
}
