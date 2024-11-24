using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPractice
{
    internal class TeamMember
    {
        public string name { get; set; }
        public string emailId { get; set; }

        public List<TaskClass> Tasks { get; set; }

        public TeamMember()
        {
            Tasks = new List<TaskClass>();
        }
    }
    public class TaskClass
    {
        public string  TaskName { get; set; }
        public string completedOn { get; set; }
    }
}
