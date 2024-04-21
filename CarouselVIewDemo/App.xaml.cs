using CarouselVIewDemo.MVVM.Views;

namespace CarouselVIewDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new AppShell();

            MainPage = new StartPage();
        }
    }
}
