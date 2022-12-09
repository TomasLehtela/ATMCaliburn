using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATMApp.EventModels;
using ATMApp.Models;
using Caliburn.Micro;

namespace ATMApp.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEventModel>, IHandle<OnDepositEventModel>
    {
        private LoginViewModel _loginVM;
        private IEventAggregator _events;
        private LoggedInViewModel _loggedInVM;
        private DepositViewModel _depositVM;
        private SimpleContainer _container;
        public ShellViewModel(LoginViewModel loginVM, IEventAggregator events, LoggedInViewModel loggedInVM,
            SimpleContainer container, DepositViewModel depositVM)
        {
            _events = events;
            _events.Subscribe(this);

            _container = container;

            _loggedInVM = loggedInVM;

            _depositVM = depositVM;

            _loginVM = loginVM;
            ActivateItem(loginVM);

        }

        public void Handle(LogOnEventModel message)
        {
            ActivateItem(_loggedInVM);
            _loginVM = _container.GetInstance<LoginViewModel>();
        }

        public void Handle(OnDepositEventModel message)
        {
            ActivateItem(_depositVM);
            _loggedInVM = _container.GetInstance<LoggedInViewModel>();
        }
    }
}
