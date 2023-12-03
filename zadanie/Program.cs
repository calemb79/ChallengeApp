using System.ComponentModel.Design;

var name = "Ewa";
var sex = "M";
var age = 30;

if (sex == "K")
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
else if (sex !="K")
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




