using Nancy;
using Nancy.ViewEngines.Razor;

namespace ToDoList
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
            Post["/task_added"] = _ => {
              // var NewTask = new Task {
              //   Description = Request.Form["new-task"]
              // };
              var NewTask = new Task (Request.Form["new-task"]);
              NewTask.Save();
              // Task.Save(NewTask.getDescription());
              return View["task_added.cshtml", NewTask];
            };
            Get["/view_all_tasks"] = _ => {
              var AllTasks = Task.ListOfTasks;
              return View["view_all_tasks.cshtml", AllTasks];
            };
        }
    }
}
