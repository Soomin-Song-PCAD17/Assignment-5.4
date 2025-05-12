char selection = '0';
while (selection != 'q')
{
    Console.WriteLine("1: Write a program in C# Sharp to display the individual digits of a given number using recursion.\n2: Write a C# Sharp program to find the sum of the right diagonals of a matrix.\nq: quit");
    Console.Write("Selection: ");
    selection = Console.ReadKey().KeyChar;
    Console.Clear();
    switch (selection)
    {
        case '1':
            Console.WriteLine("Write a program in C# Sharp to display the individual digits of a given number using recursion.\nTest Data :\nInput any number : 1234\nExpected Output :\nThe digits in the number 1234 are : 1 2 3 4");
            Demo1();
            break;
        case '2':
            Console.WriteLine("Write a C# Sharp program to find the sum of the right diagonals of a matrix.\nTest Data :\nInput the size of the square matrix : 2\nInput elements in the first matrix :\nelement - [0],[0] : 1\nelement - [0],[1] : 2\nelement - [1],[0] : 3\nelement - [1],[1] : 4\nExpected Output :\nThe matrix is :\n1 2\n3 4\nAddition of the right Diagonal elements is :5");
            Demo2();
            break;
    }
}

void Demo1()
{
    Console.Write("\nInput any number: ");
    if(int.TryParse(Console.ReadLine(), out int n))
    {
        Console.Write($"The digits in the number {n} are : ");
        RecursivePrintDigits(n);
    }
    Console.WriteLine();
    Console.ReadKey();
    Console.Clear();
}
void RecursivePrintDigits(int n)
{
    if (n > 9)
    {
    RecursivePrintDigits(n / 10);
    }
    Console.Write($"{n % 10} ");
}

void Demo2()
{
    Console.Write("Input the size of the square matrix: ");
    int matrixSize = int.Parse(Console.ReadLine());
    int[,]array = new int[matrixSize,matrixSize];
    Console.WriteLine("Input elements in the matrix : ");
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            Console.Write($"Element - [{i}],[{j}] : ");
            array[i, j] = int.Parse(Console.ReadLine());
        }
    }

    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine($"Addition of the right Diagonal elements is : {DiagonalMatrixSum(array)}");

    Console.ReadKey();
    Console.Clear();
}
int DiagonalMatrixSum(int[,] matrix)
{
    int sum = 0;
    for(int i=0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, matrix.GetLength(0)-1-i];
    }
    return sum;
}