using MVVM_practice_1x.Commands;
using MVVM_practice_1x.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_practice_1x.ViewModels
{
    class CustomerViewModel
    {
        private Customer customer;
        public CustomerViewModel()
        {
            customer = new Customer("Van Le");
            UpdateCommand = new UpdateCommand(this);
        }


        public Customer Customer
        {
            get
            {
                return customer;
            }
        }


        public bool CanUpdate
        {
            get
            {
                if (Customer == null)
                {
                    return false;
                }
                return !String.IsNullOrWhiteSpace(Customer.CustomerName);
            }
         
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated", Customer.CustomerName));


        }
    }
}
