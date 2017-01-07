using Messenger.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Messenger.ViewModels
{
    public class ProfileViewModel
    {
        public ICommand Photo { get; set; }

        public string FullName { get; set; }

        public ICommand SaveCommand { get; set; }





        private Page _page;

        public ProfileViewModel(Page page)
        {
            _page = page;
            SaveCommand = new Command(OpenContacts);

        }

        private async void OpenContacts()
        {
            await _page.Navigation.PushAsync(new ContactsPage());
        }
    }
}