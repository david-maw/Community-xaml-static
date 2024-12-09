using System.Diagnostics;

namespace Community;


public partial class MainPage : ContentPage
{
#if DEBUG
    public static readonly bool IsDebug = true; // Not a const so as to avoid "unreachable code" warnings
#else
    public static readonly bool IsDebug = false;
#endif
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        for (int i = 20; i > 0; i--)
            Debug.WriteLine("*************************************************");
    }
}
