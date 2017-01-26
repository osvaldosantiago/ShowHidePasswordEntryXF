using System;
using Xamarin.Forms;

namespace ShowHidePasswordEntryXF
{
	public class LoginVm: BaseViewModel
	{
		public LoginVm()
		{
			SignInCommand = new Command(SignInAction);
		}
		async void SignInAction() 
		{
			await App.Current.MainPage.DisplayAlert("Alert","Tu usuario: "+Email,"Close");	
		}
		protected string _email;
		public string Email
		{
			get { return _email; }
			set
			{
				_email = value;
				OnPropertyChanged(nameof(Email));
			}
		}

		protected string _password;
		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				OnPropertyChanged(nameof(Password));

			}
		}
		protected Command _signInCommand;
		public Command SignInCommand
		{
			get { return _signInCommand; }
			set
			{
				_signInCommand = value;
				OnPropertyChanged(nameof(SignInCommand));
			}
		}

	}
}
