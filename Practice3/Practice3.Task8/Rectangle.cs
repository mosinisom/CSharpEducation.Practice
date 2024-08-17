public struct Rectangle
{
    double Width;
    double Height;

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double CalcArea()
    {
        return Width * Height;
    }
}