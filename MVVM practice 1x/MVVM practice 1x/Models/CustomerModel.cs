using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_practice_1x.Models
{
    class Customer : INotifyPropertyChanged
    {
        private string customerName;
        public Customer(string customerName)
        {
            CustomerName = customerName;
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
                OnNotifyPropertyChanged("CustomerName");
            }
        }

        #region INotifyPropertyChanged Memebers
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
