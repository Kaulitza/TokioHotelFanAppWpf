using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for DiscographyView.xaml
    /// </summary>
    public partial class DiscographyView : Window
    {
        DiscographyViewModel _discographyViewModel;
        public DiscographyView()
        {

        }
        public DiscographyView(DiscographyViewModel discographyViewModel)
        {
            _discographyViewModel = discographyViewModel;
            InitializeComponent();
        }


        private void PlaySong_Click(object sender, RoutedEventArgs e)
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

        private void UserProfileButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

        private void BandInfo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            BandInfoView bandInfoView = new BandInfoView();
            bandInfoView.Show();
        }
    }
}
