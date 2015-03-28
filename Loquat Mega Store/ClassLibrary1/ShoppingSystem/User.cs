namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;
    using LoquatMegaStore.Interfaces;
    using System.Text.RegularExpressions;

    public abstract class User : IPayable, IOrderable
    {
        private string userId;
        private string password;
        private string email;

        protected User(string userId, string password, string email)
        {
            this.UserId = userId;
            this.Password = password;
            this.Email = email;
        }
        //TODO Validation of the properties
        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Password
        {
            internal get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (ValidString(value))
                {
                    if (ValidEmail(value))
                    {
                        email = value;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid e-mail address.");
                    }
                }
            }
        }

        private bool ValidEmail(string email)
        {
            string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"
                                  + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                  + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                  + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                  + @"[a-zA-Z]{2,}))$";
            Regex regexStrict = new Regex(patternStrict);
            bool emailValid = regexStrict.IsMatch(email); ;
            return emailValid;
        }

        private bool ValidString(string input)
        {
            bool stringValid = !(string.IsNullOrEmpty(input));
            return stringValid;
        }

        public void MakePayment()
        {
            throw new NotImplementedException();
        }

        public void MakeOrder()
        {
            throw new NotImplementedException();
        }
    }
}
