using Org.Apache.Http.Util;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        List<Fruit> FruitsList = new List<Fruit>()
{
    new Fruit() {Name = "Apple", ImageName = "apple.png", Sentence = "Elmalı turtalarımızı denediniz mi?"},
    new Fruit() {Name = "Apricot", ImageName = "apricot.png", Sentence = "Kayısı reçelimizi denediniz mi?"},
    new Fruit() {Name = "Banana", ImageName = "banana.png", Sentence = "Muzlu milkshake'imiz harika olur!"},
    new Fruit() {Name = "Coconut", ImageName = "coconut.png", Sentence = "Hindistan cevizli tatlarımızı denemelisiniz."},
    new Fruit() {Name = "Grape", ImageName = "grape.png", Sentence = "Üzüm suyu doğal ve taze!"},
    new Fruit() {Name = "Guava", ImageName = "guava.png", Sentence = "Guava meyveli smoothiemiz favori!"},
    new Fruit() {Name = "Kiwi", ImageName = "kiwi.png", Sentence = "Kivi pastamız harika bir tat!"},
    new Fruit() {Name = "Mango", ImageName = "mango.png", Sentence = "Mangolu tatlarımız yaz havası getirir!"},
    new Fruit() {Name = "Melon", ImageName = "melon.png", Sentence = "Kavun salatalarımıza göz atın."},
    new Fruit() {Name = "Orange", ImageName = "orange.png", Sentence = "Portakal suyuyla tazelenin!"},
    new Fruit() {Name = "Peach", ImageName = "peach.png", Sentence = "Şeftalili tartlarımızı çok seveceksiniz!"},
    new Fruit() {Name = "Pear", ImageName = "pear.png", Sentence = "Armut tatlılarımızı denemeye ne dersiniz?"},
    new Fruit() {Name = "Pineapple", ImageName = "pineapple.png", Sentence = "Ananaslı pizzamız favoriniz olacak."},
    new Fruit() {Name = "Plum", ImageName = "plum.png", Sentence = "Erikli keklerimiz tam size göre."}
};


        public MainPage()
        {
            InitializeComponent();
            LvFruits.ItemsSource = FruitsList;
        }

        private void LvFruits_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem= e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailPage(selectedItem));
        }
    }

}
