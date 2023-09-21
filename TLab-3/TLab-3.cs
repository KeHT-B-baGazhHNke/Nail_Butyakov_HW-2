using System;

namespace Lab3
{
    enum bank
    {
        current,
        savings
    }
    struct bank_acc
    {
        public ulong id;
        public string type;
        public int bal;
        public void Print()
        {
            Console.WriteLine($"Номер счёта: {id}\nТип счёта: {type}\nБаланс счёта: {bal}");
        }
    }
    enum VUZ
    {
        KFU,
        KAI,
        KHTI
    }
    struct worker
    {
        public string name;
        public VUZ vuz;
        public void Print()
        {
            Console.WriteLine($"{name} работник {vuz}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Лабораторная 3\n\nУпражнение 3.1 тип банковского счета");
                bank account = bank.current;
                Console.WriteLine($"Тип банковского счета {account}");
            }
            {
                Console.WriteLine("\nУпражнение 3.2 банковский счет");
                bank_acc client = new bank_acc();
                client.id = 374829017485798273;
                client.type = "сберегательный";
                client.bal = 420228;
                client.Print();
            }
            {
                Console.WriteLine("\nДомашнее задание 3.1 работники ВУЗ-ов");
                worker worker = new worker();
                worker.name = "Турникмен Выходсилович";
                worker.vuz = VUZ.KAI;
                worker.Print();
            }
        }
    }
}
