using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_C_sharp_
{
    struct STATE
    {
        public string StateName;
        public string Capital;
        public string Continent;
        public long Population;
        public int Area;
    };

    class Information
    {

        public static int size = 0, index = size, count = 0;
        public static STATE[] state = new STATE[size];

        public static string password = "state";
        public static int count_1 = 0, count_2 = 0;

      
        public void StateDelete(int actual)
        {
            int new_size = size - 1;
            STATE[] TempArray = new STATE[new_size];
            Array.Copy(state, 0, TempArray, 0, actual);
            Array.Copy(state, actual + 1, TempArray, actual, size - actual - 1);
            ClearAll();
            size = new_size;
            index = size;
            ArrayResize();
            Array.Copy(TempArray, 0, state, 0, size);
            Array.Clear(TempArray, 0, size);
        }

            public void ClearAll()
            {
                Array.Clear(state, 0, size);
                size = 0;
                index = 0;
            }

            public void ArrayResize()
            {
                Array.Resize(ref state, size);
            }
    }
}
