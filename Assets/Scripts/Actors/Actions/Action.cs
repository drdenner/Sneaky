using UnityEngine;
using System.Collections;

namespace Actors
{
    public class Action : MonoBehaviour
    {
        // Variables - Inspector

        // Variables - Other
        private Actor actor;
        public bool isReady = true;

        // Functions - Mono
        private void Awake()
        {
            actor = GetComponentInParent<Actor>();
            init();
        }

        // Functions - Public
        public virtual void activate()
        {            
        }

        protected virtual void init()
        {
        }

      

   
    }
}