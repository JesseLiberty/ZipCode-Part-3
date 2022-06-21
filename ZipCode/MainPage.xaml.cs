using Newtonsoft.Json;
using ZipCode.Model;
using ZipCode.ViewModel;

namespace ZipCode;


public partial class MainPage : ContentPage
{
	MainViewModel vm = new MainViewModel();
	public MainPage()
	{
		InitializeComponent();
		BindingContext = vm;
	}


}

