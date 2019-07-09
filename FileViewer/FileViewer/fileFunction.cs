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
        public static List<_File> files = new List<_File> { };
        public static void DirSearch(string sDir)
        {
            

            foreach (string f in Directory.GetFiles(sDir))
            {
                try
                {

                    files.Add(new _File(f));
                }
                catch (Exception e)
                {

                    //System.Windows.Forms.MessageBox.Show("Access denied");
                }

            }
            foreach (string d in Directory.GetDirectories(sDir))
            {
                try
                {
                    //files.AddRange(DirSearch(d));
                    
                }
                catch (Exception e)
                {

                    //System.Windows.Forms.MessageBox.Show("access denied");
                }

            }
            

        }
    }
    public class _File
    {
        //Unique Identification Number (Future plans to speed up indexing)
        public int[] UIN { get; }
        //Name Of File E.G. C:\file.txt -> file
        public string Name { get; set; }
        //Path Of file E.G. C:\file.txt -> C:\
        public string Location { get; }
        //Full path of file E.G. C:\file.txt -> C:\file.txt
        public string FullLocation { get; }
        //Extension it has, E.G. C:\file.txt -> txt
        public string Extension { get; set; }
        //Tags the file has
        public List<string> Tags { get; set; }
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
}
