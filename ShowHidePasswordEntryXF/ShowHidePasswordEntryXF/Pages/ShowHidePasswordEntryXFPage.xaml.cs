using Xamarin.Forms;

namespace ShowHidePasswordEntryXF
{
	public partial class ShowHidePasswordEntryXFPage : ContentPage
	{
		LoginVm ViewModel;
		public ShowHidePasswordEntryXFPage()
		{
			InitializeComponent();
			ViewModel = new LoginVm();
			BindingContext = ViewModel;
		}
	}
}
