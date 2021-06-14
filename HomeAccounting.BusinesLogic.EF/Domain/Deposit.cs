using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinesLogic.EF.Domain
{
    public class Deposit : Domain.Account
    {
        public string NumberOfBankAccount
        {
            get => default;
            set
            {
            }
        }

        public decimal Persent
        {
            get => default;
            set
            {
            }
        }

        public Bank Bank
        {
            get => default;
            set
            {
            }
        }

        public PersentType Type
        {
            get => default;
            set
            {
            }
        }
    }
}