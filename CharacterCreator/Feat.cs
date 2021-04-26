using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Feat
    {
        #region "Keys"

        public String NAME_KEY = "Name";
        public String DESCRIPTION_KEY = "Description";
        public String CLASSES_KEY = "ApplicableClasses";
        public String STATCHANGE_KEY = "ChangesStat";
        public String STATUP_KEY = "ChangedStats";
        public String STATINCRESE_KEY = "StatIncreases";
        public String GIVESPELL_KEY = "GivesSpell";
        public String SPELLS_KEY = "Spells";
        public String GIVEABILITY_KEY = "GivesAbility";
        public String ABILITIES_KEY = "Abilities";

        #endregion

        #region "Properties"

        public String name;
        public String description;
        public List<String> classes;
        public bool statChange;
        public List<Common.Check> statUp;
        public List<int> statIncrease;
        public bool giveSpell;
        public List<String> spells;
        public bool giveAbility;
        public List<String> abilities;

        #endregion

        #region "Constructors"

        public Feat()
        {

        }

        public Feat(XElement x)
        {
            fromXML(x);
        }

        #endregion

        #region "XML"

        public XElement toXML()
        {
            XElement x = new XElement("Feat");
            x.Add(new XElement(NAME_KEY, name));
            x.Add(new XElement(DESCRIPTION_KEY, description));
            x.Add(new XElement(CLASSES_KEY, classes));
            x.Add(new XElement(STATCHANGE_KEY, statChange));
            x.Add(new XElement(STATUP_KEY, statUp));
            x.Add(new XElement(STATINCRESE_KEY, statIncrease));
            x.Add(new XElement(GIVESPELL_KEY, giveSpell));
            x.Add(new XElement(SPELLS_KEY, spells));
            x.Add(new XElement(GIVEABILITY_KEY, giveAbility));
            x.Add(new XElement(ABILITIES_KEY, abilities));

            return x;
        }

        public void fromXML(XElement x)
        {

        }

        #endregion
    }
}
