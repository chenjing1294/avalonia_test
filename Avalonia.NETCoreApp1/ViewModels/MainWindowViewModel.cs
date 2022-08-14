using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace Avalonia.NETCoreApp1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _greeting = "Welcome to Avalonia!";

        public string Greeting
        {
            get => _greeting;
            set => SetField(ref _greeting, value, nameof(Greeting));
        }


        private double _floatValue = 12.21;

        public double FloatValue
        {
            get => _floatValue;
            set => SetField(ref _floatValue, value, nameof(FloatValue));
        }

        public Task<string> MyAsyncText
        {
            get { return GetTextAsync(); }
        }

        private async Task<string> GetTextAsync()
        {
            await Task.Delay(6000);
            var source = new Subject<string>();
            return "Hello from async operation";
        }
    }
}