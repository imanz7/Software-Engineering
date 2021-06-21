using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Quiz2_1716668
{
    // (a) This is a deadlock phenomena whereby two threads wait
    // for a resource held by the other, so neither of the thread can proceed.
    // Hence, it is required to use a thread-safe function so it can be
    // accessed from multiple threads without any issues.

    class Program
    {
        static bool done = false;               // to check either the thread has been done or not
        static object object1 = new object();   // object1 to lock thread or function
        static object object2 = new object();   // object2 to lock thread or function

        public static void FirstFunction()
        {
            Thread.Sleep(1000);

            lock (object1)
            {
                // Lock this thread with object1 and wait until it is completed before proceed with other thread. 
                // After this thread is completed, this thread will be unlocked and other thread can proceed
                // as the object1 status is available.

                if (!done)
                {
                    lock (object2)
                    {
                        // Lock this thread with object2.
                        // After the work is done, done status is changed to true
                        // and object2 will be unlocked (available status).
                        // This is important to ensure the thread won't be in deadlock phenomena
                        // if the done status is not being used.

                        Console.WriteLine("FirstFunction gets Lock 2");
                        done = true;
                    }

                    Console.WriteLine("FirstFunction gets Lock 1");
                }
            }
        }

        public static void SecondFunction()
        {
            Thread.Sleep(1000);

            lock (object2)
            {
                // While object2 is locked, this thread remain locked and will not proceed
                // until object2 status changed to available.
                // After object2 status has been available, it will done this function and locked other threads

                lock (object1)
                {
                    // if object1 has been available (unlocked), it will lock this function until everything has been done
                    // after this function is done, the done status changed to true and it will make object1 status as available

                    Console.WriteLine("SecondFunction gets Lock 1");
                    done = true;
                }
                
                Console.WriteLine("SecondFunction gets Lock 2");
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(FirstFunction);
            Thread thread2 = new Thread(SecondFunction);

            thread1.Start();
            thread2.Start();

            Console.ReadLine();
        }
    }
}
