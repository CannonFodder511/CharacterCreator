using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Datapack
    {
        #region "Properties"

        public List<Spell> spells;
        public List<Ability> abilities;
        public List<Class> classes;
        public List<Item> items;
        public List<Feat> feats;
        public List<Race> races;
        public String name;
        public String NAME_KEY = "SourceName";
        
        #endregion

        #region "Constructors"

        public Datapack()
        {
            spells = new List<Spell>();
            abilities = new List<Ability>();
            classes = new List<Class>();
            items = new List<Item>();
            feats = new List<Feat>();
            races = new List<Race>();
        }

        public Datapack(XElement x)
        {
            spells = new List<Spell>();
            abilities = new List<Ability>();
            classes = new List<Class>();
            items = new List<Item>();
            feats = new List<Feat>();
            races = new List<Race>();
            fromXML(x);
        }

        #endregion

        #region "XML"

        public void fromXML(XElement x)
        {
            foreach(XElement e in x.Elements())
            {
                if(e.Name.ToString().Equals("Spell")){
                    spells.Add(new Spell(e));
                }else if (e.Name.ToString().Equals("Ability"))
                {
                    abilities.Add(new Ability(e));
                }/*else if (e.Name.Equals("Class"))
                {
                    classes.Add(new Class(e));
                }*/else if (e.Name.ToString().Equals("Item"))
                {
                    items.Add(new Item(e));
                }else if (e.Name.ToString().Equals("Feat"))
                {
                    feats.Add(new Feat(e));
                }else if (e.Name.ToString().Equals("Race"))
                {
                    races.Add(new Race(e));
                }
                else
                {
                    name = e.Value.Trim();
                }
            }
        }

        #endregion
    }
}
