using System.Windows;

namespace EasyApplicationForTesting;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly Calculator _calculator;

    public MainWindow()
    {
        InitializeComponent();
        _calculator = new Calculator();
    }

    //Validation is ignored for testing purposes. QA should find bugs here during his learning process..
    private void addButton_Click(object sender, RoutedEventArgs e)
    {
        var (firstNumber, secondNumber) = ParseNumbers(numberOneTextBox.Text, numberTwoTextBox.Text);
        resultTextBox.Text = _calculator.Add(firstNumber, secondNumber).ToString();
    }

    private void subButton_Click(object sender, RoutedEventArgs e)
    {
        var (firstNumber, secondNumber) = ParseNumbers(numberOneTextBox.Text, numberTwoTextBox.Text);
        resultTextBox.Text = _calculator.Sub(firstNumber, secondNumber).ToString();
    }

    private void mulButton_Click(object sender, RoutedEventArgs e)
    {
        var (firstNumber, secondNumber) = ParseNumbers(numberOneTextBox.Text, numberTwoTextBox.Text);
        resultTextBox.Text = _calculator.Mul(firstNumber, secondNumber).ToString();
    }

    private void divButton_Click(object sender, RoutedEventArgs e)
    {
        var (firstNumber, secondNumber) = ParseNumbers(numberOneTextBox.Text, numberTwoTextBox.Text);
        resultTextBox.Text = _calculator.Div(firstNumber, secondNumber).ToString();
    }

    private (double firstNumber, double secondNumber) ParseNumbers(string numberOneText, string numberTwoText)
    {
        //Those line can fail if tester input string that is not numeric or empty. This is done on purpose for testing course purposes.
        var firstNumber = double.Parse(numberOneTextBox.Text);
        var secondNumber = double.Parse(numberTwoTextBox.Text);
        return (firstNumber, secondNumber);
    }
}