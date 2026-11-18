int num = int.Parse(Console.ReadLine());

int a = num / 1000;
int b = (num - a * 1000) / 100;
int c = (num - a * 1000 - b * 100) / 10;
int d = num - a * 1000 - b * 100 - c * 10;

int reverse = d * 1000 + c * 100 + b * 10 + a;

Console.WriteLine(reverse);