namespace Week8WalkTHR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string fname = fnameEntry.Text;
            string lname = lnameEntry.Text;
            string message = "Hello user: " + fname + " " + lname;
            DisplayAlert("Button Clicked Pop Up", message ,"Close");
        }
    }

}
