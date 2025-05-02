using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace DataGridSample
{

    public class OrderInfo : INotifyPropertyChanged
    {
        string orderID;
        string customerId;
        string country;
        string customerName;
        string shipCity;
        public string OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                OnPropertyChanged("OrderID");
            }
        }
        public string CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerID");
            }
        }
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        public string ShipCity
        {
            get { return shipCity; }
            set
            {
                shipCity = value;
                OnPropertyChanged("ShipCity");
            }
        }

        public OrderInfo(string orderId, string customerName, string country, string customerId, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
        }

        public OrderInfo()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
