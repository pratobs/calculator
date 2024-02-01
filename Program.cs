Console.WriteLine("hello!");
Console.WriteLine("Input the First Number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Input the Second number");
int second = int.Parse(Console.ReadLine());

Console.WriteLine("what do you want to do with these numbers?");
Console.WriteLine("[A]DD");
Console.WriteLine("[S]UB");
Console.WriteLine("[M]ULTIPLY");

string userInput = Console.ReadLine();

if (userInput == "A" || userInput == "a")
{
    Console.WriteLine(first + second);
}
else if (userInput == "S" || userInput == "s")
{
    Console.WriteLine(first - second);
}
else if (userInput == "M" || userInput == "m")
{
    Console.WriteLine(first * second);
}
else
{
    Console.WriteLine("Invalid input");
}
Console.ReadLine();