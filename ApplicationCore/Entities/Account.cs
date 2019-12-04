using ApplicationCore.Interfaces;
namespace ApplicationCore.Entities
{
    public class Account : IAggregateRoot
    {
        public Account() { }

        public Account(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public Account(Account acc)
        {
            this.Username = acc.Username;
            this.Password = acc.Password;
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}