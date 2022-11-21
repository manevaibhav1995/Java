namespace BannerPrice;

class CurveBanner : Banner
{
    public float Radius { get; set; }

    public CurveBanner(float ww, float hh, float rr) : base(ww, hh)
    {
        Radius = rr;
    }
    public CurveBanner()
    {
        Radius = 0.2f;
    }
    public override double BannerArea()
    {

        return base.BannerArea() - 0.086 * Radius * Radius;

    }

}