using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşteri Eklendi : " + customer.Adi + " " + customer.Soyadi);
            }
            Console.WriteLine("-----------------");
        }

        public void Listele(Customer[] customers)
        {
            Console.WriteLine("\nMüşteriler Listesi :\n");
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Adı : " + customer.Adi + "\nSoyadı : " + customer.Soyadi + "\nTC No : " + customer.TcNo);
                Console.WriteLine("-------------------");

            }

        }

        public void Sil(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.TcNo);
            Console.WriteLine("-----------------");

        }
    }
}
