using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileSystem
            /*string[] filePath = Directory.GetFiles(@"C:\Lesson6", "*.js", SearchOption.AllDirectories);
            for (int i = 0; i < filePath.Length; i++)
            {
                Console.WriteLine(filePath[i]);
                Console.WriteLine(File.GetCreationTime(filePath[i]));
            }*/

            /*DirectoryInfo dir = new DirectoryInfo(@"C:\Lesson6");
            if (dir.Exists)
            {
                FileInfo[] fileInfo = dir.GetFiles("*.exe");
                for (int i = 0; i < fileInfo.Length; i++)
                {
                    Console.WriteLine(fileInfo[i].FullName);
                    Console.WriteLine(fileInfo[i].CreationTime);
                    Console.WriteLine(fileInfo[i].Length);
                    Console.WriteLine();
                }
            }*/

            /*FileInfo file3 = new FileInfo(@"C:\Lesson6\Test\1.txt");
            if (!file3.Directory.Exists)
            {
                file3.Directory.Create();
            }
            file3.Create();

            Directory.CreateDirectory(@"C:\Lesson6\1\2\3\4\5\6\7\8");*/

            /*string path1 = @"C:\Lesson6\1\2\3\sample.txt";
            Console.WriteLine(Path.GetFileName(path1));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path1));
            Console.WriteLine(Path.GetExtension(path1));
            Console.WriteLine(Path.GetDirectoryName(path1));

            string dir = @"C:\Lesson6\1\2\3";
            string temp = "18april";
            string fileName = "data.txt";

            string path = dir + "\\" + temp + "\\" + fileName;
            
            path = String.Format("{0}\\{1}\\{2}", dir, temp, fileName);
            Console.WriteLine(path);
            
            path = Path.Combine(dir, temp, fileName);*/
            
            #endregion

            Point p = new Point(10, 50, "Точка1");
            SaveTxt(p);

            Point p1 = LoadTxt();
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine(p1.label);
        }

        private static Point LoadTxt()
        {
            string path = @"C:\Lesson6\point.txt";
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            int x = int.Parse(reader.ReadLine());
            int y = int.Parse(reader.ReadLine());
            string label = reader.ReadLine();
            Point p = new Point(x, y, label);

            while (!reader.EndOfStream)
            {
                string str = reader.ReadLine();
            }

            string str2 = reader.ReadToEnd();


            reader.Close();
            return p;
        }

        private static void SaveTxt(Point p)
        {
            string path = @"C:\Lesson6\point.txt";
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(p.x);
            writer.WriteLine(p.y);
            writer.WriteLine(p.label);

            writer.Close();
        }
    }

    class Point
    {
        public int x;
        public int y;
        public string label;

        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }
    }
}
