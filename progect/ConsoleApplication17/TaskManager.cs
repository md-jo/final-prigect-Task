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
        
       public static  void AddTask(Task t1, ArrayList tasks)
        {
            tasks.Add(t1);
      
        }
         public static void DeleteTask(Task t1, ArrayList tasks)
        {
            tasks.Remove(t1);
        }
         public static bool SearchForTask(Task t1, ArrayList tasks)
        {
            return tasks.IndexOf(t1) >= 0 ? true : false; 
            
        }
    }
}
