int numberA = 1;
int numberB = 10;

// Console.Write("введите первое число ");
int firstNumber = new Random().Next(numberA, numberB);
Console.Write("Первое число: "); 
Console.WriteLine(firstNumber); 
// Console.Write("введите второе число ");
int secondNumber = new Random().Next(numberA, numberB);
Console.Write("Второе число: "); 
Console.WriteLine(secondNumber);
Console.Write("Сумма чисел: ");  
Console.WriteLine(firstNumber + secondNumber);
