using ChatApp.Core;
using ChatApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatApp.MVVM.ViewModel

{
    internal class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages {  get; set; }
        public ObservableCollection<FriendsModel> Friends { get; set; }
        public RelayCommand SendCommand { get; set; }

        //Commands
        private FriendsModel _selectedFriend;

        public FriendsModel SelectedFriend
        {
            get { return _selectedFriend; }
            set 
            {
                _selectedFriend = value;
                OnPropertyChanged();
            }
        }


        private string _message;
        public string Message
        {
            get { return _message; }
            set { 
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Friends = new ObservableCollection<FriendsModel>();
            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    IsFirstMessage = false

                });
                Message = "";
            });

            Messages.Add(new MessageModel
            {

                Username = "Test",
                UsernameColor = "#626F47",
                ImageSource = "https://i.imgur.com/Jvh1OQm.jpeg",
                Time = DateTime.Now,
                Message = "First Message",
                IsNativeOrigin = false,
                IsFirstMessage = true,
            });
            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Test",
                    UsernameColor = "#626F47",
                    ImageSource = "https://i.imgur.com/Jvh1OQm.jpeg",
                    Message = "Jarate?",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    IsFirstMessage = false,
                });
            }
            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {

                    Username = "Gamer",
                    UsernameColor = "#626F47",
                    ImageSource = "https://i.imgur.com/Jvh1OQm.jpeg",
                    Message = "Jarate?",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
             
                });
            }
            Messages.Add(new MessageModel
            {

                Username = "Ok",
                UsernameColor = "#626F47",
                ImageSource = "https://i.imgur.com/Jvh1OQm.jpeg",
                Message = "I love jarate! I drink it everyday!",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });
            for(int i = 0;i < 5; i++)
            {
                Friends.Add(new FriendsModel
                {

                    Username = $"Friend {i}",
                    ImageSource = "https://i.imgur.com/Jvh1OQm.jpeg",
                    Messages = Messages
                });
            }
        }
    }
}
