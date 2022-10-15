int n, x, thirdIndex, secondIndex;

Console.WriteLine("Введите n");
n = int.Parse(Console.ReadLine());

thirdIndex = n % 10;
secondIndex = n / 10;

x = thirdIndex * 100 + secondIndex;

Console.WriteLine(x);