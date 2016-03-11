using UnityEngine;
using System.Collections;

namespace Actors
{
    [System.Serializable]
    public class AnimationManager
    {
        private Actor actor;

        // Function - Constructor
        public void init(Actor actor)
        {
            this.actor = actor;
        }
	
        // Functions - Public
        public void setAnimation()
        {
            
        }

        // Functions - Private
    }
}