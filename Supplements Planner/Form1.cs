using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FluentFTP;

namespace supplements_planner
{
    public partial class Form1 : Form
    {

        string XMLdestinationDir, ftpHost, ftpUser, ftpPass;
        int ftpPort;
        XmlDocument settings, destinationList;
        FtpClient ftp;
        FtpListItem[] ftpList;
        List<FtpListItem[]> sections;
        List<string> ftpDestinations;
        public static string imageFolder { get; set; }

        public  Form1()
        {
            InitializeComponent();
            loadSettings();
            UpdateDestinations();
            FillDestinationDropdown();

            EpageManager epm = new EpageManager(ftpHost, ftpPort, ftpUser, ftpPass);
            //imageFolder = "bla";
        }

        public void loadSettings()
        {
            //XMLdestinationDir = @"XML-out\";

            settings = new XmlDocument();
            settings.Load("settings.xml");

            destinationList = new XmlDocument();
            destinationList.Load("destinations.xml");

            XMLdestinationDir = settings.SelectSingleNode("//settings/XMLDestinationDir").InnerText;

            ftpHost = settings.SelectSingleNode("//settings/ftpserver").InnerText;
            ftpPort = int.Parse(settings.SelectSingleNode("//settings/port").InnerText);
            ftpUser = settings.SelectSingleNode("//settings/username").InnerText;
            ftpPass = settings.SelectSingleNode("//settings/password").InnerText;
            ftp = new FtpClient(ftpHost, ftpPort, ftpUser, ftpPass);

            imageFolder = settings.SelectSingleNode("//settings/ImageFolder").InnerText;
        }

        public void FillDestinationDropdown()
        {
            foreach(XmlNode n in destinationList.SelectNodes("//destinations/destination"))
            {
                destDropdown.Items.Add(n.InnerText);
            }
        }

        public void UpdateDestinations()
        {
            ftp.Connect();
            Console.WriteLine("Connected to " + ftpHost);
            ftpList = ftp.GetListing();
            Console.WriteLine("Retrieved list with " + ftpList.Length + " FTP items");

            ftpDestinations = new List<string>();

            foreach (FtpListItem i in ftpList)
            {
                if (i.Name.Length == 3 && i.Type == FtpFileSystemObjectType.Directory)
                {
                    ftpDestinations.Add(i.Name);
                }
            }

            Console.WriteLine("Active products on FTP: " + ftpDestinations.Count);
            ftpDestinations.Sort();

            Console.WriteLine("Updating destination list");
            XmlNode node;

            foreach (string s in ftpDestinations)
            {
                node = destinationList.DocumentElement.SelectSingleNode("//destinations/destination[@code='" + s + "']");

                if(node == null)
                {
                    // FTP folder not in XML list
                    XmlNode newDestinationdNode = destinationList.CreateElement("destination");
                    XmlAttribute code = destinationList.CreateAttribute("code");
                    code.InnerText = s;
                    newDestinationdNode.Attributes.Append(code);
                    XmlNode newDisplayNameNode = destinationList.CreateElement("displayname");
                    newDisplayNameNode.InnerText = s;
                    newDestinationdNode.AppendChild(newDisplayNameNode);
                    destinationList.SelectSingleNode("//destinations").AppendChild(newDestinationdNode);
                    destinationList.Save("destinations.xml");
                } else
                {
                    // FTP folder already in XML list
                }
            }

        }

        public void GenerateXML(string filename, string sourceProd, string sourceZone, string date, string title, string[] destinations)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("template.xml");

            XmlNode titleNode = xmlDoc.SelectSingleNode("//publication_meta/title");
            titleNode.InnerText = title;

            XmlNode relatedNode = xmlDoc.SelectSingleNode("//publication_meta/related_titles");
            foreach(string s in destinations)
            {
                XmlNode n = xmlDoc.CreateElement("title_code");
                n.InnerText = s;
                relatedNode.AppendChild(n);
            }

            xmlDoc.Save(@"XML\" + filename);
        }

        public void addDestination(string dest)
        {
            XmlNode node = destinationList.DocumentElement.SelectSingleNode("//destinations/destination[@code='"+dest+"']");

            if(node != null)
            {
                string dispName = node.InnerText;

                if (!this.destListbox.Items.Contains(dispName))
                {
                    this.destListbox.Items.Add(dispName);
                    return;
                }
            }
            else
            {
                if (!this.destListbox.Items.Contains(dest))
                {
                    this.destListbox.Items.Add(dest);
                    return;
                }
            }

            errorMessage(dest + " already in list");

        }

        public void clearDestinationList()
        {
            this.destListbox.Items.Clear();
        }

        public static void errorMessage(string error)
        {
            MessageBox.Show(error, "Error!");
        }

        public void removeDestination(string dest)
        {
            if (this.destListbox.Items.Contains(dest))
            {
                this.destListbox.Items.Remove(dest);
            }
        }

        private void destListbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                removeDestination(destListbox.GetItemText(destListbox.SelectedItem));
            }
        }

        private void GetSectionsInFtpFolder(string ftpFolder)
        {
            FtpListItem[] list = ftp.GetListing(ftpFolder);
            FtpListItem[] listXML = ftp.GetListing(ftpFolder+"\\XML");
            List<string> sectionsInFolder = new List<string>();
            
            // Check for PDF frontpages and make a list
            foreach(FtpListItem item in list)
            {
                if(item.Type == FtpFileSystemObjectType.File)
                {
                    if (item.Name.EndsWith("001.pdf"))
                    {
                        string s = item.Name.Split(new string[] { "001.pdf" }, StringSplitOptions.None)[0];

                        if (!sectionsInFolder.Contains(s))
                        {
                            sectionsInFolder.Add(s);
                            Console.WriteLine(s + " added to local list");
                        } else
                        {
                            Console.WriteLine(s + " already in list");
                        }                        
                    }
                }
            }

            // Create the FtpEpaperSection for each item in the list
            foreach(string sec in sectionsInFolder)
            {
                string nameShort = sec.Substring(0, 3);
                string nameLong = GetLongName(nameShort);
                string zone = sec.Substring(14, 1);
                string section = sec.Substring(17, 1);
                //string ftpFolder; // We have this as an argument already
                int numPages;
                List<string> pdfFiles = new List<string>();
                List<string> xmlFiles = new List<string>();
                List<string> zipFiles = new List<string>();
                Bitmap frontPageImg;
                bool valid4page;

                string frontPageFileName = "";

                // Get PDF files
                foreach (FtpListItem item in list)
                {
                    if (item.Type == FtpFileSystemObjectType.File)
                    {
                        if (item.Name.StartsWith(sec))
                        {
                            if (item.Name.EndsWith(".pdf"))
                            {
                                pdfFiles.Add(item.Name);
                                if (item.Name.EndsWith("001.pdf"))
                                {
                                    frontPageFileName = item.Name;
                                    ftp.DownloadFile(imageFolder+ frontPageFileName, ftpFolder +"\\"+ frontPageFileName);
                                }
                            }
                        }                        
                    }
                }

                // Get XML and ZIP files
                foreach (FtpListItem item in listXML)
                {
                    if (item.Type == FtpFileSystemObjectType.File)
                    {
                        if (item.Name.StartsWith(sec))
                        {
                            if (item.Name.EndsWith(".xml"))
                            {
                                xmlFiles.Add(item.Name);
                            }

                            if (item.Name.EndsWith(".zip"))
                            {
                                zipFiles.Add(item.Name);
                            }
                        }
                    }
                }

                numPages = pdfFiles.Count;
                valid4page = numPages % 4 == 0;

                GenerateFrontpageImg(imageFolder+frontPageFileName);
                frontPageImg = new Bitmap(imageFolder + sec + "001.png");
                
                FtpEpaperSection newSection = new FtpEpaperSection(nameShort, nameLong, zone, section,ftpFolder, numPages, pdfFiles, xmlFiles, zipFiles, frontPageImg, valid4page);
                
            }
            
        }

        public void GenerateFrontpageImg(string pdfFile)
        {
            string pngFile = pdfFile.Split('.')[0] + ".png";
            List<string> errors = cs_pdf_to_image.Pdf2Image.Convert(pdfFile, pngFile);
        }

        private string GetLongName(string shortName)
        {
            return "";
        }

        #region Buttons

        private void addButton_Click(object sender, EventArgs e)
        {
            if(destDropdown.SelectedItem != null)
            {
                addDestination(destDropdown.SelectedItem.ToString());
            }
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearDestinationList();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string sourceProd = prodInput.Text.ToUpper();
            string sourceZone = zoneInput.Text.ToUpper();
            string date = sourceDate.Text;
            date = date.Substring(0, 2) + date.Substring(3, 2) + date.Substring(8, 2);
            string title = sourceTitle.Text.ToUpper();
            title.Replace("Æ", "AE");
            title.Replace("Ø", "OE");
            title.Replace("Å", "AA");
            string[] destinations = destListbox.Items.OfType<string>().ToArray();

            for(int i = 0; i<destinations.Length; i++)
            {
                destinations[i] = destinations[i].Substring(0, 3);
            }

            string filename = sourceProd + "JFM0T" + date + sourceZone + "11A.xml";

            GenerateXML(filename, sourceProd, sourceZone, date, title, destinations);

            string sourceFile = @"XML\" + filename;
            string destinationFile = XMLdestinationDir + filename;
            
            File.Copy(sourceFile, destinationFile, true);
            File.Delete(sourceFile);

            MessageBox.Show("XML afsendt!");
        }

        private void but_FST_Click(object sender, EventArgs e)
        {
            addDestination("FST");
        }

        private void but_FAA_Click(object sender, EventArgs e)
        {
            addDestination("FAA");
        }

        private void but_JVE_Click(object sender, EventArgs e)
        {
            addDestination("SDR - JV Soenderborg");
            addDestination("BIL - JV Billund");
            addDestination("VAR - JV Varde");
            addDestination("ESB - JV Esbjerg");
            addDestination("HAD - JV Haderslev");
            addDestination("KOL - JV Kolding");
            addDestination("TON - JV Toender");
            addDestination("AAB - JV Aabenraa");
            addDestination("VEJ - JV Vejen");
        }

        private void but_HOF_Click(object sender, EventArgs e)
        {
            addDestination("HOF - Horsens Folkeblad");
        }

        private void but_VAF_Click(object sender, EventArgs e)
        {
            addDestination("VAF - Vejle Amts Folkeblad");
        }

        private void but_FRD_Click(object sender, EventArgs e)
        {
            addDestination("FRD - Fredericia Dagblad");
        }

        private void but_RAM_Click(object sender, EventArgs e)
        {
            addDestination("RAM - Randers Amtsavis");
        }

        private void but_AAS_Click(object sender, EventArgs e)
        {
            addDestination("AAS - Aarhus Stiftstidende");
        }

        private void but_DHS_Click(object sender, EventArgs e)
        {
            addDestination("DHS - Dagbladet Holstebro");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine(tabControl1.SelectedTab.Text+" tab selected");

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabSupplements":
                    break;
                case "tabDownload":
                    GetSectionsInFtpFolder("UAN");
                    break;
                case "tabUpload":
                    break;
                default:
                    break;

            }
        }

        private void but_VSF_Click(object sender, EventArgs e)
        {
            addDestination("VSF - Viborg Stifts Folkeblad");
        }

        private void but_DRS_Click(object sender, EventArgs e)
        {
            addDestination("DRS - Dagbladet Ringkøbing Skjern");
        }

        private void but_LEF_Click(object sender, EventArgs e)
        {
            addDestination("LEF - Lemvig Folkeblad");
        }

        private void but_DST_Click(object sender, EventArgs e)
        {
            addDestination("DST - Dagbladet Struer");
        }

        #endregion

        
    }
}
