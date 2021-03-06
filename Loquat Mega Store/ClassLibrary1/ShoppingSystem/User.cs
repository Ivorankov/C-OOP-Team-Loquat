﻿namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;

    using LoquatMegaStore.Interfaces;
    using LoquatMegaStore.ShoppingSystem.Enumerators;

    public abstract class User : IPayable, IOrder, ISerializable
    {
        public const double DefaultShippingFee = 4.5;

        private string userId;
        private string password;
        private string email;
        private Cart cart;

        public User(SerializationInfo info, StreamingContext ctxt)
        {
            this.UserId = (string)info.GetValue("UserId", typeof(string));
            this.Password = (string)info.GetValue("Password", typeof(string));
            this.Email = (string)info.GetValue("Email", typeof(int));
            this.Cart = (Cart)info.GetValue("Cart", typeof(Cart));
        }

        protected User(string userId, string password, string email)
        {
            this.UserId = userId;
            this.Password = password;
            this.Email = email;
        }

        public string UserId
        {
            get { return this.userId; }
            private set
            {
                if (ValidUserId(value))
                {
                    this.userId = value;
                }
                else
                {
                    throw new ArgumentException("Invalid userID.");
                }
            }
        }

        internal string Password
        {
            get { return this.password; }
            set
            {
                if (ValidPassword(value))
                {
                    this.password = value;
                }
                else
                {
                    throw new ArgumentException("Invalid password.");
                }
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            protected set
            {
                if (ValidEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid e-mail address.");
                }
            }
        }

        public Cart Cart
        {
            get { return this.cart; }
            private set { this.cart = value; }
        }

        private bool ValidUserId(string inputId)
        {
            string userIdPattern = @"^[a-z0-9_]{3,16}$"; // 3 to 16 chars - letters, numbers or underscore

            var regex = new Regex(userIdPattern);

            return regex.IsMatch(inputId);
        }

        private bool ValidEmail(string inputEmail)
        {
            string emailPattern = @"^(([^<>()[\]\\.,;:\s@\""]+"
                                  + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                  + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                                  + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                  + @"[a-zA-Z]{2,}))$";

            var regex = new Regex(emailPattern);

            return regex.IsMatch(inputEmail);
        }

        private bool ValidPassword(string inputPassword)
        {
            string passwordPattern = @"((?=.*\d)" // must contain one digit from 0-9
                + @"(?=.*[a-z])" // must contain one lowercase character
                + @"(?=.*[A-Z])" // must contain one uppercase character
                //+ @"(?=.*[@#$%])" // must contain one special symbol in the list "@#$%"
                + "." // match anything with previous condition checking
                + "{6,20})"; // length at least 6 characters and maximum of 20	

            var regex = new Regex(passwordPattern);

            return regex.IsMatch(inputPassword);
        }

        public void MakePayment()
        {
            throw new NotImplementedException();
        }

        public void MakeOrder(string contactName, string address)
        {
            var ran = new Random();
            var newOrder = new Order(PaymentType.CreditCard, ran.Next(009987, 13498787), OrderStatus.New, DefaultShippingFee, this.Cart.Items.Count, this.Cart.CartPrice, contactName, address);
            this.Cart.CheckOut();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("UserId", this.UserId);
            info.AddValue("Password", this.Password);
            info.AddValue("Email", this.Email);
            info.AddValue("Cart", this.Cart);
        }

        private bool StringNotEmpty(string input)
        {
            return !(string.IsNullOrEmpty(input));
        }
    }
}
