using System;
namespace GoogleChartsQR.net.Base
{
    public abstract class QRCodeBase : IQRBase
    {
        public int? Height { get; set; }

        public int? Width { get; set; }

        public string Render()
        {
            string data = GetData();

            Width = !Width.HasValue ? 177 : Width.Value;
            Height = !Height.HasValue ? 177 : Height.Value;

            if (string.IsNullOrEmpty(data))
            {
                throw new Exception("Data can not be empty!");
            }
            return string.Format("<img src=\"{0}\" alt=\"Google Charts QRCode\" height=\"{1}\" width=\"{2}\" style=\"height:'{1}px';width:'{1}px';\" />",
                 string.Format("http://chart.apis.google.com/chart?cht=qr&chs={0}x{1}&chl={2}&choe=UTF-8",
                                     Width,
                                     Height,
                                     System.Web.HttpUtility.UrlEncode(data)),
                 Height.Value,
                 Width.Value);
        }

        public abstract string GetData();
    }


}
