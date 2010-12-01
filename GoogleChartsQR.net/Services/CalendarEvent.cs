using System;

namespace GoogleChartsQR.net.Services
{
    public class CalendarEvent : Base.QRCodeBase, Base.IQRBase
    {
        public bool AllDay { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string GetData()
        {
            return string.Format("BEGIN:VEVENT\nSUMMARY:{0}\nDTSTART:{1}\nDTEND:{2}\nEND:VEVENT",
                Title,
                getDateString(StartDate),
                getDateString(EndDate)); 
        }

        private string getDateString(DateTime date)
        {
            return AllDay ?  date.ToString("yyyyMM") : date.ToString("yyyyMMTHHmmz");
        }
    }
}
