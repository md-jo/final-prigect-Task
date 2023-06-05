using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Task
    {
        public string name
        {
            get;
            set;
        }

        public void PrintTask()
        {
          Console.Write("The last task is  ");
            Console.WriteLine(name);
        }
    }
}
