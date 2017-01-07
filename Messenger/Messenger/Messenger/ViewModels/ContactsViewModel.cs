using Messenger.Models;
using Messenger.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Messenger.ViewModels
{
    public class ContactsViewModel
    {
       
           public ObservableCollection<ContactModel> Contacts { get; set; } = new ObservableCollection<ContactModel>
           {
               new ContactModel
               {
                   FullName = "Максим Хренов",
                   LastMessage = "Приветос",
                   Photo = "https://vk.com/hrenovmax?z=photo182832753_367676578%2Falbum182832753_0%2Frev",
               },

           };

      

        public ICommand ProfileCommand { get; set; }

        public ICommand ExitCommand { get; set; }


        

        private Page _page;

        public ContactsViewModel(Page page)
        {
            _page = page;

            ExitCommand = new Command(OpenExit);
            ProfileCommand = new Command(OpenProfile);
        }


        private async void OpenProfile()
        {
            await _page.Navigation.PushAsync(new ProfilePage());
        }

        public async Task OpenChat()
        {
            await _page.Navigation.PushAsync(new ChatPage());
        }

        private async void OpenExit()
        {
            await _page.Navigation.PushAsync(new LoginPage());
        }
    }
}
