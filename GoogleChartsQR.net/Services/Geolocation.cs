namespace GoogleChartsQR.net.Services
{
    public class Geolocation : Base.QRCodeBase, Base.IQRBase
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public override string GetData()
        {
            return string.Format("geo:{0},{1}", 
                Latitude, 
                Longitude);
        }
    }
}
