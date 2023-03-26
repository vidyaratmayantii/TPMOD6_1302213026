using TPMOD6_1302213026;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [VIDYA ANANDA R]");
        video.IncreasePlayCount(1000000000);
        video.IncreasePlayCount(1000000000);
        video.printVideoDetail();


    }
}