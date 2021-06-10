using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.Datasource.Contract
{
    public class DBAccount
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public String Title { get; set; }
    }
}
