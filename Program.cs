// See https://aka.ms/new-console-template for more information
//   1=I
//   5=V
//   10=x
//   50=L
//  100=C
//  500=D
// 1000=M

using System.Text;

Dictionary<char, int> romanNumeralsDictionary = new()
    {
    { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 },{ 'C', 100 },  { 'D', 500}, { 'M', 1000 }, 
    };

Dictionary<int, string> romanNumeralsDictionaryReverse = new()
{
    { 1,"I" }, { 4, "IV"}, { 5, "V"}, { 9, "IX"}, { 10, "X"}, { 40,"XL"}, { 50, "L"},
    { 90, "XC" }, { 100, "C"}, { 400, "CD"}, { 500, "D"}, { 900, "CM"}, { 1000, "M"},
    };

Console.WriteLine("Type in a number between 1-3999 to get the Roman Numberal Equivalent!");
    if (int.TryParse(Console.ReadLine(), out int Number))
    {
        if (Number <= 0) { Console.WriteLine("Must be bigger than Zero"); return; }
        if (Number > 3999) { Console.WriteLine("Smaller number please"); return; }

    }
    else Console.WriteLine("Was not a number");

string (int number)
{
    var numeral = new StringBuilder();

    foreach (var item in romanNumeralsDictionary)
    {
        while (numeral >= item.Key)
        {
            numeral.Append(item.Value);
            numeral -= item.Key;
        }
    }

    return numeral.ToString();
}


int From(string numeral)
{
    int total = 0;

    int current, previous = 0;
    char currentRoman, previousRoman = '\0';

    for (int i = 0; i < numeral.Length; i++)
    {
        currentRoman = numeral[i];

        previous = previousRoman != '\0' ? romanNumeralsDictionary[previousRoman] : '\0';
        current = romanNumeralsDictionary[currentRoman];

        if (previous != 0 && current > previous)
        {
            total = total - (2 * previous) + current;
        }
        else
        {
            total += current;
        }

        previousRoman = currentRoman;
    }

    return total;
}
