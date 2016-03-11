using UnityEngine;
using System.Collections;

namespace Actors
{
    
    public class Concern : MonoBehaviour
    {
        // Inspector
        public GameObject target;
        public double concernValue = 0;
        public double concernMod = 0;
        // Skal laves mere custom

        // Other
        private Movement movement;
        protected Actor actor;
        [HideInInspector]
        public Vector3 targetLastPosition;


        // Functions - Mono
        private void Awake()
        {
            actor = GetComponentInParent<Actor>();
        }

        private void Start()
        {           
            updateConcernValue();    

        }

        protected virtual void Update()
        {           
        }

        // Functions - Public
        public virtual void reactToConcern()
        {           
        }

        // Functions - Private
        private void updateConcernValue()
        {            
            StartCoroutine(updateConcernTimer(1));
        }

        private IEnumerator updateConcernTimer(float time)
        {
            yield return new WaitForSeconds(time);
           
            concernValue = concernValue + concernMod;    
           

            updateConcernValue();
        }

        private IEnumerator setBusyTimer(float time)
        {          
            yield return new WaitForSeconds(time);
            actor.busy = false;
            concernValue = 0;
        }

        private void OnTriggerStay(Collider collider)
        {
            if (collider.gameObject == target)
            {
                concernValue = 0;

            }
        }
       


    }
}
