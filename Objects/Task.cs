using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Task{
    private string _description;

    public Task(string taskDescription)
    {
      _description = taskDescription;
    }

    public static List<string> ListOfTasks = new List<string> {};

    public string getDescription()
    {
      return _description;
    }
    public void setDescription(string newDescription)
    {
      _description = newDescription;
    }
    public void Save()
    {
      ListOfTasks.Add(this.getDescription());
    }
    public static void DeleteAll()
    {
      ListOfTasks.Clear();
    }
  }
}
