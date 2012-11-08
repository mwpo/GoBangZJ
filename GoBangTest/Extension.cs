namespace GoBangTest
{
    static class Extension
    {
        public static bool TwoDimArrayEqual(this int[,] X, int[,] a, int[,] b)
        {
            if (a.Rank != b.Rank || a.Rank != 2)
                return false;

            for (int i = 0; i < a.Rank; i++)
                if (a.GetLength(i) != b.GetLength(i))
                    return false;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j<a.GetLength(1); j++ )
                {
                    if (a[i, j] != b[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}