using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Singleton
    {
        private static int object_counter = 0;

     
        private static Singleton instance = null;

       
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    
        private Singleton()
        {
            object_counter++;
            Console.WriteLine("Object Created count" + object_counter.ToString());
        }
       
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
