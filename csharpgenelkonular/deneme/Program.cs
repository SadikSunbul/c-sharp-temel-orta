// See https://aka.ms/new-console-template for more information


using deneme;

Customer c1 = new()
{
    CustomerId = 1,
    Email = "sadık@gmail.com",
    KullanıcıAdı = "sadık.sunbul",
    LastName = "sünbül",
    Name = "sadık"
};

Customer.KullanıcıEkle(c1);
Console.WriteLine("----------");
Customer c2 = new()
{
    CustomerId = 1,
    Email = "sadık@gmail.com",
    KullanıcıAdı = "sadı.sunbul",
    LastName = "sünbül",
    Name = "sadık"
};
Customer.KullanıcıEkle(c2);
Console.WriteLine("-----------");
Customer c3 = new()
{
    CustomerId = 1,
    Email = "sadk@gmail.com",
    KullanıcıAdı = "sadık.sunul",
    LastName = "sünbül",
    Name = "sadık"
};
Customer.KullanıcıEkle(c3);
Console.WriteLine("----------");
Console.ReadLine();

