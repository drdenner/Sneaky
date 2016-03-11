using UnityEngine;
using System.Collections;

namespace Actors
{
    public class WeaponAction : Action
    {
        // Variables - Inspector
        public GameObject weapon;

        // Variables - Other
        private Items.Weapons.Weapon weaponScript;

        // Functions - Constructor
        protected override void init()
        {
            weaponScript = weapon.GetComponent<Items.Weapons.Weapon>();
        }

        // Functions - Public
        public override void activate()
        {
            weaponScript.activate();
        }

    }
}
