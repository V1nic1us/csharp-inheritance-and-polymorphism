using csharp_inheritance_and_polymorphism.Entities;

namespace csharoInheritanceAndPolymorphism
{
    class MyClass
    {
        static void Main(string[] agrs)
        {
            Account account = new Account(1001, "Marcus", 0.0);
            BusinessAccount account2 = new BusinessAccount(1002, "Marcus", 0.0, 500.0);
            SavingsAccount account3 = new SavingsAccount(1003, "Marcus", 0.0, 800.0);

            //UpCasting

            Account account4 = account2;
            Account account5 = new BusinessAccount(1004, "Larissa", 0.0, 500.0);
            Account account6 = account3;

            //DownCasting

            BusinessAccount account7 = (BusinessAccount)account;

            if (account3 is BusinessAccount)
            {
                //BusinessAccount account8 = account3 as BusinessAccount;
                BusinessAccount account9 = account2 as BusinessAccount;
            }
        }
    }
}