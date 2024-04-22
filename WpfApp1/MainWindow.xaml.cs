using System.Data;
using System;
using System.Windows;

namespace WpfApp1;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void percent_Click(object sender, RoutedEventArgs e)
    {

    }

    private void CE_Click(object sender, RoutedEventArgs e)
    {
        result.Text = "";
    }

    private void btn7_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "7";
    }

    private void btn4_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "4";
    }

    private void btn1_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "1";
    }

    private void PlusMinus_Click(object sender, RoutedEventArgs e)
    {

    }

    private void sqrt_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Clear_Click(object sender, RoutedEventArgs e)
    {
        result.Text = "";
    }

    private void btn8_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "8";
    }

    private void btn5_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "5";
    }

    private void btn2_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "2";
    }

    private void btn0_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "0";
    }

    private void square_Click(object sender, RoutedEventArgs e)
    {

    }

    private void backspace_Click(object sender, RoutedEventArgs e)
    {
        result.Text = (result.Text.Length > 0 ? result.Text.Substring(0, result.Text.Length - 1) : result.Text);
    }

    private void btn9_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "9";
    }

    private void btn6_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "6";
    }

    private void btn3_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "3";
    }

    private void subtract_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "-";
    }

    private void devide_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "/";
    }

    private void plus_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "+";
    }

    private void Mult_Click(object sender, RoutedEventArgs e)
    {
        result.Text += "*";
    }

    private void DevideX_Click(object sender, RoutedEventArgs e)
    {

    }

    private void equal_Click(object? sender, RoutedEventArgs e)
    {
        try
        {
            DataTable dt = new DataTable();
            var Result = dt.Compute(result.Text, "");
            result.Text = Result.ToString();
        }
        catch 
        {
            result.Text = "";
        }
    }

    private void btnDot_Click(object sender, RoutedEventArgs e)
    {
        result.Text += ".";
    }
}
