using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokioHotelFanApp.Models;
using TokioHotelFanApp.BusinessLayer;


namespace TokioHotelFanApp.PresentationLayer
{
    class UserProfileViewModel
    {
        private Users users_;
        public Users User
        {
            get => this.users_;
            set
            {
                this.users_ = value;
               // this.OnPropertyChanged(nameof(this.User));
            }
        }
    }
}
