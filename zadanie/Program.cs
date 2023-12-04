/*using System.ComponentModel.Design;

var name = "Ewa";
bool sex = true;
var age = 30;

if (sex == true)
{
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    { 
        Console.WriteLine("Kobieta poniżej 30 Lat"); 
    }
    else
    {
        Console.WriteLine("inna kobieta");
    }


}
else if (sex !=true)
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyna");
    }
    else if (age > 18)
    {
        Console.WriteLine("Pełnoletni mężczyna");
    }
    
        
}
*/


int number = 1712154;
string change = number.ToString();
char[] change2 = change.ToArray();


List<char> numbers = new List<char>();
numbers.Add('0');
numbers.Add('1');
numbers.Add('2');
numbers.Add('3');
numbers.Add('4');
numbers.Add('5');
numbers.Add('6');
numbers.Add('7');
numbers.Add('8');
numbers.Add('9');

Console.Write("Wynik dla liczby " + number + "\n");

foreach (var search in numbers)
{
    int zmienna = 0;

    foreach (char c in change2)
    {
        if (c == search)
        {
            zmienna++;
        }
    }

    //Console.WriteLine("Liczba {0} występuje {1} razy.", search, licz);

    string x = "raz";

    if (zmienna != 1)
    {

        Console.WriteLine(search + " występuje => " + zmienna + " " + x + "y");
    }
    else
    {
        Console.WriteLine(search + " występuje => " + zmienna + " " + x);
    }
}


//int number = 1712154;
//string change = number.ToString();
//char[] change2 = change.ToArray();


//List<char> numbers = new List<char>();
//numbers.Add('0');
//numbers.Add('1');
//numbers.Add('2');
//numbers.Add('3');
//numbers.Add('4');
//numbers.Add('5');
//numbers.Add('6');
//numbers.Add('7');
//numbers.Add('8');
//numbers.Add('9');

//Console.Write("Wynik dla liczby " + number + "\n");

//string[] teksty = { "zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };

//foreach (var search in numbers)
//{
//    int zmienna = 0;
//    foreach (char c in change2)
//    {
//        if (c == search)
//        {
//            zmienna++;
//        }
//    }

//    //string x = "raz";
//    string text = zmienna.ToString();
//    if (zmienna != 1)
//    {
//        Console.WriteLine(teksty[int.Parse(search.ToString())] + " występuje => " + text );
//    }
//    else
//    {
//        Console.WriteLine(teksty[int.Parse(search.ToString())] + " występuje => " + text );
//    }
//}