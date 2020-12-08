using System;
using System.Collections;
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
using System.Windows.Controls.Primitives;

using System.Windows.Threading;
using TokioHotelFanApp.DataLayer.Data;
using TokioHotelFanApp.Models;
using System.Collections.ObjectModel;

namespace TokioHotelFanApp.PresentationLayer
{
    /// <summary>
    /// Interaction logic for SongPlayerView.xaml
    /// </summary>
    public partial class SongPlayerView : Window
    {
        MediaPlayer mplayer;
        bool play = true;

        bool isDragging = false;


        public DiscographyViewModel _discographyViewModel;
        public DiscographyView _discographyView;
        public ObservableCollection<Albums> _albums;
        public ObservableCollection<Songs> _songs;
        //private ArrayList LoadListBoxData()
        //{
        //    ArrayList itemsList = new ArrayList();
        //    itemsList.Add("Ich brech aus");
        //    itemsList.Add("Tea");
        //    itemsList.Add("Orange Juice");
        //    itemsList.Add("Milk");
        //    itemsList.Add("Mango Shake");
        //    itemsList.Add("Iced Tea");
        //    itemsList.Add("Soda");
        //    itemsList.Add("Water");
        //    return itemsList;
        //}
        //System.Collections.ObjectModel.ObservableCollection[] songList;
        //System.Collections.ObjectModel.ObservableCollection<string> songList;
        public SongPlayerView()
        {
            //songList = new System.Collections.ObjectModel.ObservableCollection<string>();
            ////songList[0] = "Ich brech aus";
            ////songList[1] = "Tokio Hotel - An deiner Seite (Ich bin da) Lyrics";
            ////songList[2] = "Tokio Hotel - Heilig lyrics";
            ////songList[3] = "Tokio Hotel - In die Nacht with Lyrics";
            ////songList[4] = "Tokio Hotel - Nach dir kommt nichts lyrics";
            ////songList[5] = "Tokio Hotel - Reden Lyrics";
            ////songList[6] = "Tokio Hotel - Spring nicht lyrics";
            ////songList[7] = "Tokio Hotel - Stich Ins Glück Lyrics";
            ////songList[8] = "Tokio Hotel - Totgeliebt (Lyrics w_ English Translation)";
            ////songList[9] = "Tokio Hotel - Übers Ende der Welt (Lyrics w_ English Translation)";
            ////songList[10] = "Tokio Hotel - Wir sterben niemals aus lyrics";
            ////songList[11] = "Vergessene kinder";
            ////songList[12] = "wo sind eure hande - tokio hotel (lyric)";
            //SongsList.Items.Add("Ich brech aus");
            //SongsLists.ItemsSource = LoadListBoxData();

            mplayer = new MediaPlayer();
            mplayer.MediaFailed += (o, args) =>
            {
                MessageBox.Show("Media Failed!!");
            };
            mplayer.Open(new Uri("../../Audios/Tokio Hotel - An deiner Seite (Ich bin da) Lyrics.mp3", UriKind.RelativeOrAbsolute));
            mplayer.Play();



            InitializeComponent();

            
           

        }

      
        private void SeekToMediaPosition(object sender, RoutedPropertyChangedEventArgs<double> args)
        {


            int SliderValue = (int)timelineSlider.Value;

            // Overloaded constructor takes the arguments days, hours, minutes, seconds, milliseconds.
            // Create a TimeSpan with miliseconds equal to the slider value.
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            mplayer.Position = ts;

            // Overloaded constructor takes the arguments days, hours, minutes, seconds, milliseconds.
            // Create a TimeSpan with miliseconds equal to the slider value.
        }
        private void Element_MediaEnded(object sender, EventArgs e)
        {
            mplayer.Stop();
        }
        private void Element_MediaOpened(object sender, EventArgs e)
        {
            timelineSlider.Maximum = mplayer.NaturalDuration.TimeSpan.TotalMilliseconds;
        }
        private void ChangeMediaVolume(object sender, RoutedPropertyChangedEventArgs<double> args)
        {
            mplayer.Volume = (double)volumeSlider.Value;
        }
        void OnMouseDownStopMedia(object sender, MouseButtonEventArgs args)
        {
            play = !play;
            // playImage.Source = new BitmapImage(new Uri(@"pause.png"));
            // The Stop method stops and resets the media to be played from
            // the beginning.
            playImage.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Images\play.png", UriKind.Absolute));

            mplayer.Stop();
        }
        void OnMouseDownPlayMedia(object sender, MouseButtonEventArgs args)
        {
            if (play)
            {
                mplayer.Pause();
                playImage.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Images\play.png", UriKind.Absolute));
            }
            else
            {
                playImage.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Images\pause.png", UriKind.Absolute));
                mplayer.Play();
            }
            play = !play;
            // The Pause method pauses the media if it is currently running.
            // The Play method can be used to resume.
        }

       

        private void SongsLists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(SongsLists.SelectedItem== "wo sind eure hande - tokio hotel (lyric)")
            {
                mplayer.Open(new Uri("../../Audios/wo sind eure hande - tokio hotel (lyric).mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Vergessene kinder")
            {
                mplayer.Open(new Uri("../../Audios/Vergessene kinder.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Wir sterben niemals aus lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Wir sterben niemals aus lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Übers Ende der Welt (Lyrics w_ English Translation)")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Übers Ende der Welt (Lyrics w_ English Translation).mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Totgeliebt (Lyrics w_ English Translation)")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Totgeliebt (Lyrics w_ English Translation).mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Stich Ins Glück Lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Stich Ins Glück Lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Spring nicht lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Spring nicht lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Reden Lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Reden Lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Nach dir kommt nichts lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Nach dir kommt nichts lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - In die Nacht with Lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - In die Nacht with Lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - Heilig lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - Heilig lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Tokio Hotel - An deiner Seite (Ich bin da) Lyrics")
            {
                mplayer.Open(new Uri("../../Audios/Tokio Hotel - An deiner Seite (Ich bin da) Lyrics.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
            else if (SongsLists.SelectedItem == "Ich brech aus")
            {
                mplayer.Open(new Uri("../../Audios/Ich brech aus.mp3", UriKind.RelativeOrAbsolute));
                mplayer.Play();
            }
        }

        private void BandInfo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mplayer.Close();
            this.Close();
            BandInfoView bandInfoView = new BandInfoView();
            bandInfoView.Show();
            

        }

        private void DiscographyButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mplayer.Close();

            _albums = GameSeedData.AlbumObjects();
            _discographyViewModel = new DiscographyViewModel(_albums);
            _discographyViewModel.SelectedAlbum = _albums.Where(x => x.AlbumName == "Schrei").FirstOrDefault();
            _discographyViewModel.SearchedSongs = GameSeedData.AllSongs();
            _discographyView = new DiscographyView(_discographyViewModel);
            _discographyView.DataContext = _discographyViewModel;
            _discographyView.Show();
            _discographyViewModel.discographyView = _discographyView;
        }

        private void UserProfileButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mplayer.Close();
        }



        //private void timelineSlider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        //{
        //    userIsDraggingSlider = true;
        //}

        //private void timelineSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        //{
        //    userIsDraggingSlider = false;
        //    mplayer.Position = TimeSpan.FromSeconds(sl);

        //}
    }
}
