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
        public DiscographyView _discographyView;
        UserProfileView _userProfileView;
        public ObservableCollection<Albums> _albums;
        public ObservableCollection<Songs> _songs;
        SignUpView signUpView = new SignUpView();



        public GameBusiness()
        {
            SignUpViewInitializer();
            Initializer();

        }
        void SignUpViewInitializer()
        {
            signUpView.Show();
        }
       
        void Initializer()
        {
            

           

        }
    }
}
