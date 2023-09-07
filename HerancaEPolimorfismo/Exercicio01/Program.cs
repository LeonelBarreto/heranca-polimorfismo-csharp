using Exercicio01.Entities;

namespace Exercicio01;

class Program
{
    static void Main(string[] args)
    {
        Account acc = new Account(1001, "Alex", 500.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

        //UPCASTING
        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Ana", 500.0, 0.01);

        //DOWNCASTING (operação insegura)
        BusinessAccount acc4 = (BusinessAccount)acc2;
        acc4.Loan(100.0);
        // aac2.Loan(100.0) -> não funciona porque a acc2 aqui é do tipo Account.

        // BusinessAccount acc5 = (BusinessAccount)acc3; -> não vai dar erro ao copilar mas ao executar irá apresentar o erro
        // pois SavingsAccount e BusinessAccount são de tipos diferentes

        //Como testar pra saber se o DOWNCASTING (conversão) está funcionando corretamente:
        if (acc3 is BusinessAccount)
        {
            BusinessAccount acc5 = (BusinessAccount)acc3;
            acc5.Loan(200.0);
            Console.WriteLine("Loan!");
        }
        if (acc3 is SavingsAccount)
        {
            SavingsAccount acc5 = acc3 as SavingsAccount;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");
        }
        
        //Sobreposição
        acc.Withdraw(10.0);
        acc3.Withdraw(10.0);

        Console.WriteLine(acc.Balance);
        Console.WriteLine(acc3.Balance);
    }
}

