using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Adi = "Mehmet Ali";
            customer1.Soyadi = "ASİL";
            customer1.TcNo = "1000000";

            Customer customer2 = new Customer();
            customer2.Adi = "Osman";
            customer2.Soyadi = "ÇALIŞKAN";
            customer2.TcNo = "1111111";

            CustomerManager customer = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2 };

            customer.Ekle(customers);

            customer.Sil(customer1);

            customer.Listele(customers);








            Console.ReadKey();
        }
    }
}
