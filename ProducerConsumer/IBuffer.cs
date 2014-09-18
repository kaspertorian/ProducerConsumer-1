using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class IBuffer
    {
        public int Count 
        { get;  }

        public bool IsEmpty()
        {
            return true;
        }

        public int Take()
        {
            
        }

        public void Put(int element)
        {
            
        }
    }
}
