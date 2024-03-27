namespace Week8CalculatorExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //lblResult.Text = "FIRST LOAD VALUE. HELLO WORLD";
        }

        private void OnCalculateClicked(object sender, EventArgs e)
        {
            double number1, number2;
            if (double.TryParse(txtNumber1.Text, out number1) && double.TryParse(txtNumber2.Text, out number2))
            {
                string operation = pickerOperation.SelectedItem.ToString();
                double result = 0;

                switch (operation)
                {
                    case "Addition":
                        result = number1 + number2;
                        break;
                    case "Subtraction":
                        result = number1 - number2;
                        break;
                    case "Multiplication":
                        result = number1 * number2;
                        break;
                    case "Division":
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                            lblResult.Text = "Cannot divide by zero";
                        break;
                }

                lblResult.Text = $"Result: {result}";
            }
            else
            {
                lblResult.Text = "Invalid input. Please enter valid numbers.";
            }
        }
    }

}
