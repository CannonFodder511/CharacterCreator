using System;
using System.IO;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Common
    { 
        public enum Allignment
        {
            LawfulGood,
            NeutralGood,
            ChaoticGood,
            LawfulNeutral,
            TrueNeutral,
            ChaoticNeutral,
            LawfulEvil,
            NeutralEvil,
            ChaoticEvil
        }

        public enum Check
        {
            strength,
            dexterity,
            constitution,
            intelligence,
            wisdom,
            charisma
        }

        public enum Size
        {
            xsmall,
            small,
            medium,
            large,
            xlarge
        }

        public static int Roll(int die, int dieCount, int mod)
        {
            int sum = mod;
            Random ran = new Random();
            for(int i = 0; i < dieCount; i++)
            {
                sum += ran.Next(die) + 1;
            }

            return sum;
        }

        public static void SaveCharacter(Character c)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "XML Files (*.xml)|*.xml";
            s.FilterIndex = 0;
            s.RestoreDirectory = true;
            if(s.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(s.FileName, c.toXML().ToString());
            }
        }

        public static XElement LoadFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            String filePath = string.Empty;
            String fileContent = string.Empty;
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }

            XElement x = XElement.Parse(fileContent);
            return x;
        }
    }
}
