﻿int[] numbers = new int[10];
Random rnd = new Random();  

int sum = 0;

//populating the array
for (int i = 0; i < numbers.Length; i++)
{
        numbers[i] = rnd.Next(1, numbers.Length + 1);
    sum = sum + numbers[i];
}

foreach (int i in numbers)
{
    Console.WriteLine(numbers);
}

Console.WriteLine($"Total: {sum}");