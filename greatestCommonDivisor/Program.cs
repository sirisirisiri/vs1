namespace greatestCommonDivisor
{
    class Program
    {
        public int gcd(int x,int y)
        {
            if (x % y == 0)
            {
                return y;
            }

            else
            {
                return gcd(y, x % y);
            }
 
        }
         
        static void Main(string[] args)
        {
            Program t = new Program();
            int x = t.gcd(12, 16);
             System.Console.WriteLine(x);
            System.Console.Read();
        }
    }
}
