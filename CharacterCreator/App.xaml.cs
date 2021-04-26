using System;
using System.IO;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CharacterCreator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public List<Datapack> datapacks;

        public App()
        {
            datapacks = new List<Datapack>();
            DirectoryInfo install = checkInstall();
            DirectoryInfo[] sourceFolder = install.GetDirectories("Data");
            if (!loadSources(sourceFolder[0]))
            {
                string warning = "No Datapacks are loaded. Place datapacks in the \"Data\" folder.";
                MessageBoxButton mbb = MessageBoxButton.OK;
                MessageBoxImage mbi = MessageBoxImage.Warning;
                //MessageBoxResult result = MessageBox.Show(warning, "", mbb, mbi);
            }
        }

        public static DirectoryInfo checkInstall()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CharacterCreator";
            DirectoryInfo install = Directory.CreateDirectory(path);
            install.CreateSubdirectory("Data");
            install.CreateSubdirectory("Characters");
            return install;
        }

        public bool loadSources(DirectoryInfo install)
        {
            FileInfo[] data = install.GetFiles();
            foreach(FileInfo i in data)
            {
                StreamReader dataStream = i.OpenText();
                XElement x = XElement.Parse(dataStream.ReadToEnd());
                datapacks.Add(new Datapack(x));
            }

            return data.Length != 0;
        }
    }
}
