using UnityEngine;
using System.Collections;

namespace Actors
{
    [System.Serializable]
    public class ActionManager
    {


        // Variables - Others
        private Managers.PoolObject PoolObject;
        private Actor actor;
        private Action[] actions;

        // Function - Constructor
        public void init(Actor actor)
        {
            this.actor = actor;
            actions = GameObject.FindObjectsOfType<Action>();
        }

        public void attack()
        {            
            if (actions.Length != 0)
            {
                foreach (Action action in actions)
                {
                    if (action.isReady)
                    {
                        action.activate();
                        break;
                    }
                }

            
            
            }

        }



    }
}
