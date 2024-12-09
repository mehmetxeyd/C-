using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_System_Main
{
    public class Product
    {
        public string itemName { get; set; }
        public string itemType { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string State { get; set; }

        public Product(string name, int quantity)
        {
            itemName = name;
            Quantity = quantity;
            UpdateState();
        }

        public void DifferenceinQuantity(int amount)
        {
            Quantity += amount;
            UpdateState();
        }

        public void UpdateState()
        {
            if (Quantity <= 0)
                State = "OutofStock";
            else if (Quantity <= 1)
                State = "New Shipment Required";
            else
                State = "Stocked";
        }
    }

    public enum itemManagement
    {
        inStock,
        outofStock,
        ordered,
    }
}
