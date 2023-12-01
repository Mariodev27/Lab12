using Lab12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab12.ViewModels
{
    // TaskViewModel.cs
    // TaskViewModel.cs
    public class TaskViewModel : ViewModelBase
    {
        private List<Task> _tasks;

        public List<Task> Tasks
        {
            get { return _tasks; }
            set
            {
                if (_tasks != value)
                {
                    _tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public TaskViewModel()
        {
            Tasks = new List<Task>();

            
        }

        //Save = new Command(() =>

        public void InsertTask(Task task)
        {
            Tasks.Add(task);
        }

        public List<Task> ListTasks()
        {
            return Tasks;
        }

        //Get = new Command
    }
}
