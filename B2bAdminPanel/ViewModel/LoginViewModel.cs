using B2bAdminPanel.Command;
using B2bAdminPanel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace B2bAdminPanel.ViewModel
{
    class LoginViewModel: INotifyPropertyChanged
    {

        private User _user;
        public User User
        {
            get { return _user; }
            set { _user = value; NotifyPropertyChanged("User"); }
        }
        public LoginViewModel()
        {
            User = new User();
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
       




        private ICommand _SubmitCommand { get; set; }

       

        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                    _SubmitCommand = new LoginCommand();
                return _SubmitCommand;
            }
            set
            {
                _SubmitCommand = value;
            }
        }




        class LoginCommand : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                //User p = parameter as User;
                //bool st= p != null && p.Password != null;
                return true;
                    
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {
                User p = parameter as User;
               
                if (string.IsNullOrEmpty(p.UserName) || string.IsNullOrEmpty(p.Password))
                {
                    MessageBox.Show("Insert Username and Passowrd");

                }
                else
                {
                 MessageBox.Show("Sucessful");

                }
            }

            #endregion
        }


       
    }
    
}
