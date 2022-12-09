using ATMApp.EventModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.ViewModels
{
    public class LoggedInViewModel : Screen
    {
        public IEventAggregator _events;

        public LoggedInViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public void DepositButton()
        {
            _events.PublishOnUIThread(new OnDepositEventModel());
        }

    }
}
