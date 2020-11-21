using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TokioHotelFanApp.PresentationLayer
{
    class DiscographyViewModel
    {
        private void UserProfileButton_Click(object sender, RoutedEventArgs e)
        {
            UserProfileView userProfile = new UserProfileView();

            userProfile.Show();
        }
        private void Top5Button_Click(object sender, RoutedEventArgs e)
        {
            Top5View top5 = new Top5View();

            top5.Show();
        }

        private void BandInformationButton_Click(object sender, RoutedEventArgs e)
        {
            BandInfoView bandInfo = new BandInfoView();

            bandInfo.Show();
        }
    }
}
