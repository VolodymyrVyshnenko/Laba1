using System;

namespace Lab1_1
{
    public delegate int delegates();

    public class N3
    {

        public static delegates[] arr = new delegates[]
        {
            new delegates(Ran.random),
            new delegates(Ran.random),
            new delegates(Ran.random)
        };

    }

    public static class Ran
    {
        public static int random()
        {
            Random r = new Random();
            return r.Next(50);
        }
    }
}