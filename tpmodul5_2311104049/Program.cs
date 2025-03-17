using System;

namespace tpmodul5_2311104049
{
    // Kelas Generic HaloGeneric
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    // Kelas Generic DataGeneric
    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

    class Program
    {
        static void Main()
        {
            HaloGeneric halo = new HaloGeneric();

            // Input Nama
            Console.WriteLine("=== Program Halo Generic Method ===");
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            halo.SapaUser(nama);

            // Input NIM
            Console.WriteLine("=== Progra Halo Generic Class");
            Console.Write("Masukkan NIM Anda: ");
            string inputNIM = Console.ReadLine();
            DataGeneric<string> dataNIM = new DataGeneric<string>(inputNIM);
            dataNIM.PrintData();

            Console.ReadLine();
        }
    }
}
