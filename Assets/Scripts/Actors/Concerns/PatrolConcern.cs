using UnityEngine;
using System.Collections;

namespace Actors
{
    public class PatrolConcern : Concern
    {
        // Functions - Public
        public override void reactToConcern()
        {
            reaction();
        }

        // Functions - Private
        private void reaction()
        {
            actor.movementManager.moveToTarget(target.transform.position);
        }






    }
}
