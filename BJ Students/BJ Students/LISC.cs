using System;

namespace BJ_Students
{
    //Level Integer String Conversion
    //this class contains the methods for changing lvl integers to strings and
    //vis-versa; it was previously in multiple locations and then consolidated
    //here for more efficient coding practices
    public static class LISC
    {
        //moves from string to get the level, for storing values as integers
        public static int GetEngLevel(string lvl)
        {
            if (lvl == "B0")
            {
                return 0;
            }

            if (lvl == "B1")
            {
                return 1;
            }

            if (lvl == "B2")
            {
                return 2;
            }

            if (lvl == "IM1")
            {
                return 3;
            }

            if (lvl == "IM2")
            {
                return 4;
            }

            if (lvl == "AD1")
            {
                return 5;
            }

            if (lvl == "AD2")
            {
                return 6;
            }

            return -1;
        }

        //moves from integer to string to get the level
        public static string GetLevelString(int lvl)
        {
            if (lvl == 0)
            {
                return "B0";
            }

            if (lvl == 1)
            {
                return "B1";
            }

            if (lvl == 2)
            {
                return "B2";
            }

            if (lvl == 3)
            {
                return "IM1";
            }

            if (lvl == 4)
            {
                return "IM2";
            }

            if (lvl == 5)
            {
                return "AD1";
            }

            if (lvl == 6)
            {
                return "AD2";
            }

            return "null";
        }
    }
}
