using UnityEngine;
using System.Collections;

namespace Actors
{
    public class AttackConcern : Concern
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

        }

        protected override void Update()
        {
            visualDetected = actor.detectionManager.detectVisual(target);
            if (visualDetected)
            {
                concernValue = 1000;
                attack();
            }
        }

        private void attack()
        {            
            actor.movementManager.stopAndFace(target.transform.position);
            actor.actionManager.attack();
        }

      

    }
}
