using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    //First version - not thread-safe
    public sealed class SingletonVersion1
    {
        private static int counter = 0;
        private static SingletonVersion1 instance=null;
        
        // Private Constructor 
        private SingletonVersion1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            counter++;
            Console.WriteLine("Private Constructor Called Counter " + counter.ToString());
        }

        public static SingletonVersion1 GetInstance
        {
            get
            {
                if (instance == null)
                { 
                  instance = new SingletonVersion1();
                }
                return instance;
            }
        }

        public void PrintDetails(string message)
        {
           
            Console.WriteLine(message);
        }
    }
}
