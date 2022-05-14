public class Rectangle
{
    public int Lenght { get; set; }
    public int Breadth { get; set; }
    public int Height { get; set; }

    public Rectangle()
    {
        
    }

    public Rectangle(int lenght, int breadth, int height)
    {
        this.Lenght = lenght;
        this.Breadth = breadth;
        this.Height = height;
    }

    public static Rectangle operator+ (Rectangle b, Rectangle c)
    {
        Rectangle a = new Rectangle();
        a.Lenght = b.Lenght + c.Lenght;
        a.Breadth = b.Breadth + c.Breadth;
        a.Height = b.Height + c.Height;
        return a;
    }

}

