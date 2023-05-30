using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectrors = { 10, 40, 40, 10 };
            bool isOpen = true;

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                for (int i = 0; i < sectrors.Length; i++)
                {
                    Console.WriteLine($"В секторе {i + 1} свободно: {sectrors[i]}");
                }

                Console.SetCursorPosition(0, 0);

                Console.WriteLine("Добро пожаловать на регистрацию!\n");
                Console.WriteLine("1 - Забронировать места");
                Console.WriteLine("2 - Выйти из программы\n");
                Console.Write("Какую операцию вы хотите выполнить? ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userSeat;
                        Console.Write("В каком секторе вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectrors.Length <= userSector || userSector <= 0)
                        {
                            Console.WriteLine("Такого сектора не существует");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать?");
                        userSeat = Convert.ToInt32(Console.ReadLine());
                        if (sectrors[userSector] < userSeat)
                        {
                            Console.WriteLine($"В секторе {userSector} недостаточно мест! " +
                                $"Остаток {sectrors[userSector]}");
                            break;
                        }
                        if (userSeat < 0)
                        {
                            Console.WriteLine($"Вы можете выбрать минимум 1 место");
                            break;
                        }
                        sectrors[userSector] -= userSeat;
                        break;
                    case 2:
                        isOpen = false;
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}
