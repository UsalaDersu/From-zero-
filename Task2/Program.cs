//Даны два числа. Найти среднее арифметическое их квадратов и среднее арифметическое их модулей. 
double a = -4;
double b = -5;
double Square1 = a * a;
double Square2 = b * b;
double AverageSquare = (Square1 + Square2) / 2;
double absoluteValue1 = Math.Abs(a);
double absoluteValue2 = Math.Abs(b);
double AverageAbsoluteValue = (absoluteValue1 + absoluteValue2) / 2;

System.Console.WriteLine($"Среднее арифметическое квадратов чисел: {AverageSquare}, Среднее арифметическое квадратов чисел: {AverageAbsoluteValue}");

