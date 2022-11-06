namespace System
{
    class Program
    {
        static void Main()
        {
            int[] a = new int[] { 0, 1, 1, 2, 3, 3, 3 };
            int[] b = new int[] { 0, 2, 2, 3, 4 };
            Print(a, b);
        }

        public static void Print(int[] a, int[] b)
        {
            bool isUnique;
            bool isEmpty = true;
            int ia = 0;
            int ib = 0;
            while (ia != a.Length || ib != b.Length)
            {
                if (ia != a.Length && (ib == b.Length || a[ia] < b[ib]))
                {
                    if (ia > 0 && a[ia] == a[ia - 1])
                    {
                        ia++;
                        continue;
                    }

                    isUnique = true;
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (a[ia] == b[i]) isUnique = false;
                    }
                    if (isUnique)
                    {
                        isEmpty = false;
                        Console.Write("{0} ", a[ia]);
                    }
                    ia++;
                }
                else
                {
                    if (ib > 0 && b[ib] == b[ib - 1])
                    {
                        ib++;
                        continue;
                    }

                    isUnique = true;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (b[ib] == a[i]) isUnique = false;
                    }
                    if (isUnique)
                    {
                        isEmpty = false;
                        Console.Write("{0} ", b[ib]);
                    }
                    ib++;
                }
            }
            if (isEmpty) Console.Write("empty");
        }

        public static void Print2(int[] a, int[] b)
        {
            bool isCommon;
            bool isEmpty = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (i > 0 && a[i] == a[i - 1]) continue; //skip duplicates

                isCommon = false;
                for (int ii = 0; ii < b.Length; ii++)
                {
                    if (a[i] == b[ii])
                    {
                        isCommon = true;
                        break;
                    }
                }
                if (isCommon)
                {
                    Console.Write("{0} ", a[i]);
                    isEmpty = false;
                }
            }

            if (isEmpty) Console.Write("empty");
        }

        public static void Print1(int[] a, int[] b)
        {
            bool isUnique;
            bool isEmpty = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (i > 0 && a[i] == a[i - 1]) continue; //skip duplicates

                isUnique = true;
                for (int ii = 0; ii < b.Length; ii++)
                {
                    if (a[i] == b[ii])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.Write("{0} ", a[i]);
                    isEmpty = false;
                }
            }

            if (isEmpty) Console.Write("empty");
        }
    }
}