using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Lab6MVVM.Models;

namespace Lab6MVVM.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<User> Users { get; set; }

        public MainPageViewModel()
        {
            Users = new();
        }

        [ObservableProperty]
        private string _newName;
        [ObservableProperty]
        private string _newEmail;

        [RelayCommand]
        private void AddUserCommand()
        {
            if (string.IsNullOrEmpty(_newName) || string.IsNullOrEmpty(_newEmail))
            {
                return;
            }
            var user = new User { Name = _newName, Email = _newEmail };
            Users.Add(user);
            NewName = string.Empty;
            NewEmail = string.Empty;
        }
    }
}
