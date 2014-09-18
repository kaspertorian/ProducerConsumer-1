using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            BoundedBuffer buf = new BoundedBuffer();

        Producer prod = new Producer(Buffer, 10);
        Consumer Cons = new Consumer(buf);

        Parallel.Invoke(prod.Run, con.Run);
        }
    }
}
