using TPMOD6_1302213026;

internal class Program
{
    private static void Main(string[] args)
    {
        try {
            //membuat objek video
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [VIDYA ANANDA R]");
            //menambahkan dan print playcoutn
            video.IncreasePlayCount(10000);
            video.printVideoDetail();
            //menambahkan playcount hingga limit
            for(int i = 0; i < 214; i++)
            {
                video.IncreasePlayCount(10000000);
            }
            video.printVideoDetail();
            //menambahkan lagi agar overflow

            video.IncreasePlayCount(10000000);


        }
        catch (OverflowException)
        {
            //akan muncul jika overflow
            Console.WriteLine("Overflow");
        }
        


    }
}