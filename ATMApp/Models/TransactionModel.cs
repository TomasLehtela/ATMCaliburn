using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Models
{
    public class TransactionModel
    {
        public int amount { get; set; }
        public string accountReciever { get; set; }
        public string accountSender { get; set; }
    }
}
