class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine("Melakukan pembayaran...");
    }
}

class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan transfer sejumlah Rp {jumlah} ke nomor 67676767");
    }
}

class EWallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Saldo terpotong sejumlah Rp {jumlah}");
    }
}

class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transaksi sejumlah Rp {jumlah} berhasil dilakukan");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("----Simulasi Checkout----");
        Console.WriteLine("Pilih metode:");
        Console.WriteLine("1. Bank Transfer");
        Console.WriteLine("2. E-Wallet");
        Console.WriteLine("3. Kartu Kredit");

        Console.Write("Pilihan Anda (1/2/3): ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        MetodePembayaran metode;

        switch (pilihan)
        {
            case 1:
                metode = new BankTransfer();
                break;
            case 2:
                metode = new EWallet();
                break;
            case 3:
                metode = new KartuKredit();
                break;
            default:
                Console.WriteLine("Pilihan tidak valid");
                return;
        }

        metode.Bayar(100000);
    }
}