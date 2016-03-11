// Concern Manager
// 1 Actor -> 1 Concern Manager -> x Concern

using UnityEngine;
using System.Collections;

namespace Actors
{
    
    [System.Serializable]
    public class ConcernManager
    {
        // Variables - Inspector
        public GameObject target;


        // Variables - Other
        private Actor actor;
        public Concern currentConcern = null;
        private Concern newConcern;
        private Concern[] concerns = null;

        // Function - Constructor
        public void init(Actor actor)
        {
            this.actor = actor;
            concerns = GameObject.FindObjectsOfType<Concern>();
        }



        // Functions - Public
        public void runConcerns()
        {
            target = null;
            double concernPriority = 0;

            Concern tempConcern = null;
            if (concerns.Length != 0)
            {
                foreach (Concern concern in concerns)
                {     
                    double targetDistance = actor.movementManager.getDistance(concern.target);
                    double tempConcernPriority = concern.concernValue / targetDistance;
                   
                  
                    if (tempConcernPriority > concernPriority || tempConcern == null)
                    {
                        concernPriority = tempConcernPriority;
                        tempConcern = concern;
                    }
                }
                newConcern = tempConcern;

                if (currentConcern != newConcern)
                {
                    // Debug.Log("newcon" + currentConcern + " : " + newConcern + " : " + newConcern.concernValue);
                    currentConcern = newConcern;
                    target = currentConcern.target;    
                    currentConcern.reactToConcern();

                } else
                {
//                    currentConcern.destinationReaced();      
                }
                              
            }
        }
       

        // Functions - Private


    }
}