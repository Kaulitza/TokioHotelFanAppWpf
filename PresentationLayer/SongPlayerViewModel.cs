using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokioHotelFanApp.BusinessLayer;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using TokioHotelFanApp.Models;
using TokioHotelFanApp.DataLayer.Data;

namespace TokioHotelFanApp.PresentationLayer
{
    class SongPlayerViewModel:ObservableObject
    {
        string selectedSong;
        ObservableCollection<string> songlist;

        public ObservableCollection<string> SongList {
            get { return songlist; }
            set
            {
                songlist = value;
                this.OnPropertyChanged(nameof(this.songlist));
            }
        }

       
        public SongPlayerViewModel(ObservableCollection<string> songlist)
        {
            this.songlist = songlist; 
        }


        public string Selectedsong
        {
            get { return selectedSong; }
            set { selectedSong = value;
                this.OnPropertyChanged(nameof(this.selectedSong));
            }
        }

        
    }
}
