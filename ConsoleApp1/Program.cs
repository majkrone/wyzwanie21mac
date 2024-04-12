// liczby calkowite

int myAge2 = 120;
int newAge2 = myAge2 + 5;
Console.WriteLine(newAge2);
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
ulong myVar3 = ulong.MaxValue;

// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;

//zmienne tekstowe
string name = "Maciek";
string surname = "Goralczyk";
string result = name + surname + myAge2;
Console.WriteLine(result);
char myVar5 = 'c';
var result2 = name.ToArray();

//zmienna logiczna
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);