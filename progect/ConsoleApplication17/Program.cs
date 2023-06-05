using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Task t1 = new Task();

            int key;

            Console.WriteLine("enter the opertion  1 to add   or 2 to delete  or 3 to search  or 4 to print  ");
        key:
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("enter name of the task to add");
                    t1.name = Console.ReadLine();
                    TaskManager.AddTask(t1);
                    goto key;
                    break;
                case 2:
                    Console.WriteLine("enter name of the task to delete");
                    t1.name = Console.ReadLine();
                    TaskManager.DeleteTask(t1);
                    goto key;
                    break;
                case 3:
                    Console.WriteLine("enter name of the task ");
                    t1.name = Console.ReadLine();
                    TaskManager.SearchForTask(t1);
                    goto key;
                    break;
                case 4:
                    t1.PrintTask();
                    goto key;
                    break;
         
            }

            





        }
    }
}
