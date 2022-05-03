/*

Man ska till exempel kunna ändra kundens namn samt hämta information om kunden (personnummer, för- och efternamn samt hämta information om kundens konton (kontonummer, saldo, kontotyp)). 
Dessutom ska man kunna hantera kundens konto(n). Implementera metoder som säkerställer ovanstående krav i klassen Bank nedan.
(Bank inkluderar förslag på metoder. Komplettera dessa med fler metoder om det behövs).
*/

using System;
using System.Collections.Generic;

namespace In2
{
    public class Customer
    {
        int id { get; set; }
        string firstName { get; set; }
        string surName { get; set; }
        string personalNumber { get; set; }
        List<int> customerAccounts;

    }
}
