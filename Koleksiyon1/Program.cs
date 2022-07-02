List<int> nonPrimeNumbers = new List<int>(); // this list will contain which number is not a prime number 
List<int> primeNumbers = new List<int>();    // this list will contain prime numbers    

byte count = 0;
string input;
int number;
bool isNumber;

do   
{
    Console.Write("Enter number:");
    input = Console.ReadLine();
    isNumber = int.TryParse(input, out number); // we are checkıng input type
    if (isNumber)                               // input, number or not ?
    {
        if (number > 1)
        {
            count++;  // count works while number is bigger than 1 only
            if (IsPrime(number))
                primeNumbers.Add(number);
            else
                nonPrimeNumbers.Add(number);
        }
        else Console.WriteLine("Lowest prime number is 2");
    }
    else Console.WriteLine("Invalid number");
} while (!isNumber || count != 5);  // loop contuines till count=5, if input is numeric
Console.WriteLine("-------------");

Console.WriteLine("Prime Numbers");
ShowListInfo(primeNumbers);
Console.WriteLine("-------------");

Console.WriteLine("Non Prime Numbers");
ShowListInfo(nonPrimeNumbers);
Console.WriteLine("-------------");

Console.ReadKey();

static bool IsPrime(int number)
{   
    if (number>=2)
    {
        bool control = true;
        for (int i = 2; i <= number-1; i++)
        {
            if (number % i == 0) // if number divides i, it means number is non prime number
            {
                control = false;
                break;           // we put break, so no need to contuine loop  
            }
        }
        if (control)
            return true;
        else
            return false;
    }
    else
        return false;
} 
//A prime number is a whole number greater than 1 whose only factors are 1 and itself
//So we made method, if number is prime method returns true 

static void ShowListInfo(List<int> list)
{
    list.Sort();  // sorts elements on the list.
    foreach (var item in list)  // this loop for show elements of list
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("Count:" + list.Count);
    Console.WriteLine("Sum: " + list.Sum());
    Console.WriteLine("Average:" + list.Average());
} // our method takes a list as a parameter
// We made method for show informations of our lists. 
// So no need to write same codes for different lists.