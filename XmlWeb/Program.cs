using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://www.liqpay.com/exchanges/exchanges.cgi");
            Stream stream = request.GetResponse().GetResponseStream();

            MoneyRates data = new MoneyRates();
            XmlSerializer searilizer = new XmlSerializer(data.GetType());
            data = (MoneyRates)searilizer.Deserialize(stream);
            stream.Close();

            double x = data.eur.RUR;
        }
    }

    [Serializable]
    [XmlRoot("rates")]
    public class MoneyRates
    {
        [XmlElement("EUR")]
        public Eur eur;

        [XmlElement("RUR")]
        public Rur rur;

        [XmlElement("UAH")]
        public Uah uah;

        [XmlElement("USD")]
        public Usd usd;
    }

    [Serializable]
    public class Eur
    {
        public double RUR;
        public double UAH;
        public double USD;
    }

    [Serializable]
    public class Rur
    {
        public double EUR;
        public double UAH;
        public double USD;
    }

    [Serializable]
    public class Uah
    {
        public double EUR;
        public double RUR;
        public double USD;
    }

    [Serializable]
    public class Usd
    {
        public double EUR;
        public double RUR;
        public double UAH;
    }
}
