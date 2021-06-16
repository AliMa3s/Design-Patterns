using System;

namespace Decorator
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            Versiering kerstBoom = new KerstBoom();
            Versiering kerstBoomMetBallen = new KerstBal(10, new KerstBoom());
            Versiering kerstBoomMetBallenEnEenSlinger = new KerstBal(10, new KerstSlinger(new KerstBoom()));
            Versiering kerstBoomMetSlinger = new KerstSlinger(new KerstBoom());

            Console.WriteLine(kerstBoom.Versier());
            Console.WriteLine(kerstBoomMetBallen.Versier());
            Console.WriteLine(kerstBoomMetBallenEnEenSlinger.Versier());
            Console.WriteLine(kerstBoomMetSlinger.Versier());
        }
    }
}
