
class Goomba : Villain
{
    private string[] goombaSprite;
    private string[] altGoombaSprite;

    public Goomba()
    {
        goombaSprite = new string[10];
        goombaSprite[0] = @"     ________      ";
        goombaSprite[1] = @"    /        \     ";
        goombaSprite[2] = @"   /  \    /  \    ";
        goombaSprite[3] = @"  /   |    |   \   ";
        goombaSprite[4] = @" /  -^------^-  \  ";
        goombaSprite[5] = @"|________________| ";
        goombaSprite[6] = @" ____ /    \       ";  
        goombaSprite[7] = @"/____\      |____  ";
        goombaSprite[8] = @"       ==== /____\ ";
        goombaSprite[9] = @"                   ";

        altGoombaSprite = new string[10];
        altGoombaSprite[0] = @"     ________      ";
        altGoombaSprite[1] = @"    /        \     ";
        altGoombaSprite[2] = @"   /  \    /  \    ";
        altGoombaSprite[3] = @"  /   |    |   \   ";
        altGoombaSprite[4] = @" /  -^------^-  \  ";
        altGoombaSprite[5] = @"|________________| ";
        altGoombaSprite[6] = @"      /    \ ____  ";
        altGoombaSprite[7] = @" ____|      /____\ ";
        altGoombaSprite[8] = @"/____\ ====        ";
        altGoombaSprite[9] = @"                   ";

    }

    public void DrawSprite(int spacing)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string(' ', spacing) + goombaSprite[i]);
        }
    }

    public void DrawAltSprite(int spacing)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(new string(' ', spacing) + altGoombaSprite[i]);
        }
    }

    public void DrawGround(int number)
    {
        Console.WriteLine(new string('=', number));
    }

    private void DrawStar()
    {
        string[] starSprite = new string[6];
        starSprite[0] = @"           ";
        starSprite[1] = @"  ___/\___ ";
        starSprite[2] = @"  \  ||  / ";
        starSprite[3] = @"  /__  __\ ";
        starSprite[4] = @"     \/    ";
        starSprite[5] = @"           ";

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(starSprite[i]);
        }
        
    }

    public void Move(int speed, int distance, int frameDelay)
    {
        int position = 0;
        bool leftStep = false; 



        while (position < distance)
        {
            Console.Clear();
            DrawStar();
            
            if (leftStep)
            {
                DrawSprite(position);
            } else
            {
                DrawAltSprite(position);
            }
            leftStep = !leftStep;
            DrawGround(100);
            DrawGround(100);
            DrawGround(100);

            Thread.Sleep(frameDelay);
            position += speed;
        }

        while (position > 0)
        {
            Console.Clear();

            DrawStar();

            if (leftStep)
            {
                DrawSprite(position);
            } else
            {
                DrawAltSprite(position);
            }
            leftStep = !leftStep;
            DrawGround(100);
            DrawGround(100);
            DrawGround(100);

            Thread.Sleep(frameDelay);
            position -= speed;
        }


    }
}