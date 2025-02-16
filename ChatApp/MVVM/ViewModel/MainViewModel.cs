using ChatApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages {  get; set; }
        public ObservableCollection<FriendsModel> Friends { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Friends = new ObservableCollection<FriendsModel>();

            Messages.Add(new MessageModel
            {

                Username = "Test",
                UsernameColor = "#626F47",
                ImageSource = "https://i.imgur.com/Jvh1OQm.jpeg",
                Time = DateTime.Now,
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
                Message = "Im jorking it rn",
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
