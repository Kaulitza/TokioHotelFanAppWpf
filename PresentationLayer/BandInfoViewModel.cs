using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TokioHotelFanApp.PresentationLayer
{
    class BandInfoViewModel
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
        private void DiscographyButton_Click(object sender, RoutedEventArgs e)
        {
            DiscographyView discography = new DiscographyView();

            discography.Show();
        }
    }
}
