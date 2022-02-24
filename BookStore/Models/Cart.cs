using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    class Cart
    {
        private string bookID;
        private string title;
        private int quantity;
        private decimal unit;

        public string BookID { get => bookID; set => bookID = value; }
        public string Title { get => title; set => title = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public decimal Unit { get => unit; set => unit = value; }

        public Cart()
        {
        }

        public Cart(string bookID, string title, int quantity, decimal unit)
        {
            this.bookID = bookID;
            Title = title;
            this.quantity = quantity;
            this.unit = unit;
        }
    }
}
