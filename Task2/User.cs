using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Task2
{
    internal class User
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
                    OnChanged();
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
                    OnChanged();
                }
            }
        }

        public event EventHandler Changed;

        public void OnChanged()
        {
             Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}

