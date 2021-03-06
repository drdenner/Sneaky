﻿using UnityEngine;
using System.Collections;

namespace Actors
{
    [System.Serializable]
    public class MovementManager
    {


        // Variables - Private
        private Actor actor;


        // Function - Constructor
        public void init(Actor actor)
        {
            this.actor = actor;


        }

        // Functions - Public
        public double getDistance(GameObject target)
        {
            double distance = 9000.0;
            if (checkPath(target))
            {             
                distance = (double)Vector3.Distance(actor.gameObject.transform.position, target.transform.position);
            }
            return distance;
        }

        public void moveToTarget(Vector3 targetPosition)
        {
            actor.navMeshAgent.SetDestination(targetPosition);
        }

        public void stopAndFace(Vector3 faceDirection)
        {            
            actor.navMeshAgent.ResetPath();
            actor.transform.LookAt(faceDirection);
        }


        // Functions - Private
        private bool checkPath(GameObject target)
        {
            return true;
        }


    }
}

 
 
 