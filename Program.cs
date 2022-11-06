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