using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularJs2WebApi.Model;

namespace AngularJs2WebApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        [Route("Login")]
        public LoginResponse Login([FromBody]LoginRequest request)
        {
            return new LoginResponse
            {
                Name = request.UserName,
                Surname = request.UserName,
                UserId = Guid.NewGuid().ToString()
            };
        }

        [HttpGet]
        [Route("GetUserDashboard")]
        public UserDashboardResponse GetUserDashboard([FromBody]UserDashboardRequest request)
        {
            UserDashboardResponse response = new UserDashboardResponse();
            response.Name = "Tufan";
            response.Surname = "Dayı";
            response.TaskList = new List<TaskItem>();

            for (int i = 0; i < 10; i++)
            {
                TaskItem taskItem = new TaskItem();
                taskItem.TaskDate = DateTime.Now.AddDays(-1 * i);
                taskItem.TaskName = "Task " + i;
                taskItem.IsCompleted = i % 2 == 0 ? true : false;
                response.TaskList.Add(taskItem);
            }

            return response;
        }
    }
}
