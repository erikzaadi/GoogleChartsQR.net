namespace GoogleChartsQR.net.Services
{
    public class Basic : Base.QRCodeBase, Base.IQRBase
    {
        public string Content { get; set; }

        public override string GetData()
        {
            return Content;
        }
    }
}
