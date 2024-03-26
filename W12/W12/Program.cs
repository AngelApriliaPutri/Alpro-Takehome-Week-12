using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int rek = 0;
        long saldoawal = 0;
        string n = "";
        List<rekening> nrek = new List<rekening>();
        List<string> urutrek = new List<string>();
        string namarek = "";
        int a = 0;
        string pilih = "";
        string pilih2 = "";
        int setor = 0;
        int tarik = 0;
        long setoran = 0;
        long tarikan = 0;
        while (a == 0)
        {
            Console.WriteLine("|N| Tambah Rekening \n|X| Exit");
            Console.WriteLine();
            Console.WriteLine("Daftar Rekening: ");
            if (rek == 0)
            {
                Console.WriteLine("Belum ada rekening \n");
            }
            if (rek >= 1)
            {
                for (int i = 0; i < rek; i++)
                {
                    Console.WriteLine("[" + urutrek[i] + "] " + nrek[i].nama);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Pilih: ");
            pilih = Console.ReadLine();
            Console.WriteLine();
            if (pilih == "N")
            {
                Console.WriteLine("Nama Rekening : ");
                namarek = Console.ReadLine();
                nrek.Add(new rekening( namarek, saldoawal));
                rek++;
                urutrek.Add("R"+rek);
                Console.Clear();
            }
            else if (pilih == "X")
            {
                a++;
            }
            for (int i = 0; i < rek; i++)
            {
                if (pilih == urutrek[i])
                {
                    pilih2 = "";
                    while (pilih2 != "X")
                    {
                        pilih = "O";
                        Console.Clear();
                        Console.WriteLine("REKENING " + nrek[i].nama);
                        nrek[i].ceksaldo();
                        Console.WriteLine();
                        Console.WriteLine("[S] Setor \n[T] Tarik \n[X] Return");
                        Console.Write("Pilih: ");
                        pilih2 = Console.ReadLine();
                        if (pilih2 == "S")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Masukkan nominal setor: ");
                            setoran = Convert.ToInt32(Console.ReadLine());
                            nrek[i].setor(setoran);
                        }
                        else if (pilih2 == "T")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Masukkan nominal tarik: ");
                            tarikan = Convert.ToInt32(Console.ReadLine());
                            nrek[i].tarik(tarikan);
                        }
                        else if (pilih2 == "X")
                        {
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (pilih2 != "S" && pilih2 != "T" && pilih2 != "X" && pilih2 != urutrek[i])
                        {
                            Console.WriteLine("Invalid Input");
                            Console.ReadKey();
                        }
                    }
                }
            }

            if (pilih != "N" && pilih != "X" && pilih != "O")
            {
                Console.WriteLine("Invalid Input");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}