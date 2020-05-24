using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_C_sharp_
{
    class Information
    {
        public static int size = 20, index = size, count = 0;
        public static string[] StateName = new string[size];
        public static string[] Capital = new string[size];
        public static string[] Сontinent = new string[size];
        public static int[] Population = new int[size];
        public static int[] Area = new int[size];

        public static string password = "state";
        public static int count_1 = 0, count_2 = 0;

        public void StartingDatabase()
        {
            const int starting_size = 20;
            string[] starting_StateName = new string[starting_size] { "Австрия", "Армения", "Бахрейн", "Ботсвана", "Вьетнам", "Гвинея", "Греция", "Доминика", "Египет", "Италия", "Испания", "Латвия", "Мали", "Монако", "Перу", "Сингапур", "Сомали", "Турция", "Чили", "Чехия" };
            string[] starting_Capital = new string[starting_size] { "Вена", "Ереван", "Манама", "Габороне", "Ханой", "Конакри", "Афины", "Розо", "Каир", "Рим", "Мадрид", "Рига", "Бамако", "Монако", "Лима", "Сингапур", "Могадишо", "Анкара", "Сантьяго", "Прага" };
            string[] starting_Continent = new string[starting_size] { "Европа", "Азия", "Азия", "Африка", "Азия", "Африка", "Европа", "Северная Америка", "Африка", "Европа", "Европа", "Европа", "Африка", "Европа", "Южная Америка", "Азия", "Африка", "Азия", "Южная Америка", "Европа" };
            int[] starting_Population = new int[starting_size] { 8741753, 2995100, 1397000, 2209208, 91713300, 10628972, 10793526, 69393, 91701724, 60665551, 46438422, 1968957, 18135000, 38400, 31488625, 5607300, 12316895, 78471053, 18006407, 10553843 };
            int[] starting_Area = new int[starting_size] { 83858, 29741, 701, 600370, 329560, 245857, 131940, 754, 1001450, 301340, 497304, 64589, 1240000, 20, 1285220, 714, 637657, 780580, 756950, 78866 };

            for (int i = 0; i < starting_size; i++)
            {
                StateName[i] = starting_StateName[i];
                Capital[i] = starting_Capital[i];
                Сontinent[i] = starting_Continent[i];
                Population[i] = starting_Population[i];
                Area[i] = starting_Area[i];
            }
            count++;
        }
            public void StateDelete(int actual)
            {
                int new_size = size - 1;
                string[] temp_StateName = new string[new_size];
                string[] temp_Capital = new string[new_size];
                string[] temp_Continent = new string[new_size];
                int[] temp_Population = new int[new_size];
                int[] temp_Area = new int[new_size];

                Array.Copy(StateName, 0, temp_StateName, 0, actual);
                Array.Copy(Capital, 0, temp_Capital, 0, actual);
                Array.Copy(Сontinent, 0, temp_Continent, 0, actual);
                Array.Copy(Population, 0, temp_Population, 0, actual);
                Array.Copy(Area, 0, temp_Area, 0, actual);

                Array.Copy(StateName, actual + 1, temp_StateName, actual, size - actual - 1);
                Array.Copy(Capital, actual + 1, temp_Capital, actual, size - actual - 1);
                Array.Copy(Сontinent, actual + 1, temp_Continent, actual, size - actual - 1);
                Array.Copy(Population, actual + 1, temp_Population, actual, size - actual - 1);
                Array.Copy(Area, actual + 1, temp_Area, actual, size - actual - 1);

                ClearAll();
                size = new_size;
                index = size;
                ArrayResize();

                Array.Copy(temp_StateName, 0, StateName, 0, size);
                Array.Copy(temp_Capital, 0, Capital, 0, size);
                Array.Copy(temp_Continent, 0, Сontinent, 0, size);
                Array.Copy(temp_Population, 0, Population, 0, size);
                Array.Copy(temp_Area, 0, Area, 0, size);

                Array.Clear(temp_StateName, 0, size);
                Array.Clear(temp_Capital, 0, size);
                Array.Clear(temp_Continent, 0, size);
                Array.Clear(temp_Population, 0, size);
                Array.Clear(temp_Area, 0, size);
            }

            public void ClearAll()
            {
                Array.Clear(StateName, 0, size);
                Array.Clear(Capital, 0, size);
                Array.Clear(Сontinent, 0, size);
                Array.Clear(Population, 0, size);
                Array.Clear(Area, 0, size);
                size = 0;
                index = 0;
            }

            public void ArrayResize()
            {
                Array.Resize(ref StateName, size);
                Array.Resize(ref Capital, size);
                Array.Resize(ref Сontinent, size);
                Array.Resize(ref Population, size);
                Array.Resize(ref Area, size);
            }
    }
}
