using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance1, balance2;
            string fullName1, fullName2, num2;

            Console.Write("Введите числовой номер банковского счета: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите баланс данного счета: ");
            balance1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ФИО владельца данного счета: ");
            fullName1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            BankAccount<int> account1 = new BankAccount<int>(num1, balance1, fullName1);
            account1.PrintInfo();
            Console.WriteLine();

            Console.Write("Введите строковой номер банковского счета: ");
            num2 = Convert.ToString(Console.ReadLine());
            Console.Write("Введите баланс данного счета: ");
            balance2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ФИО владельца данного счета: ");
            fullName2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            BankAccount<string> account2 = new BankAccount<string>(num2, balance2, fullName2);
            account2.PrintInfo();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        T Num { get; set; }
        double Balance { get; set; }
        string FullName { get; set; }
        public BankAccount(T num, double balance, string fullName)
        {
            Num = num;
            Balance = balance;
            FullName = fullName;
        }
        public void PrintInfo()
        {
            Console.WriteLine("   Информация о счете №{0}:", Num);
            Console.WriteLine("   Баланс: {0:N}.", Balance);
            Console.WriteLine("   ФИО владельца: {0}.", FullName);
        }
    }
}
