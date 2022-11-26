// See https://aka.ms/new-console-template for more information
Console.WriteLine("Какая гиря весит больше всех");
int a = 6;
int b = 3;
int c = 5;
int d = 8;
int e = 1;
int max = a;
    if (a > max) max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    if (d > max) max = d;
    if (e > max) max = e;
    Console.Write("max = ");
    Console.WriteLine(max);