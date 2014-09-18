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
            
        }

        public class Queue<T> : IEnumerable<T>, ICollection, IEnumerable 
        { }
    }
}
