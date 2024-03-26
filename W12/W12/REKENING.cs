using System;
using System.Globalization;

public class rekening
{
    public string nama;
    public long saldo;
    public long setoran;
    public long tarikan;

    public rekening (string nama, long saldo)
    {
        this.nama = nama;
        this.saldo = saldo;
    }
    public void setor(long setoran)
    {
        saldo = saldo + setoran;
        var x = new NumberFormatInfo { NumberGroupSeparator = "," };
        Console.WriteLine("Berhasil setor Rp. " + setoran.ToString("n",x));
        Console.ReadKey();
        Console.Clear();   
    }

    public void tarik(long tarikan)
    {
        var x = new NumberFormatInfo { NumberGroupSeparator = "," };
        if (tarikan > saldo)
        {
            Console.WriteLine("Penarikan Rp. " + tarikan.ToString("n", x) + " gagal. Saldo tidak cukup");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Berhasil tarik Rp. " + tarikan.ToString("n", x));
            saldo = saldo - tarikan;
            Console.ReadKey();
        }
    }

    public void ceksaldo()
    {
        var x = new NumberFormatInfo { NumberGroupSeparator = "," };
        Console.WriteLine("Saldo:  Rp. " + (saldo.ToString("n", x)));
    }
}