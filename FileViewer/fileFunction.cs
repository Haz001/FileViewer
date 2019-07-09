using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace FileViewer
{
    public class FileFunction
    {
        public static ulong UINC = 1;
        public static string current_dir = "C:\\";
        public static List<_File> files = new List<_File> { };
        public static List<_Folder> folders = new List<_Folder> { };
        public static List<_File> Nfiles = new List<_File> { };
        public static List<_Folder> Nfolders = new List<_Folder> { };
        public static void DirSearch(string sDir)
        {
            Nfiles = new List<_File> { };
            Nfolders = new List<_Folder> { };
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    try
                    {
                        var x = new _File(f);
                        if (!files.Contains(x))
                        {
                            files.Add(x);
                        }
                        Nfiles.Add(x);


                    }
                    catch (Exception e)
                    {

                        System.Windows.Forms.MessageBox.Show("Access denied");
                    }

                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    try
                    {
                        var x = new _Folder(d);
                        if (!folders.Contains(x))
                        {
                            folders.Add(x);
                        }
                        Nfolders.Add(x);
                        //files.AddRange(DirSearch(d));
                    }
                    catch (Exception e)
                    {

                        System.Windows.Forms.MessageBox.Show("access denied");
                    }
                }
            }
            catch (Exception)
            {

                System.Windows.Forms.MessageBox.Show("access denied");
           
            

            }
            

        }
    }
    public class _Folder
    {
        public string Name { get; }
        public string Location { get; }
        public string FullLocation { get; }
        public ulong UIN { get; }
        public _Folder(string folderpath)
        {
            FileFunction.UINC++;
            UIN = FileFunction.UINC;
            FullLocation = folderpath;
            Name = Path.GetFileName(folderpath);
            Location = Path.GetFileName(Path.GetDirectoryName(folderpath));

        }
    }
    public class _File
    {
        //Unique Identification Number (Future plans to speed up indexing)
        public ulong UIN { get; }
        //Name Of File E.G. C:\file.txt -> file
        public string Name { get; }
        //Path Of file E.G. C:\file.txt -> C:\
        public string Location { get; }
        //Full path of file E.G. C:\file.txt -> C:\file.txt
        public string FullLocation { get; }
        //Extension it has, E.G. C:\file.txt -> txt
        public string Extension { get; }
        //Tags the file has
        public List<string> Tags { get; }
        //Number corosponding to type, Future plans
        /// <summary>
        /// 0 - binary
        /// 1 - image
        /// 2 - text
        /// 3 - zip
        /// 4 - document
        /// </summary>
        public short Type { get; set; }
        public _File(string filepath)
        {
            FileFunction.UINC++;
            UIN = FileFunction.UINC;
            FullLocation = filepath;
            Location = Path.GetPathRoot(filepath);
            Extension = Path.GetExtension(filepath);
            Name = Path.GetFileName(filepath);
            var x = File.GetAttributes(filepath);
            if(FileAttributes.ReadOnly == x){
                Tags.Add("RO");
            }
            if (FileAttributes.Hidden == x)
            {
                Tags.Add("Hid");
            }
            if (FileAttributes.System == x)
            {
                Tags.Add("Sys");
            }
            if (FileAttributes.Directory == x)
            {
                Tags.Add("Sys");
            }
            
        }
    }
    public class Other
    {
        public static Bitmap Blur(Bitmap image, Int32 blurSize)
        {
            return Blur(image, new Rectangle(0, 0, image.Width, image.Height), blurSize);
        }

        private static Bitmap Blur(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the blur rectangle
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (int x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (int x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                        for (int y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                }
            }

            return blurred;
        }
    }
    public class _Index {
        /// <summary>
        /// Unique Identifiyer Number
        /// </summary>
        public ulong UIN {get;set;}
        /// <summary>
        /// Name Of File
        /// </summary>
        public string Name {get;set;}
        /// <summary>
        /// Type
        /// </summary>
        public short Type { get; set; }
        public _Index(ulong uin,string name,short type)
        {
            UIN = uin;
            Name = name;
            Type = type;

        }
    }


}
