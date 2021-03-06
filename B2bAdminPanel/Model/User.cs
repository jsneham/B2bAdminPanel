using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2bAdminPanel.Model
{
   public class User : INotifyPropertyChanged
    {
        private string userName;
        private string password;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                if (userName != value)
                {
                    userName = value;
                    RaisePropertyChanged("UserName");

                }
            }
        }

        public string Password
        {
            get { return password; }

            set
            {
                if (password != value)
                {
                    password = value;
                    RaisePropertyChanged("Password");

                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
