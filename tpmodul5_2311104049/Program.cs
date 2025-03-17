using System;

namespace tpmodul5_2311104049
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    class Program
    {
        static void Main()
        {
            HaloGeneric halo = new HaloGeneric();

            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();

            halo.SapaUser(nama);

            Console.ReadLine();
        }
    }
}
