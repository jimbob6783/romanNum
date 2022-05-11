// See https://aka.ms/new-console-template for more information
//   1=I
//   5=V
//   10=x
//   50=L
//  100=C
//  500=D
// 1000=M

Dictionary<string, int> romanNumeralsDictionary = new()
{   
    { "I", 1 }, { "II", 2 }, { "III", 3 }, {"IV", 4 }, { "V", 5 }, { "VI", 6 }, { "VII", 7 }, { "VIII", 8 }, { "IX", 9 },
    { "X", 10 }, { "XX", 20 }, {"XXX", 30}, {"XL", 40}, { "L", 50 }, { "LX", 60 }, { "LXX", 70 }, { "LXXX", 80 }, { "XC", 90 },
    { "C", 100 }, { "CC", 200}, { "CCC", 300}, { "CD", 400}, { "D", 500}, { "DC", 600}, { "DCC", 700}, { "DCCC", 800}, { "CM", 900},
    { "M", 1000 }, { "MM", 2000}, { "MMM", 3000}
};

Console.WriteLine("Type in a number between 1-3999 to get the Roman Numberal Equivalent");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number == 0) Console.WriteLine("Must be bigger than Zero");
if (Number > 3999) Console.WriteLine("Smaller number please");

//if (Number == int) Console.WriteLine(romanNumeralsDictionary);
    

