using B2bAdminPanel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace B2bAdminPanel.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            try
            {
                InitializeComponent();
                LoginViewModel viewModel = new LoginViewModel();
                this.DataContext = viewModel;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
        }
    }
}
