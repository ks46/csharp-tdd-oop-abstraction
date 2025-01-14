using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_abstraction.CSharp.Main
{
    public class AdminApp
    {
        private Dictionary<string, Account> _accounts = new Dictionary<string, Account>();

        public string CreateAccount(string email, string password)
        {
            if (!email.Contains('@'))
                return "invalid email";
            if (password.Length < 8)
                return "invalid password";
            _accounts[email] = new Account(email, password);
            return "account created";
        }

        public void SetEnabledAccount(string email)
        {
            _accounts[email].SetEnabled();
        }

        public bool IsEnabledAccount(string email)
        {
            return _accounts[email].IsEnabled;
        }
    }
}