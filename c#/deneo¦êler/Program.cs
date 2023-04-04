// See https://aka.ms/new-console-template for more information



using denemeeee;


Customer customer1 = new Customer();


customer1.Email = "sadık@gmail.com";
customer1.FirstName = "sadık";
customer1.LastName = "sünbül";
customer1.UserName = "sadık.sunbul";




Customer customer2 = new Customer();


customer2.Email = "sadık@gmail.com";
customer2.FirstName = "sadık";
customer2.LastName = "sünbül";
customer2.UserName = "sadık.sunbul";
Customer customer3 = new Customer();



customer3.FirstName = "sadık";
customer3.LastName = "sünbül";
customer3.UserName = "sadık.sunbul";

Console.WriteLine("----------------");
Customer.KullanıcıEkle(customer1);
Console.WriteLine("_____________");
Customer.KullanıcıEkle(customer2);
Console.WriteLine("-----------");
Customer.KullanıcıEkle(customer3);

Console.ReadLine();


Console.ReadLine();
