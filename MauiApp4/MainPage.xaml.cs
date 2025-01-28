using Org.Apache.Http.Util;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnGoToPage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2(EntUserName.Text));
        }
    }

}
