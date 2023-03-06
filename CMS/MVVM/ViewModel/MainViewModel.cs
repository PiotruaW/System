using CMS.MVVM.Model;
using desktop_translator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public AddViewModel AddVM { get; set; }
        public ContactViewModel ContactVM { get; set; }
        public HomeViewModel HomeVM { get; set; }
        public ListViewModel ListVM { get; set; }
        public NotificationsViewModel NotificationsVM{ get; set; }
        public SettingsViewModel SettingsVM { get; set; }


        public RelayCommand AddViewCommand { get; set; }
        public RelayCommand ContactViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ListViewCommand { get; set; }
        public RelayCommand NotificationsViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged("CurrentView");
            }
        }

        public MainViewModel()
        {
            AddVM = new AddViewModel();
            ContactVM = new ContactViewModel();
            HomeVM = new HomeViewModel();
            ListVM = new ListViewModel();
            NotificationsVM = new NotificationsViewModel();
            SettingsVM = new SettingsViewModel();

            CurrentView = AddVM;

            AddViewCommand = new RelayCommand(o =>
            {
                CurrentView = AddVM;
            });

            ContactViewCommand = new RelayCommand(o =>
            {
                CurrentView = ContactVM;
            });

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            ListViewCommand = new RelayCommand(o =>
            {
                CurrentView = ListVM;
            });

            NotificationsViewCommand = new RelayCommand(o =>
            {
                CurrentView = NotificationsVM;
            });

            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
        }
    }
}
