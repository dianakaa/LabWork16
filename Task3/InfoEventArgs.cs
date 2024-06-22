namespace Task3
{
    public class InfoEventArgs : EventArgs
    {
        public string PropertyName { get; set; }
        public string ErrorText { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}