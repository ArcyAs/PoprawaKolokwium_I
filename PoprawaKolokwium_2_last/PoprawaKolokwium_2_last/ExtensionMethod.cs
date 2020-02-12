namespace PoprawaKolokwium_2_last
{
    public static class ExtensionMethod
    {
        public static int RazyDz(this int[]tablica)
        {
            int[] pomnozone = new int[10];
            for (int i = 1; i < 10 ; i++)
            {
                pomnozone[i] = tablica[i] *10;
            }
        }
    }
}