using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // a. Buat objek kebun binatang
        KebunBinatang kebun = new KebunBinatang();

        // b. Buat beberapa objek dari berbagai jenis hewan
        Singa singa = new Singa("Singa", 5, 4);
        Gajah gajah = new Gajah("Gajah", 10, 4);
        Ular ular = new Ular("Ular", 3, 2);
        Buaya buaya = new Buaya("Buayaaa", 7, 3);

        // c. Tambahkan hewan-hewan tersebut ke kebun binatang
        kebun.TambahHewan(singa);
        kebun.TambahHewan(gajah);
        kebun.TambahHewan(ular);
        kebun.TambahHewan(buaya);

        // d. Panggil method DaftarHewan() untuk menampilkan semua hewan
        kebun.DaftarHewan();

        Console.WriteLine("\nDemonstrasi polymorphism:");
        // e. Demonstrasi penggunaan polymorphism
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        // f. Panggil method khusus
        Console.WriteLine("\nMethod khusus:");
        Console.WriteLine(singa.Mengaum());
        Console.WriteLine(ular.Merayap());
    }
}

class Hewan
{
    public string nama;
    public int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual string Suara()
    {
        return ("Hewan ini bersuara");
    }

    public virtual string InfoHewan()
    {
        return ($"Nama: {nama},\nUmur: {umur} tahun");
    }
}

class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + ($"\nJumlah Kaki: {jumlahKaki}");
    }
}

class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.panjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + ($"\nPanjang Tubuh: {panjangTubuh} meter");
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return ("Singa mengaum");
    }

    public string Mengaum()
    {
        return ("Singa sedang mengaum dengan keras");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return ("Gajah berteriak");
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return ("Ular mendesis");
    }

    public string Merayap()
    {
        return ("Ular sedang merayap");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return ("Buaya menggeram");
    }
}

class KebunBinatang
{
    private List<Hewan> daftarHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        daftarHewan.Add(hewan);
        Console.WriteLine($"{hewan.nama} berhasil ditambahkan ke kebun binatang.");
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar hewan di kebun binatang:");
        foreach (var hewan in daftarHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine();
        }
    }
}