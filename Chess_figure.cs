using System;
namespace A
{
    public class Chess_figure
    {
        private String[] NAMES = { "Пешка", "Конь", "Слон", "Ладья", "Ферзь" };
        private String name;

        public int value;
        public bool pawn;


        public void Read()
        {

            int vibor;
            Console.WriteLine("Название фигуры");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}  {NAMES[i]}");
              
            }


            vibor = Convert.ToInt32(Console.ReadLine());

            name = NAMES[vibor - 1];
            switch (vibor)
            {
                case 1: { value = 1; pawn = true; } break;
                case 2: { value = 3; } break;
                case 3: { value = 3; } break;
                case 4: { value = 5; } break;
                case 5: { value = 9; } break;
            }


        }


        public void Init(int val, String nam)
        {
            value = val;
            name = nam;
            if (name == NAMES[0])
                pawn = true;
            else
                pawn = false;
        }


        public void Display()
        {
            Console.WriteLine($"{name} Ценность {value}");
        }


    }
}
