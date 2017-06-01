using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularJs2WebApi.Model
{
    public class UserDashboardResponse
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<TaskItem> TaskList { get; set; }
    }

    public class TaskItem
    {
        public DateTime TaskDate { get; set; }
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
    }
}
