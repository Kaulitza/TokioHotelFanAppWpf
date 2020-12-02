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
using System.Data.SqlClient;
using System.Data;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for LogInView.xaml
    /// </summary>
    public partial class LogInView : Window
    {
        public LogInView()
        {
            InitializeComponent();
        }

        private void LogInClick(object sender, RoutedEventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection(@"Data Source = localhost; Initial Catalog=TokioHotelFanApp; Integrated Security = True");
            try
            {
                if (SqlCon.State == ConnectionState.Closed)
                    SqlCon.Open();
                String query = "SELECT COUNT(1) FROM dbo.User WHERE Username =@Username AND Password =@Password";
                SqlCommand sqlCommand = new SqlCommand(query, SqlCon);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddWithValue("@Username",EmailTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                int count = Convert.ToInt32(sqlCommand.ExecuteScalar());
                if (count == 1)
                {
                    UserProfileView userProfile = new UserProfileView();
                    userProfile.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");

                }
            }
            catch (Exception)
            {
                throw;
            }

         
        }

    }
}
