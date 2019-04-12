using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace MatchBuilder.ViewModels
{
    public class AddPlayerViewModel : BaseViewModel
    {
        public AddPlayerViewModel()
        {
            Title = "Add Player";

            //OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}