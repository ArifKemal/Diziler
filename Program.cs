internal class Program
{
    private static void Main(string[] args)
    {
       string[] renkler = new string[5];

       string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

       int[] dizi;
       dizi = new int[5];

       renkler[0] = "mavi";
       dizi[3] = 10;

       System.Console.WriteLine(hayvanlar[1]);
       System.Console.WriteLine(dizi[3]);
       System.Console.WriteLine(renkler[0]);

        System.Console.WriteLine("dizinin eleman sayisini girin: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];


        for (int i = 0; i < diziUzunlugu; i++)
        {
            System.Console.WriteLine("lütfen {0}. sayisini girin: ",i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi; 

            System.Console.WriteLine("ortalama :" + toplam/diziUzunlugu);           
        }








    }
}