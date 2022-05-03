/*
Klassen Bank ska innehålla en lista med alla kunder.
Klassen ska innehålla ett antal metoder som hanterar kunder och dess konton.
*/

using System;
using System.Collections.Generic;

namespace In2
{
    public class Bank
    {
        List<Customer> customerList;

        // Läser in text filen och befolkar listan som ska innehålla kunderna.
        public virtual Load()
        {

        }

        // Returnerar bankens alla kunder (personnummer och namn).
        public virtual GetCustomers()
        {
            List<Customer> customerList;
            return customerList;
        }


        /*
        Skapar en ny kund med namn och personnummer. Kunden skapas endast om det inte finns någon kund med personnumret som angetts. Returnerar True om kunden skapades annars returneras False.
        */
        public virtual bool AddCustomer(string Name, string PersonalNumber)
        {
            bool successfull = false;
            return successfull;
        }

        /*
        Returnerar information om kunden inklusive dennes konton. Första platsen i listan är förslagsvis reserverad för kundens namn och personnummer sedan följer informationen om kundens konton.
        */
        public virtual GetCustomer(string PersonalNumber)
        {
            return listOfCustomerDetails;
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
