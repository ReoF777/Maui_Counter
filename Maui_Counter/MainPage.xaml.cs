using Maui_Counter.ViewModel;

namespace Maui_Counter
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}