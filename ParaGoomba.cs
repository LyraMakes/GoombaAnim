
class ParaGoomba : Villain
{
    private string[] paraGoombaSprite;

    public ParaGoomba()
    {
        paraGoombaSprite = new string[10];
        paraGoombaSprite[1] = @"             /        \ ";
        paraGoombaSprite[0] = @"              ________  ";
        paraGoombaSprite[2] = @"            /  \    /  \ ";
        paraGoombaSprite[3] = @"           /   |    |   \ ";
        paraGoombaSprite[4] = @"_________ /  -^------^-  \ _________";
        paraGoombaSprite[5] = @"\_       |________________|       _/";
        paraGoombaSprite[6] = @"  \_           /    \           _/  ";  
        paraGoombaSprite[7] = @"    \____ ____|      |____ ____/";
        paraGoombaSprite[8] = @"         /____\ ==== /____\ ";
        paraGoombaSprite[9] = @"                             ";
    }

    public void DrawSprite(int spacing)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string(' ', spacing) + paraGoombaSprite[i]);
        }
    }

    public void Move(int speed, int distance, int frameDelay)
    {
        int position = 0;

        while (position < distance)
        {
            Console.Clear();
            DrawSprite(position);
            Thread.Sleep(frameDelay);
            position += speed;
        }

        while (position > 0)
        {
            Console.Clear();
            DrawSprite(position);
            Thread.Sleep(frameDelay);
            position -= speed;
        }


    }
}