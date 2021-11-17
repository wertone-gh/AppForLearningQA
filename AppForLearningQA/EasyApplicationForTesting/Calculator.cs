namespace EasyApplicationForTesting;

internal sealed class Calculator
{
    public double Add(double x, double y) => x + y;

    //Mistake on purpose
    public double Sub(double x, double y) => x + y;

    public double Mul(double x, double y) => x * y;

    //Note: Does not check divide by zero condition here.
    //This bug should be found by QA while training using this application
    public double Div(double x, double y) => x / y;
}