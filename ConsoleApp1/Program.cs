using System;
public class Exercise1_Luni
{
    static void Main(string[] args) // method untuk menerima data
    {
        int[] luni = new int[5] { 20, 40, 60, 58, 870 };
        int n = (5); // deklarasi integer dengan ukuran 5
        int temp, min_index;
        for (int i = 0; i < n - 1; i++) // for n - 1 passes
        {
            min_index = i; 
            for (int CK = i + 1; CK < n; CK++) // pada pass i, bandingkan n - i data pertama dengan data selanjutnya
            {
                if (luni[CK] < luni[min_index]) // jika data tidak dalam urutan yang benar
                {
                    min_index = CK;
                }
            }
            // tukar datas
            temp = luni[min_index];
            luni[min_index] = luni[i];
            luni[i] = temp;
        }
        Console.WriteLine("URUTAN DATA"); // menampilkan judul
        Console.Write("Urutan datanya adalah : "); // menampilkan data yang sudah tersusun dengan urut
        for (int i = 0; i < n; i++) 
        {
            Console.Write(luni[i] + " "); // tampilan data yang sudah tersusun diberi spasi
        }
    }
}