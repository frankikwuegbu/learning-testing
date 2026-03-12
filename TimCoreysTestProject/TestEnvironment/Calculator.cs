namespace TimCoreysTestProject.TestEnvironment;

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        if (a < b)
        {
            //custom for testing purposes
            throw new Exception();
        }

        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            //custom for testing purposes
            return 0;
        }

        return a / b;
    }
}