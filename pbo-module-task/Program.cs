class Program
{
    static void Main(string[] args)
    {
        kebunBinatang kebun = new kebunBinatang();

        // Membuat beberapa objek hewan menggunakan constructor
        singa singa = new singa("Singa", 7, 4);
        Gajah gajah = new Gajah("Gajah", 10, 4);
        ular ular = new ular("Ular Python", 3, 5);

        // Menambahkan hewan ke dalam kebun binatang
        kebun.tambahHewan(singa);
        kebun.tambahHewan(ular);
        kebun.tambahHewan(gajah);

        // Menampilkan daftar hewan di kebun binatang
        kebun.DaftarHewan();

        // Untuk menampilkan suara singa
        singa.Suara();
        Console.WriteLine();

        // Untuk menampilkan suara gajah
        gajah.Suara();
        Console.WriteLine();

        // Untuk menampilkan suara ular
        ular.Suara();
        Console.WriteLine();

        // Memanggil method mengaum dari objek singa
        singa.mengaum();
        ular.merayap();
    }
}

class hewan
{
    public string nama;
    public int umur;

    // Constructor untuk inisialisasi nama dan umur langsung
    public hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual void Suara()
    {
        Console.WriteLine("Hewan ini bersuara");
    }

    public virtual void Infohewan()
    {
        Console.WriteLine("Nama Hewan: " + nama);
        Console.WriteLine("Umur Hewan: " + umur);
    }
}

class Mamalia : hewan
{
    public int jumlahKaki;

    // Constructor untuk inisialisasi nama, umur, dan jumlahKaki
    public Mamalia(string nama, int umur, int jumlahKaki)
        : base(nama, umur) // Memanggil constructor dari kelas hewan
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override void Infohewan()
    {
        base.Infohewan();
        Console.WriteLine("Jumlah Kaki: " + jumlahKaki);
    }

    public override void Suara()
    {
        Console.WriteLine("Mamalia ini bersuara");
    }
}

class Reptil : hewan
{
    public int panjangTubuh;

    // Constructor untuk inisialisasi nama, umur, dan panjangTubuh
    public Reptil(string nama, int umur, int panjangTubuh)
        : base(nama, umur) // Memanggil constructor dari kelas hewan
    {
        this.panjangTubuh = panjangTubuh;
    }

    public override void Suara()
    {
        Console.WriteLine("Reptil ini bersuara");
    }
}

class singa : Mamalia
{
    // Constructor untuk inisialisasi nama, umur, dan jumlahKaki
    public singa(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }

    public override void Suara()
    {
        Console.WriteLine("Singa mengaum");
    }

    public void mengaum()
    {
        Console.WriteLine("Singa sedang mengaum");
    }
}

class Gajah : Mamalia
{
    // Constructor untuk inisialisasi nama, umur, dan panjangTubuh
    public Gajah(string nama, int umur, int jumlahKaki)
        : base(nama, umur, jumlahKaki)
    {
    }

    public override void Suara()
    {
        Console.WriteLine("Gajah berbunyi");
    }
}

class Buaya : Reptil
{
    // Constructor untuk inisialisasi nama, umur, dan panjangTubuh
    public Buaya(string nama, int umur, int panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }

    public override void Suara()
    {
        Console.WriteLine("Buaya menggeram");
    }
}

class ular : Reptil
{
    // Constructor untuk inisialisasi nama, umur, dan panjangTubuh
    public ular(string nama, int umur, int panjangTubuh)
        : base(nama, umur, panjangTubuh)
    {
    }

    public override void Suara()
    {
        Console.WriteLine("Ular mendesis");
    }

    public void merayap()
    {
        Console.WriteLine("Ular Merayap");
    }
}
class kebunBinatang
{
    // List untuk menyimpan koleksi hewan
    private List<hewan> daftarHewan = new List<hewan>();

    // Method untuk menambahkan hewan ke daftar
    public void tambahHewan(hewan hewan)
    {
        daftarHewan.Add(hewan);
        Console.WriteLine($"{hewan.nama} berhasil ditambahkan ke kebun binatang.");
    }

    // Method untuk menampilkan semua hewan di kebun binatang
    public void DaftarHewan()
    {
        Console.WriteLine("Daftar hewan di kebun binatang:");
        foreach (var hewan in daftarHewan)
        {
            hewan.Infohewan();
        }
    }
}
