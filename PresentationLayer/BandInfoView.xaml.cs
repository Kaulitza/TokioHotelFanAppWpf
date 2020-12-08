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
using TokioHotelFanApp.DataLayer.Data;
using TokioHotelFanApp.Models;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for BandInfoView.xaml
    /// </summary>
    public partial class BandInfoView : Window
    {
        public DiscographyViewModel _discographyViewModel;
        public DiscographyView _discographyView;
        public ObservableCollection<Albums> _albums;
        public ObservableCollection<Songs> _songs;
        public BandInfoView()
        {
            InitializeComponent();
        }

        private void UserProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Discography_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            _albums = GameSeedData.AlbumObjects();
            _discographyViewModel = new DiscographyViewModel(_albums);
            _discographyViewModel.SelectedAlbum = _albums.Where(x => x.AlbumName == "Schrei").FirstOrDefault();
            _discographyViewModel.SearchedSongs = GameSeedData.AllSongs();
            _discographyView = new DiscographyView(_discographyViewModel);
            _discographyView.DataContext = _discographyViewModel;
            _discographyView.Show();
            _discographyViewModel.discographyView = _discographyView;
        }

        private void DiscographyButton_Copy_Click(object sender, RoutedEventArgs e)
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
