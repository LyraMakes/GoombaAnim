

public class Program
{
    public static void Main(string[] args)
    {
        Goomba g = new Goomba();
        ParaGoomba pg = new ParaGoomba();

        ASCIIAni a = new ASCIIAni();

        while (true)
        {
            a.StartAni(g);
            //a.StartAni(pg);

            // Console.Clear();
            // g.DrawSprite(0);
            // Thread.Sleep(100);
            // Console.Clear();
            // g.DrawSprite(150);
            // Thread.Sleep(100);
            
        }
        
    }
}