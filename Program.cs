using System;

namespace A
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            String[] NAMES = { "Пешка", "Конь", "Слон", "Ладья", "Ферзь" };
            Chess_figure[] MAS = new Chess_figure[10];

            for (int i = 0; i < 10; i++)
            {
                MAS[i] = new Chess_figure();
                switch (i % 5)
                {
                    case 0: { MAS[i].Init(1, NAMES[i % 5]); }; break;
                    case 1: { MAS[i].Init(3, NAMES[i % 5]); }; break;
                    case 2: { MAS[i].Init(3, NAMES[i % 5]); }; break;
                    case 3: { MAS[i].Init(5, NAMES[i % 5]); }; break;
                    case 4: { MAS[i].Init(9, NAMES[i % 5]); }; break;
                }

            }

            Chess_Player Andrey = new Chess_Player();
            Chess_Player Magnus = new Chess_Player();
            Magnus.playerInit("Magnus", 10, MAS, 1);
            Andrey.playerRead();

            Andrey.playerDisplay();
            Console.Clear();
            Console.ReadKey();
            Magnus.playerDisplay();
            Andrey.playerCompare(Magnus);

        }
    }
}
