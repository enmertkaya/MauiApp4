using Org.Apache.Http.Util;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        List<string> FruitsList = new List<string>()
        {
            "Apple","Banana","Cocunut","Grape","Guava","Kiwi","Mango","Melon"
        };

        public MainPage()
        {
            InitializeComponent();
            LvFruits.ItemsSource = FruitsList;
        }

        
    }

}
