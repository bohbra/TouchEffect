using System.Windows.Input;
using Xamarin.Forms;

namespace App
{
    public class MainPageViewModel
    {
        public ICommand LoginCommand { get; }

        public MainPageViewModel()
        {
            LoginCommand = new Command(OnLoginClick);
        }

        private void OnLoginClick()
        {
            //Application.Current.MainPage = new Page2();
        }
    }
}
