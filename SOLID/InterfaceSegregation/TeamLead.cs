using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregation
{
    public class TeamLead : IProgrammer, ILead
    {
        public void AssignTask()
        {
            //Code to assign a Task  
        }
        public void CreateSubTask()
        {
            //Code to create a sub task from a task.  
        }
        public void WorkOnTask()
        {
            //code to implement to work on the Task.  
        }
    }
}
