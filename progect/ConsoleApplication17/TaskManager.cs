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
            tasks.Add(t1);
      
        }
         public static void DeleteTask(Task t1)
        {
            tasks.Remove(t1);
        }
         public static bool SearchForTask(Task t1)
        {
            return tasks.IndexOf(t1) >= 0 ? true : false; 
            
        }
    }
}
