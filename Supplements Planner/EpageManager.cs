using FluentFTP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supplements_planner
{
    class EpageManager
    {
        private string host { get; set; }
        private int port { get; set; }
        private string user { get; set; }
        private string pass { get; set; }
        
        FtpClient ftp;

        public EpageManager(string host, int port, string user, string pass)
        {
            this.host = host;
            this.port = port;
            this.user = user;
            this.pass = pass;

            ftp = new FtpClient(host, port, user, pass);
        }

        public void Connect()
        {
            if (!ftp.IsConnected)
            {
                ftp.Connect();
            }
        }

        public static void DownloadSection(FtpEpaperSection sec)
        {
            Form1.errorMessage("DownloadSection() Not implemented yet");
        }

        
    }

    class FtpEpaperSection
    {
        public string nameShort { get; set; }
        public string nameLong { get; set; }
        public string zone { get; set; }
        public string section { get; set; }
        public string ftpFolder { get; set; }
        public int numPages { get; set; }
        public List<string> pdfFiles { get; set; }
        public List<string> xmlFiles { get; set; }
        public List<string> zipFiles { get; set; }
        public Bitmap frontPageImg { get; set; }
        public bool valid4page { get; set; }

        public FtpEpaperSection()
        {
            Console.WriteLine("Empty epaper created");
        }

        public FtpEpaperSection(string nameShort, string nameLong, string zone, string section, string ftpFolder, int numPages, List<string> pdfFiles, List<string> xmlFiles, List<string> zipFiles, Bitmap frontPageImg, bool valid4page)
        {
            Console.WriteLine("Populated epaper created");

            this.nameShort = nameShort;
            this.nameLong = nameLong;
            this.zone = zone;
            this.section = section;
            this.ftpFolder = ftpFolder;
            this.numPages = numPages;
            this.pdfFiles = pdfFiles;
            this.xmlFiles = xmlFiles;
            this.zipFiles = zipFiles;
            this.frontPageImg = frontPageImg;
            this.valid4page = valid4page;
        }
    }
}
