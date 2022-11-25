Console.WriteLine("Enter your First Number ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine(  "Enter your second Number " );
int secondNumber = int.Parse(Console.ReadLine());

int y = firstNumber;
firstNumber = secondNumber;
secondNumber = y;

Console.WriteLine($"first number ={firstNumber} \n secondNumber = { secondNumber }");