using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4H1_WeilandR
{
    class MobileObject
    {
        public int _HP = 0;
        public int _AC = 0;
        public int _AB = 0;
        public int _DMG = 0;

        //Constructor
        public MobileObject(int HP, int AC, int AB, int DMG)
        {
            _HP = HP;
            _AC = AC;
            _AB = AB;
            _DMG = DMG;
        }

        public void OnSpawn()
        {

        }

        public void OnCombatStart()
        {

        }

        public void OnDeath()
        {

        }
    }
}
