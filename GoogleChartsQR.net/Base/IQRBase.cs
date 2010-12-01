namespace GoogleChartsQR.net.Base
{
    public interface IQRBase
    {
        string GetData();
        int? Height { get; set; }
        int? Width { get; set; }
        string Render();
    }
}
