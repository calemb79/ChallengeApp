using System;
using System.ComponentModel.Design;

int number = 200351;
string numberString = number.ToString();
char[] numberChar = numberString.ToCharArray();
int[] figure = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


for (int i = 0; i < numberChar.Length; i++)

{

    if (numberChar[i] == '0')
    {
        figure[0]++;
    }
    else if (numberChar[i] == '1')
    {
        figure[1]++;
    }
    else if (numberChar[i] == '2')
    {
        figure[2]++;
    }
    else if (numberChar[i] == '3')
    {
        figure[3]++;
    }
    else if (numberChar[i] == '4')
    {
        figure[4]++;
    }
    else if (numberChar[i] == '5')
    {
        figure[5]++;
    }
    else if (numberChar[i] == '6')
    {
        figure[6]++;
    }
    else if (numberChar[i] == '7')
    {
        figure[7]++;
    }
    else if (numberChar[i] == '8')
    {
        figure[8]++;
    }
    else if (numberChar[i] == '9')
    {
        figure[9]++;
    }
}
Console.WriteLine("W liczbie " + number);
Console.WriteLine("cyfra 0 występuję" + figure[0]);
Console.WriteLine("cyfra 1 występuję" + figure[1]);
Console.WriteLine("cyfra 2 występuję" + figure[2]);
Console.WriteLine("cyfra 3 występuję" + figure[3]);
Console.WriteLine("cyfra 4 występuję" + figure[4]);
Console.WriteLine("cyfra 5 występuję" + figure[5]);
Console.WriteLine("cyfra 6 występuję" + figure[6]);
Console.WriteLine("cyfra 7 występuję" + figure[7]);
Console.WriteLine("cyfra 8 występuję" + figure[8]);
Console.WriteLine("cyfra 9 występuję" + figure[9]);

