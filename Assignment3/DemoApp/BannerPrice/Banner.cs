namespace BannerPrice;

 class Banner
{
    public float Width { get; set; }

    public float Height { get; set; }

    public Banner(float ww, float hh)
    {
        Width = ww;
        Height = hh;
    }
    public Banner()
    {
        Width = 20;
        Height = 15;
    }

    public virtual double BannerArea()
    {
        return Width * Height;
    }
}
