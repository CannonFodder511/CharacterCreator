using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Race
    {
        #region "Properties"

        public String name;
        public String description;
        public bool giveSpell;
        public List<String> spells;
        public bool giveAbility;
        public List<String> abilities;
        public List<Common.Check> statUp;
        public List<int> statChange;
        public int speed;
        public Common.Size size;

        #endregion

        #region "Constructors"

        public Race()
        {

        }

        public Race(XElement x)
        {
            fromXML(x);
        }

        #endregion

        #region "XML"

        /*public XElement toXML()
        {

        }*/

        public void fromXML(XElement x)
        {

        }

        #endregion
    }
}
