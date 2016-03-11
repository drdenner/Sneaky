using UnityEngine;
using System.Collections;

namespace Actors
{

    [System.Serializable]
    public class DetectionManager
    {
        // Variables - Inspector
        public Visual visual;

        // Variables - Others
        private Actor actor;


        public void init(Actor actor)
        {
            this.actor = actor;

        }

        // Functions - Public
        public bool detectVisual(GameObject target)
        {    
            bool visualDetected = visual.isDetected(actor, target); 
            return visualDetected;
        }

        // Functions - Private


       

    }
}

