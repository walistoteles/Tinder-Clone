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
                new ProfileModel{ Age = 18, Name = "Goró", Photo = "https://i.pinimg.com/originals/92/6b/10/926b109f89b073fcf1dac5470ad4ed1b.jpg"},
                new ProfileModel{ Age = 22, Name = "Roberto", Photo = "https://i.pinimg.com/originals/56/2f/b9/562fb9244f4a0a077dacfe046b5e5462.jpg"},
                new ProfileModel{ Age = 19, Name = "Spirit", Photo = "https://thumbs.dreamstime.com/b/corridas-do-cavalo-selvagem-35521630.jpg"},
                new ProfileModel{ Age = 21, Name = "Carpiado", Photo = "https://i.pinimg.com/736x/29/f1/70/29f17010d8c48fcb48dc76084487d4fb.jpg"},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

    }
}
