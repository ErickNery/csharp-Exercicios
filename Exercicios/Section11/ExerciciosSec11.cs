using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios.Section11
{
    class ExerciciosSec11
    {
        /*Fazer um programa para ler os dados de uma conta bancária e depois realizar um
          saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
          ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
          saque da conta. */
        public void Exercicio1()
        {
            int accountNumber;
            string accountHolder;
            double accountBalance;
            double accountWithdrawLimit;
            Account account;

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                accountHolder = Console.ReadLine();
                Console.Write("Initial balance: ");
                accountBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                accountWithdrawLimit = double.Parse(Console.ReadLine());
                account = new Account(accountNumber, accountHolder, accountBalance, accountWithdrawLimit);
                Console.Write("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine()));
                Console.Write("New balance: {0}", account.Balance);

            }
            catch (Exception e)
            {
                if (e is FormatException || e is DomainException)
                {
                    Console.WriteLine("Exception: " + e.Message);
                    return;
                }
                throw;
            }

        }

    }
}
