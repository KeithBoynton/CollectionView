namespace MauiApp1;

public partial class MainPage : ContentPage
{
    readonly ViewModel vm;

	public MainPage()
	{
		InitializeComponent();

		BindingContext = vm = new ViewModel();
	}

    protected override void OnAppearing()
    {
		vm.PreSelectFromOnAppearing();
        base.OnAppearing();
    }
}
