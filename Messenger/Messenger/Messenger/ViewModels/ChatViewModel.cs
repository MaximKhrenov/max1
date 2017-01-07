using Messenger.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Messenger.ViewModels
{
    public class ChatViewModel 
    {
        public ObservableCollection<ChatModel> Chat { get; set; } = new ObservableCollection<ChatModel>
        {
            new ChatModel
            {
                FullName = "Хренов Максим",
                Message = "Приветос",
                Photo = "https://pp.vk.me/c623423/v623423753/302e8/dS7clk06iQg.jpg",
            },
        };
    }
}
