using Overloading;

Sum_of_decimal_integers sum = new Sum_of_decimal_integers();

// Here the use of overloads will be made

int _result1 = sum.Sum(35,65); // Sum of 2 integer quantities

int _result2 = sum.Sum(100,200,300); // Sum of 3 integer quantities

double _result3 = sum.Sum(25.5, 35.5); // Sum of 2 decimal places

double _result4 = sum.Sum(8.6,1.6,5.7,8.6); // Sum of 4 decimal places

// Results
Console.WriteLine("Result 1 is :" +_result1);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Result 2 is :" + _result2);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Result 3 is :" + _result3);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Result 4 is :" + _result4);
Console.ReadLine();