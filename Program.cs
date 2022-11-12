Console.Write("Введите массив: ");
double[] str = Console.ReadLine().Split().Select(double.Parse).ToArray();
Console.Write("Введите X: ");
double x = double.Parse(Console.ReadLine());

int n = 0;
foreach (double d in str)
    if ((int)d % 2 == 0)
        n++;

double[] massCHET = new double [n];
n = 0;
for(int i = 0; i < str.Length; i++)
    if((int)str[i] % 2 == 0)
        massCHET[n++] = str[i];

double num;
for(int i = 0; i + 1 < massCHET.Length; i++) //сортировка Пузырьком
    for(int j = 0; j + 1 < massCHET.Length; j++)
        if(massCHET[j+1] < massCHET[j])
        {
            num = massCHET[j];
            massCHET[j] = massCHET[j+1];
            massCHET[j+1] = num;
        }

Console.Write("Чётные числа: ");
foreach (double d in massCHET)
    Console.Write(d + " ");

Console.Write("\nНе чётные числа: ");
foreach (double d in str)
{
    if((int)d % 2 != 0 && d > x)
        Console.Write(d + " ");
}

// Числа для примера
// -4,3 -5,444 10,01 5,0 1,45 -24,2 -1,2 6,1
