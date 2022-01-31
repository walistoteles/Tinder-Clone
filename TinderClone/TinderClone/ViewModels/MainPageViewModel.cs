using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TinderClone.Models;

namespace TinderClone.ViewModels
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<ProfileModel> _profiles;
        public ObservableCollection<ProfileModel> Profiles
        {
            get { return _profiles; }
            set
            {
                _profiles = value;
                NotifyPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            new AsyncCommand(GetProfiles).ExecuteAsync();
        }

        async Task GetProfiles()
        {
            Profiles = new ObservableCollection<ProfileModel>
            {
                new ProfileModel{ Age = 18, Name = "Natthalia", Photo = "https://www.usni.org/sites/default/files/styles/hero_image_2400/public/Klima%20%26%20Klima-NH-MA-19%201.jpg?itok=Ndl2R6Hx"},
                new ProfileModel{ Age = 22, Name = "Bruna", Photo = "https://media.istockphoto.com/photos/portrait-beautiful-young-woman-with-clean-fresh-skin-picture-id1329622588?b=1&k=20&m=1329622588&s=170667a&w=0&h=MrsM7nyIOW4Gt5PM5Vs6xYIMJ1nr1FLT9bvt0Sve-S4="},
                new ProfileModel{ Age = 19, Name = "Pietra", Photo = "https://emirateswoman.com/wp-content/uploads/2019/10/Bella-Hadid-1.jpg"},
                new ProfileModel{ Age = 21, Name = "Evee", Photo = "https://nypost.com/wp-content/uploads/sites/2/2020/12/yael-most-beautiful-video.jpg?quality=90&strip=all"},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
