namespace Empregados.Entities
{
    public class Address
    {
        private string email;
        private string phone;

        public Address()
        {
        }

        public Address(string email, string phone)
        {
            this.email = email;
            this.phone = phone;
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}