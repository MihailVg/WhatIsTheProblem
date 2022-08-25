// разложение числа на простые множители

void SimpleSNumbers(int n)
{
    int m = 2;
    while(n != 1)
    {
        if(n%m == 0)
        {
            Console.Write(m + " ");
            SimpleSNumbers(n/m);
        }
        m++;
    }
}


for(int x = 10; x < 100; x++)
{
    int number = x;
    Console.Write(x + " = ");
    SimpleSNumbers(number);
    Console.WriteLine();
}
