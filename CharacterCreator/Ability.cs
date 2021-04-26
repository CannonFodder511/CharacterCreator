using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Ability
    {
        #region "Keys"

        public String MAXUSE_KEY = "MaximumUses";
        public String LONGREST_KEY = "ResetOnLongRest";
        public String SHORTREST_KEY = "ResetOnShortRest";
        public String DESCRIPTION_KEY = "Description";
        public String NAME_KEY = "Name";
        public String SOURCE_KEY = "Source";

        #endregion

        #region "Properties"

        public int useCount;
        public int maxUse;
        public bool longRest;
        public bool shortRest;
        public String description;
        public String name;
        public String source;

        #endregion

        #region "Constructors"

        public Ability()
        {

        }

        public Ability(XElement x)
        {
            fromXML(x);
        }

        #endregion

        #region "XML"

        public XElement toXML()
        {
            XElement x = new XElement("Ability");
            x.Add(new XElement(MAXUSE_KEY, maxUse));
            x.Add(new XElement(LONGREST_KEY, longRest));
            x.Add(new XElement(SHORTREST_KEY, shortRest));
            x.Add(new XElement(DESCRIPTION_KEY, description));
            x.Add(new XElement(NAME_KEY, name));
            x.Add(new XElement(SOURCE_KEY, source));

            return x;
        }

        public void fromXML(XElement x)
        {

        }

        #endregion
    }
}
