// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(number1 + number2);

int secretNumber = new Random().Next(1, 11);
int count = 3;
bool flagWin = false;
while(count > 0)
{
    Console.WriteLine("Type the number in the period 1 to 10");
int userNumber = Convert.ToInt32(Console.ReadLine());
count = count - 1; // it's possible to use 'count--'
if(userNumber > secretNumber)
{
    Console.WriteLine("Secret number is less");
    Console.WriteLine(count + " is left");
}
else if (userNumber < secretNumber)
{
    Console.WriteLine("Secret number is bigger");
    Console.WriteLine(count + " is left");
}
else
{
    Console.WriteLine("You win!");
    flagWin = true;
    break;
}
}
if(!flagWin)
{
    Console.WriteLine("You loose. Secret number was " + secretNumber);
}