using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Task{
    // public string Description {get; set;}
    private string _description;

    public Task(string taskDescription)
    {
      _description = taskDescription;
    }
    public string getDescription()
    {
      return _description;
    }
    public void setDescription(string newDescription)
    {
      _description = newDescription;
    }
  }
}
