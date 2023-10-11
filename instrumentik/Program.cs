using System.ComponentModel.Design;

namespace instrumentik
{
    internal class Program
    {
        static int[] pusytayactav = new int[12];
        static int[] noloctav = new int[12] { 16, 17, 18, 19, 20, 22, 23, 24, 26, 28, 29, 31 };
        static int[] pervoctav = new int[12] { 33, 35, 37, 39, 41, 44, 46, 49, 52, 55, 68, 62 };
        static int[] vtoroctav = new int[12] { 65, 69, 73, 78, 82, 87, 93, 98, 103, 110, 116, 123 };
        static int[] trioctav = new int[12] { 130, 138, 146, 155, 164, 174, 185, 19, 207, 220, 223, 246 };
        static int[] chetirectav = new int[12] { 261, 277, 293, 311, 330, 350, 370, 392, 415, 440, 466, 493 };
        static int[] pyatoctav = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        static int[] shestoctav = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
        static int[] semoktav = new int[12] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
        static int[] vosemoktav = new int[12] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6572, 6645, 7020, 7459, 7902 };

        static void Main(string[] args)

        {
            Console.WriteLine("Нажмите F1-F8");
            Console.WriteLine("Кнопки 1-5 это черные клавиши");
            Console.WriteLine("Кнопки q-u это белые клавиши");

            do { 
            ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.F1)
                {
                    Efki(key);
                }
                else if (key.Key == ConsoleKey.F2)
                {
                    Efki(key);
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    Efki(key);

                }
                else if(key.Key == ConsoleKey.F4)
                {
                    Efki(key);
                }
                
                else if(key.Key == ConsoleKey.F5)
                {
                    Efki(key);
                }
                
                else if(key.Key == ConsoleKey.F6)
                {
                    Efki(key);
                }
                
                else if(key.Key == ConsoleKey.F7)
                {
                    Efki(key);
                }
                
                else if(key.Key == ConsoleKey.F8)
                {
                    Efki(key);
                }
                else if(key.Key == ConsoleKey.F9)
                {
                    Efki(key);
                }
                
                
                Muzika(key);
            } while (true);


        }
        static int[] Efki(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {

                case ConsoleKey.F1:
                    Console.WriteLine("Актава намбер ван");
                    pusytayactav = pervoctav;
                    break;
                case ConsoleKey.F2:
                    Console.WriteLine("Актава намбер ту");
                    pusytayactav = vtoroctav;
                    break;
                case ConsoleKey.F3:
                    Console.WriteLine("Актава намбер фри");
                    pusytayactav = trioctav;
                    break;
                case ConsoleKey.F4:
                    Console.WriteLine("Актава намбер фор");
                    pusytayactav = chetirectav;
                    break;
                    case ConsoleKey.F5:
                    Console.WriteLine("Актава намбер файв");
                    pusytayactav = chetirectav;
                    break;
                    case ConsoleKey.F6:
                    Console.WriteLine("Актава намбер сикс");
                    pusytayactav = pyatoctav;
                    break;
                    case ConsoleKey.F7:
                    Console.WriteLine("Актава намбер севен");
                    pusytayactav = shestoctav;
                    break;
                    case ConsoleKey.F8:
                    Console.WriteLine("Актава намбер ейт");
                    pusytayactav = semoktav;
                    break;
                    case ConsoleKey.F9:
                    Console.WriteLine("Актава намбер найн");
                    pusytayactav = vosemoktav;
                    break;

            }
                    return pusytayactav;
        }
        static void Muzika(ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Beep(pusytayactav[1], 300);
                    break;
                case ConsoleKey.D2:
                    Console.Beep(pusytayactav[4], 300);
                    break;
                case ConsoleKey.D3:
                    Console.Beep(pusytayactav[7], 300);
                    break;
                case ConsoleKey.D4:
                    Console.Beep(pusytayactav[8], 200);
                    break;
                case ConsoleKey.D5:
                    Console.Beep(pusytayactav[10], 200);
                    break;
                case ConsoleKey.Q:
                    Console.Beep(pusytayactav[0], 200);
                    break;
                case ConsoleKey.W:
                    Console.Beep(pusytayactav[2], 200);
                    break;
                case ConsoleKey.E:
                    Console.Beep(pusytayactav[3], 200);
                    break;
                case ConsoleKey.R:
                    Console.Beep(pusytayactav[5], 200);
                    break;
                case ConsoleKey.T:
                    Console.Beep(pusytayactav[6], 200);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(pusytayactav[9], 200);
                    break;
                case ConsoleKey.U:
                    Console.Beep(pusytayactav[11], 200);
                    break;

            }
        }

    }
}