using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.Contract
{
    public class Account
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public String Title { get; set; }
    }
}
