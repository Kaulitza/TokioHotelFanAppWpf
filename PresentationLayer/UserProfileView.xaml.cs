using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySqlConnector;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TokioHotelFanApp.Models;
using Renci.SshNet.Messages;
using TokioHotelFanApp.DataLayer.Data;
using System.Collections.ObjectModel;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for UserProfileView.xaml
    /// </summary>
    public partial class UserProfileView : Window
    {
         UserProfileViewModel _UserProfileViewModel;
        public UserProfileView()
        {

        }
         public UserProfileView(UserProfileViewModel userProfileViewModel)
        {
            _UserProfileViewModel = userProfileViewModel;
            InitializeComponent();
        }

        private void EditInfo_Click(object sender, RoutedEventArgs e)
        {
            UserEmailTextBox.IsReadOnly = false;
            UserNameTextBox.IsReadOnly = false;
            UserPasswordTextBox.IsReadOnly = false;

           

        }

        private void SaveInformation(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            string name = UserNameTextBox.Text.ToString();
            string email = UserEmailTextBox.Text.ToString();
            string password = UserPasswordTextBox.Text.ToString();
            try
            {
                string MyConString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=tokiohotel;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "UPDATE users SET name = @nam, password=@pass,email = @eml";
                command.Parameters.AddWithValue("@nam", name);
                command.Parameters.AddWithValue("@pass", password );
                command.Parameters.AddWithValue("@eml", email);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void DeleteInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you Sure?");
            string name = UserNameTextBox.Text.ToString();
            string email = UserEmailTextBox.Text.ToString();
            string password = UserPasswordTextBox.Text.ToString();
            try
            {
                string MyConString = "Server=127.0.0.1;Port=3306;Uid=root;Pwd=;Database=tokiohotel;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "DELETE FROM users WHERE name = @nm and email=@ml";
                command.Parameters.AddWithValue("@nm", name);
                command.Parameters.AddWithValue("@ml", email);
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();

                Application.Current.Shutdown();

            }
            catch (Exception)
            {
                MessageBox.Show("DB Error");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<string> songList = new ObservableCollection<string>();

            songList.Add("Ich brech aus");
            songList.Add("Tokio Hotel - An deiner Seite (Ich bin da) Lyrics");
            songList.Add("Tokio Hotel - Heilig lyrics");
            songList.Add("Tokio Hotel - In die Nacht with Lyrics");
            songList.Add("Tokio Hotel - Nach dir kommt nichts lyrics");
            songList.Add("Tokio Hotel - Reden Lyrics");
            songList.Add("Tokio Hotel - Spring nicht lyrics");
            songList.Add("Tokio Hotel - Stich Ins Glück Lyrics");
            songList.Add("Tokio Hotel - Totgeliebt (Lyrics w_ English Translation)");
            songList.Add("Tokio Hotel - Übers Ende der Welt (Lyrics w_ English Translation)");
            songList.Add("Tokio Hotel - Wir sterben niemals aus lyrics");
            songList.Add("Vergessene kinder");
            songList.Add("wo sind eure hande - tokio hotel (lyric)");


            SongPlayerViewModel songPlayerViewModel = new SongPlayerViewModel(songList);

            SongPlayerView songPlayerView = new SongPlayerView();
            songPlayerView.DataContext = songPlayerViewModel;
            songPlayerView.Show();

        }
    }
}
