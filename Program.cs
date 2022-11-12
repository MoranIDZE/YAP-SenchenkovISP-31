Console.Write("Введите массив: ");
double[] str = Console.ReadLine().Split().Select(double.Parse).ToArray();
Console.Write("Введите X: ");
double x = double.Parse(Console.ReadLine());

double num;
for(int i = 0; i + 1 < str.Length; i++) //сортировка Пузырьком
    for(int j = 0; j + 1 < str.Length; j++)
        if(str[j+1] < str[j])
        {
            num = str[j];
            str[j] = str[j+1];
            str[j+1] = num;
        }

Console.Write("Положительные числа: ");
foreach(double d in str)
    if(d > 0)
        Console.Write(d + " ");

Console.Write("\nОтрицательные числа: ");
foreach (double d in str)
    if ((int)d > x && d < 0)
        Console.Write(d + " ");
