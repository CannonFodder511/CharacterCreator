using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Class
    {
        #region "Values"

        public enum levelType
        {
            statUp,
            statUpOrFeat,
            feat,
            ability,
            spell
        }

        #endregion

        #region "Properties"

        public String name;
        public String description;
        public List<Common.Check> requiredStats;
        public List<int> requiredStatValues;
        public List<levelType> levelMap;
        public int hitDie;
        public int hitDiePerLevel;
        public Common.Check hpStat;
        public int hpDie;
        public int hpAvg;
        public int hpDiePerLevel;

        #endregion
    }
}
