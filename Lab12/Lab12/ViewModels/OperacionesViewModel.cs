using Lab12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab12.ViewModels
{
    internal class OperacionesViewModel : ViewModelBase
    {
        //Declaramos las propiedades
        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        string status;
        public string Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        //Activamos los Comandos
        public ICommand Guardar { protected set; get; }

        public ICommand Listar { protected set; get; }

        ObservableCollection<TaskModel> task;
        public ObservableCollection<TaskModel> Tasks
        {
            get { return task; }
            set
            {
                if (task != value)
                {
                    task = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<TaskModel> TaskModels;
        public OperacionesViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>();
            TaskModels = new List<TaskModel>();

            Guardar = new Command(() =>
            {
                TaskModel task = new TaskModel();
                task.title = this.Title;
                task.description = this.Description;
                task.status = this.Status;
                TaskModels.Add(task);
            });

            Listar = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(TaskModels);
            });
        }

    }
}
