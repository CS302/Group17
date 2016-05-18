using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson10_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p = new Point(10, 15, "Первая точка");
            //XmlSerialization(p);

            Point p = XmlDeserialization();
            p.Print();
        }

        private static void XmlSerialization(Point p)
        {
            FileStream stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write);

            XmlSerializer serializer = new XmlSerializer(p.GetType());
            serializer.Serialize(stream, p); 

            stream.Close();
        }

        private static Point XmlDeserialization()
        {
            FileStream stream = new FileStream("data.xml", FileMode.Open, FileAccess.Read);
            Point p = new Point();

            XmlSerializer serializer = new XmlSerializer(p.GetType());

            p = (Point)serializer.Deserialize(stream);

            stream.Close();

            return p;
        }
    }

    [Serializable]
    public class Point
    {
        public int x;
        public int y;
        public string label;

        public Point()
        {   }

        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public void Print()
        {
            Console.WriteLine("label - {0}, x = {1}, y = {2}", label, x, y);
        }
    }
}
