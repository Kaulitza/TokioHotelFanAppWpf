using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokioHotelFanApp.DataLayer.Data;
using TokioHotelFanApp.Models;
using TokioHotelFanApp.PresentationLayer;
using System.Data.SqlClient;

namespace TokioHotelFanApp.BusinessLayer
{

    public class GameBusiness
    {
        public DiscographyViewModel _discographyViewModel;
        UserProfileViewModel userProfileViewModel;
        DiscographyView _discographyView;
        UserProfileView profileView;
        ObservableCollection<Albums> _albums;
        ObservableCollection<Songs> _songs;
        Users user;

        public GameBusiness()
        {
            Initializer();

        } 
        void Initializer()
        {
            userProfileViewModel = new UserProfileViewModel();
            user = new Users();
            user = GameSeedData.UserData();
            userProfileViewModel.user_ = user;
            profileView.DataContext = userProfileViewModel;
            profileView.Show();
            //_albums=GameSeedData.AlbumObjects();
            //_discographyViewModel = new DiscographyViewModel(_albums);
            //_discographyViewModel.SelectedAlbum = _albums.Where(x => x.AlbumName == "Schrei").FirstOrDefault();
            //_discographyViewModel.SearchedSongs = GameSeedData.AllSongs();
            //_discographyView = new DiscographyView(_discographyViewModel);
            //_discographyView.DataContext = _discographyViewModel;
            // _discographyView.Show();
            //_discographyViewModel.discographyView = _discographyView;

        }
    }
}
