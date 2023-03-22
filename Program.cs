using csharp_calcolatrice;


// TEST CASE 

int a = 5;
int b = 3;
double c = 2.5;
double d = 1.2;

Console.WriteLine($"i numeri utilizzati sono: {a}; {b}; {c}; {d} ");
Console.WriteLine("");

Console.WriteLine("Somma INTERI: " + CalcoliHelper.Somma(a, b));
Console.WriteLine("Somma  DOUBLE: " + CalcoliHelper.Somma(c, d));
Console.WriteLine("");

Console.WriteLine("Differenza INTERI: " + CalcoliHelper.Differenza(a, b));
Console.WriteLine("Differenza DOUBLE: " + CalcoliHelper.Differenza(c, d));
Console.WriteLine("");

Console.WriteLine("Moltiplicazione INTERI: " + CalcoliHelper.Moltiplicazione(a, b));
Console.WriteLine("Moltiplicazione DOUBLE: " + CalcoliHelper.Moltiplicazione(c, d));
Console.WriteLine("");

Console.WriteLine("Valore assoluto INTERO: " + CalcoliHelper.ValoreAssoluto(-a));
Console.WriteLine("Valore assoluto DOUBLE: " + CalcoliHelper.ValoreAssoluto(-c));
Console.WriteLine("");

Console.WriteLine("Minimo INTERI: " + CalcoliHelper.Minimo(a, b));
Console.WriteLine("Minimo DOUBLE: " + CalcoliHelper.Minimo(c, d));
Console.WriteLine("");

Console.WriteLine("Massimo INTERI: " + CalcoliHelper.Massimo(a, b));
Console.WriteLine("Massimo DOUBLE: " + CalcoliHelper.Massimo(c, d));
Console.WriteLine("");
