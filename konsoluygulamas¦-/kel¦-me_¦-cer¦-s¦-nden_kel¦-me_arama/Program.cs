// See https://aka.ms/new-console-template for more information


string dizi;
Console.Write("bır dızı gırınız:");
dizi = Console.ReadLine();

string[] kelimeler = dizi.Split(' ');  
Console.Write("Aranacak kelıme:");
string aranacak = Console.ReadLine();

for (int i = 0; i < kelimeler.Length; i++)
{
    if (kelimeler[i] == aranacak)
    {
        Console.WriteLine("aradıgınız kelıme "+(i+1)+". sırada.");
    }
}


