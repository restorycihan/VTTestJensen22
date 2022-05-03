/*
Klassen Bank ska innehålla en lista med alla kunder.
Klassen ska innehålla ett antal metoder som hanterar kunder och dess konton.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Customer;
using Account;

namespace In2
{
    public class Bank
    {
        List<Customer> customerList;

        // Läser in text filen och befolkar listan som ska innehålla kunderna.
        public virtual Load()
        {
            customerList = new List<Customer>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\data.txt");
            List<string> list = new List<string>();
            foreach (string line in lines)
            {
                list = split.Split(':').ToList();
                AddCustomer(list[1], list[2]);
            }
        }

        // Returnerar bankens alla kunder (personnummer och namn).
        public virtual IList<T> GetCustomers()
        {
            return this.customerList;
        }


        /*
        Skapar en ny kund med namn och personnummer. Kunden skapas endast om det inte finns någon kund med personnumret som angetts. Returnerar True om kunden skapades annars returneras False.
        */
        public virtual bool AddCustomer(string Name, string PersonalNumber)
        {
            bool successfull = false;
            Customer cust = new Customer();
            cust.firstName = Name;
            cust.personalNumber = PersonalNumber;
            this.customerList.Add(cust);
            return successfull;
        }

        public virtual Customer GetCustomer(string PersonalNumber)
        {
            Customer customer = null;
            foreach (Customer customer in this.customerList)
            {
                if (customer.personalNumber == PersonalNumber)
                {
                    break;
                }
            }
            return customer;
        }

        /*
        Returnerar information om kunden inklusive dennes konton. Första platsen i listan är förslagsvis reserverad för kundens namn och personnummer sedan följer informationen om kundens konton.
        */
        public virtual IList<T> GetCustomerInfo(string PersonalNumber)
        {
            List<string> customerInfo = new List<string>();
            Customer customer = GetCustomer(PersonalNumber);
            customerInfo.Add(customer.firstName);
            customerInfo.Add(customer.personalNumber);
            foreach (int account in customer.customerAccounts)
            {
                customerInfo.Add(account);
            }
            return customerInfo;
        }

        /*
        Byter namn på kund, returnerar True om namnet ändrades annars returnerar det False (om kunden inte fanns).
        */
        public virtual bool ChangeCustomerName(string Name, string PersonalNumber)
        {
            bool successfull = false;

            return successfull;
        }

        /*
        Tar bort kund med personnumret som angetts ur banken, alla kundens eventuella konton tas också bort och resultatet returneras. Listan som returneras ska innehålla information om alla konton som togs bort, saldot som kunden får tillbaka.
        */
        public virtual RemoveCustomer(string PersonalNumber)
        {

        }

        /*
        Skapar ett konto till kunden med personnumret som angetts, returnerar kontonumret som det skapade kontot fick alternativt returneras –1 om inget konto skapades.
        */
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

        /*
        Returnerar Textuell presentation av kontot med kontonummer som tillhör kunden (kontonummer, saldo, kontotyp).
        */
        public virtual GetAccount(string PersonalNumber, int AccountId)
        {
            string accountDetails = "";
            return accountDetails;
        }

        // Gör en insättning på kontot, returnerar true om det gick bra annars false.
        public virtual bool Deposit(string PersonalNumber, int AccountId, float Amount)
        {
            bool successfull = false;
            return successfull;
        }

        // Gör ett uttag på kontot, returnerar true om det gick bra annars false.
        public virtual bool Withdraw(string PersonalNumber, int AccountId, float Amount)
        {
            bool successfull = false;
            return successfull;
        }

        // Avslutar ett konto. Textuell presentation av kontots saldo ska genereras och returneras.
        public virtual string CloseAccount(string PersonalNumber, int AccountId)
        {
            return "";
        }
    }
}
