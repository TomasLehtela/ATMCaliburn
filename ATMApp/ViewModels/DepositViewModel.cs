using ATMApp.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.ViewModels
{
    public class DepositViewModel : Screen
    {
        private IEventAggregator _events;

        private int _amount;
        private string _accountReciever;
        private string _accountSender;
        public int Amount
        {
            get { return _amount; }
            set
            {
                _amount = value;
                NotifyOfPropertyChange(() => Amount);
            }
        }
        public string AccountReciever
        {
            get { return _accountReciever; }
            set
            {
                _accountReciever = value;
                NotifyOfPropertyChange(() => AccountReciever);
            }
        }
        public string AccountSender
        {
            get { return _accountSender; }
            set
            {
                _accountSender = value;
                NotifyOfPropertyChange(() => AccountSender);
            }
        }
        public int DepositAmountInput { get; set; }
        public string AccountRecieverInput { get; set; }

        private BindableCollection<TransactionModel> _transactions = new BindableCollection<TransactionModel>();
        public BindableCollection<TransactionModel> Transactions
        {
            get { return _transactions; }
            set { _transactions = value; }
        }

        public DepositViewModel(IEventAggregator events)
        {
            _events = events;

            Transactions.Add(new TransactionModel { amount = 111, accountReciever = "admin", accountSender = "testuser" });
            Transactions.Add(new TransactionModel { amount = 222, accountReciever = "testuser", accountSender = "admin" });

        }

        public void ConfirmDepositButton()
        {

            Transactions.Add(new TransactionModel { amount = DepositAmountInput, accountReciever = AccountRecieverInput, accountSender = "admin" });
        }

        public int GetAccountBalance()
        {
            LoginViewModel newLoginViewModel = new LoginViewModel(_events);
            foreach (var user in newLoginViewModel.Users)
            {
                if (user.Username == "admin")
                {
                    int accBal = user.AccountBalance;
                    return accBal;
                }
            }
            return 1;
        }



        public int AccountBalance
        {
            get
            {
                return GetAccountBalance();
            }
            set
            {
                AccountBalance = value;
                NotifyOfPropertyChange(() => AccountBalance);
            }
        }
    }
}
