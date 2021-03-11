using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class BankAccount
    {
        private string name;
        private string accountNumber;
        private string address;
        private string email;
        private bool newsletter;
        private bool mobileBanking;

        private BankAccount(string name,
            string accountNumber,
            string address,
            string email,
            bool newsletter,
            bool mobileBanking)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.address = address;
            this.email = email;
            this.newsletter = newsletter;
            this.mobileBanking = mobileBanking;
        }
        public override String ToString()
        {
            return "BankAccount [name=" + name + ", accountNumber=" + accountNumber + ", address=" + address + ", email="
                    + email + ", newsletter=" + newsletter + ", mobileBanking=" + mobileBanking + "]";
        }
        public class BankAccountBuilder
        {
            private String name; // required
            private String accountNumber; // required
            private String address;
            private String email;
            private bool newsletter;
            private bool mobileBanking;
            public BankAccountBuilder(String name, String accountNumber)
            {
                this.name = name;
                this.accountNumber = accountNumber;
            }

            public BankAccountBuilder withAddress(String address)
            {
                this.address = address;
                return this;
            }

            public BankAccountBuilder withEmail(String email)
            {
                this.email = email;
                return this;
            }

            public BankAccountBuilder wantNewsletter(bool newsletter)
            {
                this.newsletter = newsletter;
                return this;
            }

            public BankAccountBuilder wantMobileBanking(bool mobileBanking)
            {
                this.mobileBanking = mobileBanking;
                return this;
            }
            private void validateUserObject()
            {
                // Do some basic validations to check
                if (this.newsletter && email == null)
                {
                    throw new Exception("Email can't be null when client want to receive the new letter");
                }
            }
            public BankAccount build()
            {
                validateUserObject();

                BankAccount bankAccount = new BankAccount(
                        this.name, this.accountNumber,
                        this.address, this.email,
                        this.newsletter, this.mobileBanking);

                return bankAccount;
            }
        }
    }
}
