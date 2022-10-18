// Определение является ли число палиндромом

Console.WriteLine("Введите число:");
            string str = Console.ReadLine();
            int prov = 0;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str.Substring(i, 1) != (str.Substring(str.Length - 1 - i, 1)))
                {
                    Console.WriteLine("Число {0} не является палиндромом", str);
                    break;
                }
                else
                    prov = 1;
            }
            if (prov == 1) Console.WriteLine("Число {0} является палиндромом", str);

