using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        #region "Properties"

        public Class cClass;
        public Race race;
        public List<Feat> feats;
        public List<Ability> abilities;
        public List<Item> items;
        public List<Spell> spells;

        public String name;
        public int level;
        public String pName;
        public String backstory;
        public String background;
        public String appearence;
        public List<String> languages;
        public Common.Allignment allignment;

        #endregion

        #region "Constructors"

        public Character()
        {

        }

        public Character(XElement c)
        {

        }

        #endregion

        #region "XML"

        public XElement toXML()
        {
            return new XElement("Character"); 
        }

        public void fromXML(XElement x)
        {
            
        }

        #endregion
    }
}
