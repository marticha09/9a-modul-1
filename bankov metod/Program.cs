using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankov_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BanckAccount account = new BanckAccount();
            account.ID = 10;
            account.Balance = 300;
            account.Deposit(180);
            account.Withdraw(160);
            Console.WriteLine(account.ToString());

            Dictionary<int, BanckAccount> accounts = new Dictionary<int, BanckAccount>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] parts = input.Split();
                string command = parts[0];
                int id = int.Parse(parts[1]);
                try
                {
                    switch (command)
                    {
                        case "Suzdai":
                            if (accounts.ContainsKey(id))
                            {
                                Console.WriteLine("Akaunta veche sushtesvuva");
                            }
                            else
                            {
                                accounts[id] = new BanckAccount();
                                accounts[id].ID = id;
                                Console.WriteLine($"Akaunt s ID {id} Suzdade:");
                            }
                            break;
                        case "Deposit":
                            double amount = double.Parse(parts[2]);
                            if (accounts.ContainsKey(id))
                            {
                                accounts[id].Deposit(amount);
                                Console.WriteLine($"Deposited {amount} to account with ID {id}");
                            }
                            else
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            break;
                        case "prevedi":
                            amount = double.Parse(parts[2]);
                            if (accounts.ContainsKey(id))
                            {
                                accounts[id].Withdraw(amount);
                                Console.WriteLine($"prevedi {amount} ot akaunta s ID:{id}");
                            }
                            else
                            {
                                Console.WriteLine("akaunta ne sushtesvuva");
                            }
                            break;
                        case "printirai":
                            if (accounts.ContainsKey(id))
                            {
                                Console.WriteLine(accounts[id].ToString());
                            }
                            else
                            {
                                Console.WriteLine("akaunta ne sushtesvuva");
                            }
                            break;
                        default:
                            Console.WriteLine("nevalidna komanda");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
