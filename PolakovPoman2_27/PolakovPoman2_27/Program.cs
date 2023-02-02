int n, x, thirdIndex, secondIndex;
Console.WriteLine ("Задание 2.27 В трехзначном числе x зачеркнули первую цифру...");
Console.WriteLine("Введите число n которое получилось после того когда полученное число умножили на 10, а произведение сложили с первой цифрой числа x"); 
n = int.Parse(Console.ReadLine());

thirdIndex = n % 10;
secondIndex = n / 10;

x = thirdIndex * 100 + secondIndex;

Console.WriteLine(x); //Число x =
