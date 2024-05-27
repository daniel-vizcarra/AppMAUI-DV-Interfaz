namespace AtticaDV
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {       
            InitializeComponent();
        }

        private void OnMenuButtonClicked(object sender, EventArgs e)
        {
            menuPopup.IsVisible = !menuPopup.IsVisible;
        }

    }

}
