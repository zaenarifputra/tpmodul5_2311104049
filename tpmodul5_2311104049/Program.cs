using System;

namespace tpmodul5_2311104049
{
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
            Console.Write("Masukkan NIM Anda: ");
            string inputNIM = Console.ReadLine();

            DataGeneric<string> dataNIM = new DataGeneric<string>(inputNIM);
            dataNIM.PrintData();
            Console.ReadLine();
        }
    }
}
