var name = "Ewa";
var sex = "Kobieta";
var sexm = "Mężczyzna";
var age = 30;
//var age2 = 30;
//var age3 = 33;

if (sex == "Kobieta" && age - 1 < 30)
    Console.WriteLine("Kobieta poniżej 30 lat");
if (name == "Ewa" && age + 3 == 33)
    Console.WriteLine("Ewa, lat 33");
if (age - 13 < 18 && sexm != "Kobieta")
    Console.WriteLine("Niepełnoletni Mężczyzna");
if (age - 13 > 18 && sexm == "Mężczyzna")
    Console.WriteLine("Pełnoletni Mężczyzna");
else Console.WriteLine("*KONIEC*");