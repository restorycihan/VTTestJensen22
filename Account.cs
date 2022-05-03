/*
Man ska kunna utföra transaktioner (insättning/uttag), hämta kontonummer, samt presentera kontot (visa kontonummer, saldo, kontotyp).
Implementera metoder som säkerställer ovanstående krav i klassen Bank. 
(Bank klassdesign inkluderar metoderna som ska användas. Komplettera
dessa med en implementation eller fler metoder om det behövs.)
*/

using System;

namespace In2
{
    public class Account
    {
        int accountNumber { get; set; }     // det kan inte finnas flera konton med samma kontonummer
        string accountType { get; set; }
        float balance { get; set; }

    }
}
