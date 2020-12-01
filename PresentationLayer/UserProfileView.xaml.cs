using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using TokioHotelFanApp.Models;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for UserProfileView.xaml
    /// </summary>
    public partial class UserProfileView : Window
    {
        public UserProfileView()
        {
            InitializeComponent();
        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Users user = new Users();
            using (SqlConnection myConnection = new SqlConnection("datasource=localhost;port=3306;username=root;password"))
            {
                string oString = "update users set name='" + UserNameTextBox.Text + "',password='" + UserPasswordTextBox.Text + "'email='" + UserEmailTextBox.Text;
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                myConnection.Open();

            }
        }
    }
}
