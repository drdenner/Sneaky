using UnityEngine;
using System.Collections;

namespace Actors
{
    [System.Serializable]
    public class Visual
    {
        // Variables - Inspector
        public float fieldOfViewAngle = 90.0f;
        public bool hasSight;
        public float sightRange = 100f;

        // Variables - Other
        private Actor actor;

        // Function - Conctructor
        public void init(Actor actor)
        {
            this.actor = actor;
        }

        // Functions - Public
        public bool isDetected(Actor actor, GameObject target)
        {        
            bool isDetected = false;
            Vector3 direction = target.transform.position - actor.transform.position;
            float angle = Vector3.Angle(direction, actor.transform.forward);

            if (angle < fieldOfViewAngle * 0.5f)
            {
                RaycastHit hit;
                if (Physics.Raycast(actor.gameObject.transform.position + actor.gameObject.transform.up, direction.normalized, out hit, sightRange))
                {
                    if (hit.collider.tag == "Player")
                    {
                        isDetected = true;
                    }
                }
            } 

            return  isDetected;
        }
    }
}