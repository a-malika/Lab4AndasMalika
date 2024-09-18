using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1 задание
//Single-Responsibility Principle
namespace Laboratory4
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Item() { }
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
    public class Invoice
    {
        public int Id { get; set; }
        public List<Item> Items { get; set; }
        public double TaxRate { get; set; }
        public Invoice() { }
        public Invoice(int id, List<Item> items, double taxRate)
        {
            Id = id;
            Items = items;
            TaxRate = taxRate;
        }
    }
    public class InvoiceCalculator
    {
        public double CalculateTotal(Invoice invoice)
        {
            double subTotal = 0;
            foreach (Item item in invoice.Items)
            {
                subTotal += item.Price;
            }
            return subTotal + (subTotal * invoice.TaxRate);
        }
    }
    public class InvoiceRepository
    {
        public void SaveToDatabase(Invoice invoice)
        {
            // Логика для сохранения счета-фактуры в базу данных
        }
    }

}
