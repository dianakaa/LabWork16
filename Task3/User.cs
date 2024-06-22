namespace Task3
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
                if (_login != value)
                {
                    _login = value;
                    OnChanged(new InfoEventArgs { PropertyName = "логин", ChangeDate = DateTime.Now });
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnChanged(new InfoEventArgs { PropertyName = "пароль", ChangeDate = DateTime.Now });
                }
            }
        }

        public event EventHandler<InfoEventArgs> Changed;

        private void OnChanged(InfoEventArgs e)
        {
            if (e.PropertyName == "логин")
            {
                if (string.IsNullOrWhiteSpace(_login) || string.IsNullOrEmpty(_login))
                {
                    e.ErrorText = "Ошибка: логин пустая строка";
                }
            }
            else if (e.PropertyName == "пароль")
            {
                if (_password.Length < 6 || _password.Length > 20)
                {
                    e.ErrorText = "Ошибка: пароль меньше 6 или больше 20 символов";
                }
            }
            Changed?.Invoke(this, e);
        }
    }
}