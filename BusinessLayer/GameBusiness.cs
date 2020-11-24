using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokioHotelFanApp.DataLayer.Data;
using TokioHotelFanApp.Models;
using TokioHotelFanApp.PresentationLayer;

namespace TokioHotelFanApp.BusinessLayer
{

    public class GameBusiness
    {
        public DiscographyViewModel _discographyViewModel;
        DiscographyView _discographyView;
        ObservableCollection<Albums> _albums;
        ObservableCollection<Songs> _songs;


        public GameBusiness()
        {
            Initializer();

        } 
        void Initializer()
        {
            _albums=GameSeedData.AlbumObjects();
            _discographyViewModel = new DiscographyViewModel(_albums);
            _discographyViewModel.SelectedAlbum = _albums.Where(x => x.AlbumName == "Schrei").FirstOrDefault();
            _discographyViewModel.SearchedSongs = GameSeedData.AllSongs();
            _discographyView = new DiscographyView(_discographyViewModel);
            _discographyView.DataContext = _discographyViewModel;
_discographyView.Show();
            _discographyViewModel.discographyView = _discographyView;

        }
    }
}
