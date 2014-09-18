using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class AbstractBuffer
    {
        private abstract void Put(int element);
        private abstract int Take();

        public Boolean IsEmpty()
        {
            return.true;
        }
    }
}
