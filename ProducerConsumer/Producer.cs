using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Producer
    {
        private BoundedBuffer _buffer;
        private int _max;
        public Producer(BoundedBuffer buf, int howmany)
        {
            this._buffer = buf;
            this._max = howmany;

        }

        public void Run()
        {
            for (int i = 0; i < this._max; i++)
            {
                this._buffer.Put(i);
            }
        }



        public static int LastElement = -1;
        public static int LastItem = -1;

       
        
    }
}
