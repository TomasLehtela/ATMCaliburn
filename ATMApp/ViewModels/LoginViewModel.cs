using ATMApp.EventModels;
using ATMApp.Models;
using ATMApp.Views;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ATMApp.ViewModels
{
    public class LoginViewModel : Screen
    {
		private string _username;
        private string _password;
        private int _accountBalance;
        private IEventAggregator _events;
        private UserModel _selectedUser;
        private BindableCollection<UserModel> _users = new BindableCollection<UserModel>();
        public LoginViewModel(IEventAggregator events)
        {
            _events = events;


            Users.Add(new UserModel { Username = "admin", Password = "password", AccountBalance = 1111 });
            Users.Add(new UserModel { Username = "testuser", Password = "password", AccountBalance = 2222 });

        }
        public string Username
		{
			get { return _username; }
			set 
			{ 
				_username = value; 
				NotifyOfPropertyChange(() => Username);
                NotifyOfPropertyChange(() => CanLoginButton);
            }
		}

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLoginButton);
            }
        }

        public int AccountBalance
        {
            get { return _accountBalance; }
            set
            {
                _accountBalance = value;
                NotifyOfPropertyChange(() => AccountBalance);
            }
        }

        public BindableCollection<UserModel> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public UserModel SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                NotifyOfPropertyChange(() => SelectedUser);
            }
        }

        public bool CanLoginButton
        {
            get
            {
                bool output = false;
                if (Username?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }
        public void LoginButton()
        {
            foreach (var user in Users)
            {
                if (user.Username == Username && user.Password == Password)
                {
                    MessageBox.Show("Logged in");
                    _events.PublishOnUIThread(new LogOnEventModel());
                }
            }
        }


    }
}
