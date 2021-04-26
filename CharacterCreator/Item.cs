using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Item
    {
        #region "Keys"

        public String COUNT_KEY = "ItemCount";
        public String COST_KEY = "CostInCopper";
        public String WEIGHT_KEY = "weight";
        public String ISWEAPON_KEY = "IsWeapon";
        public String ISARMOR_KEY = "IsArmor";
        public String AC_KEY = "AC";
        public String MINRANGE_KEY = "MinimumRange";
        public String MAXRANGE_KEY = "MaximumRange";
        public String CHECK_KEY = "WeaponModifier";
        public String DIE_KEY = "WeaponDie";
        public String DIECOUNT_KEY = "WeaponDieCount";
        public String DESCRIPTION_KEY = "Description";
        public String NAME_KEY = "Name";
        public String CANEQUIP_KEY = "CanBeEquipped";
        public String EQUIPPED_KEY = "IsEquipped";

        #endregion

        #region "Properties"

        public bool canEquip;
        public bool equipped;
        public int count;
        public int cost;
        public double weight;
        public bool isWeapon;
        public bool isArmor;
        public int ac;
        public int minrange;
        public int maxrange;
        public Common.Check check;
        public int die;
        public int dieCount;
        public String description;
        public String name;

        #endregion

        #region "Constructors"

        public Item()
        {

        }

        public Item(XElement x)
        {
            fromXML(x);
        }

        #endregion

        #region "XML"

        public XElement toXML()
        {
            XElement x = new XElement("Item");
            x.Add(new XElement(COUNT_KEY, count));
            x.Add(new XElement(COST_KEY, cost));
            x.Add(new XElement(WEIGHT_KEY, weight));
            x.Add(new XElement(ISWEAPON_KEY, isWeapon));
            x.Add(new XElement(ISARMOR_KEY, isArmor));
            x.Add(new XElement(AC_KEY, ac));
            x.Add(new XElement(MINRANGE_KEY, minrange));
            x.Add(new XElement(MAXRANGE_KEY, maxrange));
            x.Add(new XElement(CHECK_KEY, check));
            x.Add(new XElement(DIE_KEY, die));
            x.Add(new XElement(DIECOUNT_KEY, dieCount));
            x.Add(new XElement(DESCRIPTION_KEY, description));
            x.Add(new XElement(NAME_KEY, name));
            x.Add(new XElement(CANEQUIP_KEY, canEquip));
            x.Add(new XElement(EQUIPPED_KEY, equipped));

            return x;
        }

        public void fromXML(XElement x)
        {

        }

        #endregion
    }
}
