using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutData
{
    public class TestService
    {
        private List<string> a = new List<string>();
        private int[] b = { 5,4,3,2,1 };
        
        public List<string> GetA(int ctr)
        {
            for (int i = 0; i < ctr; i++)
            {
                a.Add("A" + i);
            }

            return a;
        }

        public int[] GetB()
        {
            return b;
        }
    }
}
