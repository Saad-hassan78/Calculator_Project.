using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Name: Muhammad Saad Hassan, Roll No: 24-ST-058");
    // Declare two numbers for the operation
        int a = 10, b = 5;

        // Division operation (step 6 - division branch)
        if (b != 0)
        {
            float quotient = (float)a / b;
            Console.WriteLine("Quotient: " + quotient);
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
    }
}
