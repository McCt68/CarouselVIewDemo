using CarouselVIewDemo.MVVM.ViewModels;

namespace CarouselVIewDemo.MVVM.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();

		BindingContext = new StartPageViewModel();
	}
}