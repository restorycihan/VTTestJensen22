using System;

namespace In2
{
    public class Bank
    {
        public virtual GetCustomers()
        {
            List<Customer> customerList;
            return customerList;
        }

        public virtual bool AddCustomer(string Name, string PersonalNumber)
        {
            bool successfull = false;
            return successfull;
        }

        public virtual GetCustomer(string PersonalNumber)
        {
            return listOfCustomerDetails;
        }

        public virtual bool ChangeCustomerName(string Name, string PersonalNumber)
        {
            bool successfull = false;
            return successfull;
        }

        public virtual RemoveCustomer(string PersonalNumber)
        {

        }

        public virtual int AddAccount(string PersonalNumber)
        {
            int accountCode = -1;
            if (PersonalNumber != "")
            {
                Random rnd = new Random();
                accountCode = rnd.Next(1000, 1999);
            }
            return accountCode;
        }

        public virtual GetAccount(string PersonalNumber, int AccountId)
        {
            string accountDetails = "";
            return accountDetails;
        }

        public virtual bool Deposit(string PersonalNumber, int AccountId, float Amount)
        {
            bool successfull = false;
            return successfull;
        }

        public virtual bool Withdraw(string PersonalNumber, int AccountId, float Amount)
        {
            bool successfull = false;
            return successfull;
        }

        public virtual string CloseAccount(string PersonalNumber, int AccountId)
        {
            return "";
        }
    }
}
