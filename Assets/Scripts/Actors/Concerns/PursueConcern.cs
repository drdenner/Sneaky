using UnityEngine;
using System.Collections;

namespace Actors
{
    public class PursueConcern : Concern
    {
        // Variables - Private
        private bool visualDetected = false;
        
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


        protected override void Update()
        {
            visualDetected = actor.detectionManager.detectVisual(target);
            if (visualDetected)
            {
                concernValue = 1000;
            }
        }


    }
}
