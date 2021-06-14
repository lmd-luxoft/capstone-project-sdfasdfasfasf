using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinesLogic.EF.Domain
{
    public class Property : Entity
    {
        public decimal BasePrice
        {
            get => default;
            set
            {
            }
        }

        public decimal Balance
        {
            get => default;
            set
            {
            }
        }

        public DateTime CreationDate
        {
            get => default;
            set
            {
            }
        }

        public PropertyType Title
        {
            get => default;
            set
            {
            }
        }

        public string Location
        {
            get => default;
            set
            {
            }
        }

        public IEnumerable<PropertyPriceChange> PropertyPriceChange
        {
            get => default;
            set
            {
            }
        }

        public PropertyType Type
        {
            get => default;
            set
            {
            }
        }
    }
}