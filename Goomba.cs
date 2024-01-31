
class Goomba
{
    private string[] goombaSprite;

    public Goomba()
    {
        goombaSprite = new string[10];
        goombaSprite[0] = @"     ________      ";
        goombaSprite[1] = @"    /        \     ";
        goombaSprite[2] = @"   /  \    /  \    ";
        goombaSprite[3] = @"  /   |    |   \   ";
        goombaSprite[4] = @" /  _^______^_  \  ";
        goombaSprite[5] = @"|________________| ";
        goombaSprite[6] = @"      /    \       ";
        goombaSprite[7] = @" ____|      |____  "; 
        goombaSprite[8] = @"/____\ ==== /____\ ";
        goombaSprite[9] = @"                   ";
    }

    public void DrawSprite(int spacing)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string(' ', spacing) + goombaSprite[i]);
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