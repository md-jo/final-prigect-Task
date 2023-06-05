using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication17
{
    static class TaskManager
    {
         static ArrayList tasks = new ArrayList();
        
       public static  void AddTask(Task t1)
        {
            string Name = t1.name;
            tasks.Add(Name);
      
        }
         public static void DeleteTask(Task t1)
        {
            string Name = t1.name;
            tasks.Remove(Name);
        }
         public static void SearchForTask(Task t1)
        {
            string Name = t1.name;
            int index = tasks.IndexOf(Name) ;
                        if (index > -1)
            {
                Console.WriteLine("the index of Task = " +index);
            }
            else
                Console.WriteLine("there is no Task by this name ");
        }
    }
}
