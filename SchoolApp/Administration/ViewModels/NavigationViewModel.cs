using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Administration.ViewModels
{
    public class NavigationViewModel : BaseViewModel, INotifyPropertyChanged
    {
        #region Fields
        private object selectedViewModel;

        #endregion

        #region Constructors
        public NavigationViewModel()
        {
            SchoolSetupCommand = new BaseCommand(OpenSchoolSetupView);
            ProfessorsCommand = new BaseCommand(OpenProfessorsView);
        }

        #endregion

        #region Public Properties
        public ICommand SchoolSetupCommand { get; set; }
        public ICommand ProfessorsCommand { get; set; }

        #endregion

        #region Public Methods
        public object SelectedViewModel
        {
            get
            {
                return selectedViewModel;
            }
            set
            {
                selectedViewModel = value;
                propertyChanged("SelectedViewModel");
            }
        }

        #endregion

        #region Private Methods
        private void OpenSchoolSetupView(object obj)
        {
            SelectedViewModel = new SchoolSetupViewModel();
        }
        
        private void OpenProfessorsView(object obj)
        {
            SelectedViewModel = new ProfessorsViewModel();
        }
        #endregion

        //Do not remove the code below
        #region ICommand
        public class BaseCommand : ICommand
        {
            private Predicate<object> _canExecute;
            private Action<object> _method;
            public event EventHandler CanExecuteChanged;

            public BaseCommand(Action<object> method)
                : this(method, null)
            {
            }

            public BaseCommand(Action<object> method, Predicate<object> canExecute)
            {
                _method = method;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter)
            {
                if (_canExecute == null)
                {
                    return true;
                }

                return _canExecute(parameter);
            }

            public void Execute(object parameter)
            {
                _method.Invoke(parameter);
            }
        }
        #endregion

    }
}
