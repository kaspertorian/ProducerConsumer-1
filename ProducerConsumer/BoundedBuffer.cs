using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class BoundedBuffer
    {
        private int _max;
        public int Capacity;
        public BoundedBuffer(int capacity)
        {
            this._max = capacity;

            queue = new Queue<int>(capacity);

        }
      
        private Queue<int> queue; 
        
        public void Put(int element)
        {
            
        }

        public int Take()
        {
            
        }

       public Boolean IsFull()
        {
         return true;
        }

        public BoundedBuffer(int capacity)
        {
            queue = new Queue<int>(capacity);


        }

        
    }
}
