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
        public static Dictionary<string, _File> files = new Dictionary<string, _File> { };
        public static Dictionary<string, _Folder> folders = new Dictionary<string, _Folder> { };
        public static List<string> Nfiles = new List<string> { };
        public static List<string> Nfolders = new List<string> { };



        public static void DirSearch(string sDir)
        {
            Nfiles = new List<string> { };
            Nfolders = new List<string> { };
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    try
                    {
                        var x = new _File(f);
                        if (!files.ContainsValue(x))
                        {
                            FileFunction.UINC++;

                            files.Add(FileFunction.UINC.ToString(), x);
                            Nfolders.Add(FileFunction.UINC.ToString());
                        }
                        else
                        {

                            string UIN = files.FirstOrDefault(files => files.Value == x).Key;
                            Nfiles.Add(UIN);
                        }



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
                        if (!folders.ContainsValue(x))
                        {
                            FileFunction.UINC++;

                            folders.Add(FileFunction.UINC.ToString(), x);
                            Nfolders.Add(FileFunction.UINC.ToString());
                        }
                        else
                        {

                            string UIN = folders.FirstOrDefault(folders => folders.Value == x).Key;
                            Nfolders.Add(UIN);
                        }
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
    public class Crawler
    {
        public static _ILst index = new _ILst();
        public static List<string> CDir = new List<string> { };

        public static void DirSearch(string sDir)
        {
            CDir = new List<string> { };
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    try
                    {
                        CDir.Add(index.Log(f, 0).ToString());
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
                        CDir.Add(index.Log(d, 1).ToString());
                    }
                    catch (Exception e)
                    {
                        System.Windows.Forms.MessageBox.Show("Access denied");
                    }
                }
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Access denied");
            }
        }
    }
    public class _Folder
    {
        public string Name { get; }
        public string FullLocation { get; }

        public _Folder(string folderpath)
        {
            FullLocation = folderpath;
            Name = Path.GetFileName(folderpath);
        }
    }
    public class _ILst {
        ulong UiC = 0;
        public _ILst()
        {

        }
        public ulong Indexed()
        {
            return UiC;
        }
        private List<_Index> index = new List<_Index> { };
        public _Index Get(string key)
        {
            foreach(_Index i in index)
            {
                if (i.UI.ToString() == key)
                {
                    return i;
                }
            }
            return null;
        }
        /// <summary>
        /// Gives the UI of that file/Folder
        /// </summary>
        /// <param name="iPath">Path of File/Folder</param>
        /// <param name="iType">
        /// Type:
        /// 0 - file,
        /// 1 - Folder</param>
        /// <returns></returns>
        public ulong Log(string iPath,short iType)
        {
            //Unique Identifier
            ulong UI = 0;
            //UI Valid
            bool UiV = false;
            foreach (_Index i in index)
            {
                if ((i.Type == 0) && (iType == 0)){
                    if(i.file.FullLocation == iPath)
                    {
                        UI = i.UI;
                        UiV = true;
                    }
                }
                else if ((i.Type == 1) && (iType == 1))
                {
                    if (i.folder.FullLocation == iPath)
                    {
                        UI = i.UI;
                        UiV = true;
                    }
                    
                }
            }
            
            if (!UiV)
            {
                UiC++;
                UI = UiC;
                if (iType == 0)
                {
                    index.Add(new _Index(UI, new _File(iPath)));
                }
                else if (iType == 1)
                {
                    index.Add(new _Index(UI, new _Folder(iPath)));
                }
                
            }
            return UI;
        }
    }
    public class _File
    {
        //Unique Identification Number (Future plans to speed up indexing)

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
        //Access Variables
        public DateTime Create { get; }
        public DateTime Lastaccess { get; }
        public DateTime Lastwrite { get; }
        //Size of file in bytes
        public ulong size { get; }

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

            FullLocation = filepath;
            Location = Directory.GetParent(filepath).ToString();
            Extension = Path.GetExtension(filepath);
            Name = Path.GetFileName(filepath);
            Create = File.GetCreationTimeUtc(filepath);
            Lastaccess = File.GetLastAccessTimeUtc(filepath);
            Lastwrite = File.GetLastWriteTimeUtc(filepath);
            
            size = Convert.ToUInt64(new FileInfo(filepath).Length);
            //var x = File.GetAttributes(filepath);
            //if(FileAttributes.ReadOnly == x){
            //    Tags.Add("RO");
            //}
            //if (FileAttributes.Hidden == x)
            //{
            //    Tags.Add("Hid");
            //}
            //if (FileAttributes.System == x)
            //{
            //    Tags.Add("Sys");
            //}
            //if (FileAttributes.Directory == x)
            //{
            //    Tags.Add("Sys");
            //}

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
        public ulong UI {get;set;}
        /// <summary>
        /// File/Folder
        /// </summary>
        public _File file { get; set; }
        public _Folder folder { get; set; }
        /// <summary>
        /// Type:
        /// 0 - File,
        /// 1 - Folder
        /// </summary>
        public short Type { get; set; }
        public _Index(ulong ui,_File f)
        {
            UI = ui;
            file = f;
            Type = 0;


        }
        public _Index(ulong ui, _Folder f)
        {
            UI= ui;
            folder = f;
            Type = 1;

        }
    }


}
