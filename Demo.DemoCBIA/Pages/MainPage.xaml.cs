namespace Demo.DemoCBIA.Pages
{
    public partial class MainPage : ContentPage
    {
        bool webViewVisibility = false;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAboutUsClicked(object sender, EventArgs e)
        {
            webViewVisibility = !webViewVisibility;
            // Define the URL of the about us page
            //string aboutUsUrl = "https://www.google.com";


            // Show the WebView and navigate to the URL
            webView.IsVisible = webViewVisibility;

        }
    }
}