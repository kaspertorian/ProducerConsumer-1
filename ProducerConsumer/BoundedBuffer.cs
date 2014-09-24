using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    

    class BoundedBuffer
    {
        private int _max;
        private Queue<int> _q;
        //public int Capacity;


        public BoundedBuffer(int capacity)
        {
            this._max = capacity;
            this._q = new Queue<int>(capacity);
        }
      
       public void Put(int element)
        {

           lock (this._q)
           {
               while (this.IsFull())
               {
                   Monitor.Wait(this._q);
               }
                   this._q.Enqueue(element);
                   Console.WriteLine("just added {0} into the buffer.", element);
                   Monitor.PulseAll(this._q);
               
           }
        }

        public int Take()
        {
            lock (this._q)
            {
                while (this._q.Count ==0)
                {
                    // Wait until the queue is not-empty
                    Monitor.Wait(this._q);
                }
           
                int temp = this._q.Dequeue();
                Console.WriteLine("just took {0} from the buffer.", temp);
                return temp;  
            }
            
            
        }

       public bool IsFull()
        {
           if (this._q.Count < this._max)
           {
               return false;
           }

           return true;
        }

        
        


       

        
    }
}
