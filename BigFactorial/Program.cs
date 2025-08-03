using System.Numerics;

int inputNum = int.Parse(Console.ReadLine());

BigInteger bigFactorial = 1;

for (int i = inputNum; i > 1; i--)
{
    bigFactorial *= i;
}

Console.WriteLine(bigFactorial);