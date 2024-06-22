using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task1
{
    internal class User : INotifyPropertyChanged
    {
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set
            {
                if (_login != value && !string.IsNullOrWhiteSpace(value))
                {
                    _login = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value && !string.IsNullOrWhiteSpace(value))
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
