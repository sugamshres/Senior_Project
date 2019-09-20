using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SchoolApp_Student.ViewModels
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        #region Fields
        private object selectedViewModel;

        #endregion

        #region Constructors
        public NavigationViewModel()
        {
            PersonalInformationCommand = new BaseCommand(OpenPersonalInformation);
            UsernamePasswordCommand = new BaseCommand(OpenUsernamePassword);
        }

        #endregion

        #region Public Properties
        public ICommand PersonalInformationCommand { get; set; }
        public ICommand UsernamePasswordCommand { get; set; }

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
        private void OpenPersonalInformation(object obj)
        {
            SelectedViewModel = new PersonalInformationViewModel();
        }

        private void OpenUsernamePassword(object obj)
        {
            SelectedViewModel = new UsernamePasswordViewModel();
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

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void propertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
