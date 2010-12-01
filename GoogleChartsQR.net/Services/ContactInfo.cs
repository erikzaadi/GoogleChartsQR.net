namespace GoogleChartsQR.net.Services
{
    public class ContactInfo : Base.QRCodeBase, Base.IQRBase
    {
        public string FullName { get; set; }
        public string Url { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

        public override string GetData()
        {
            return string.Format("MECARD:N:{0};TEL:{1};URL:{2};EMAIL:{3};ADR:{4};NOTE:{5};;",
                FullName,
                Phone,
                Url,
                Email,
                Address,
                Note);
        }
    }
}
