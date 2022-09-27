namespace MVPLoginExample.Model.Entities
{
    public class UserLoginData
    {
        private readonly string _username;
        private readonly string _password;

        public string Username => _username;
        public string Password => _password;

        public UserLoginData(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}