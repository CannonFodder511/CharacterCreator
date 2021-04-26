using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Spell
    {
        #region "Keys"

        public String NAME_KEY = "SpellName";
        public String DESCRIPTION_KEY = "SpellDescription";
        public String LEVEL_KEY = "Level";
        public String DIE_KEY = "DamageDie";
        public String DIECOUNT_KEY = "DamageDieCount";
        public String DMGMOD_KEY = "DamageModifier";
        public String CHECK_KEY = "CastingModifier";
        public String UPCASTDIE_KEY = "UpCastDie";
        public String UPCASTDIECOUNT_KEY = "UpCastDieCount";
        public String UPCASTMOD_KEY = "UpCastDamageModifier";
        public String ROLLTOHIT_KEY = "RollToHit";

        #endregion

        #region "Properties"

        public String Name;
        public String Description;
        public int level;
        public int die;
        public int diecount;
        public int dmgMod;
        public bool rollToHit;
        public Common.Check check;
        public int upcastDie;
        public int upcastDiecount;
        public int upcastDmgMod;

        #endregion

        #region "Constructors"
        
        public Spell()
        {

        }

        public Spell(XElement x)
        {
            fromXML(x);
        }
        
        #endregion

        #region "XML"

        public XElement toXML()
        {
            XElement x = new XElement("Spell");
            x.Add(new XElement(NAME_KEY, Name));
            x.Add(new XElement(DESCRIPTION_KEY, Description));
            x.Add(new XElement(LEVEL_KEY, level));
            x.Add(new XElement(DIE_KEY, die));
            x.Add(new XElement(DIECOUNT_KEY, diecount));
            x.Add(new XElement(DMGMOD_KEY, dmgMod));
            x.Add(new XElement(CHECK_KEY, check));
            x.Add(new XElement(UPCASTDIE_KEY, upcastDie));
            x.Add(new XElement(UPCASTDIECOUNT_KEY, upcastDiecount));
            x.Add(new XElement(UPCASTMOD_KEY, upcastDmgMod));
            x.Add(new XElement(ROLLTOHIT_KEY, rollToHit));
            return x;
        }

        public void fromXML(XElement x)
        {
            Name = x.Element(NAME_KEY).Value.ToString();
            Description = x.Element(DESCRIPTION_KEY).Value.ToString();
            level = Int32.Parse(x.Element(LEVEL_KEY).Value);
            die = Int32.Parse(x.Element(DIE_KEY).Value);
            diecount = Int32.Parse(x.Element(DIECOUNT_KEY).Value);
            dmgMod = Int32.Parse(x.Element(DMGMOD_KEY).Value);
            Enum.Parse(typeof(Common.Check), x.Element(CHECK_KEY).Value);
            upcastDie = Int32.Parse(x.Element(UPCASTDIE_KEY).Value);
            upcastDiecount = Int32.Parse(x.Element(UPCASTDIECOUNT_KEY).Value);
            upcastDmgMod = Int32.Parse(x.Element(UPCASTMOD_KEY).Value);
            Boolean.Parse(x.Element(ROLLTOHIT_KEY).Value);
        }

        #endregion
    }
}
