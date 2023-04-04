// See https://aka.ms/new-console-template for more information



using bolumsonu_odev;

Customer customer1=new Customer();


customer1.Email = "sadık@gmail.com";
customer1.FirstName = "sadık";
customer1.LastName = "sünbül";
customer1.UserName = "sadık.sunbul";

Customer.KullanıcıEkle(customer1);


Customer customer2 = new Customer();


customer2.Email = "sadık@gmail.com";
customer2.FirstName = "sadık";
customer2.LastName = "sünbül";
customer2.UserName = "sadık.sunbul";

Customer.KullanıcıEkle(customer2);



Console.ReadLine();