using UnityEngine;
using System.Collections;

namespace Actors
{
    public class Actor : MonoBehaviour
    {
        // Variables - Inspector
        public decimal hostilePercentage = 100;

        // Variables - References
        public MovementManager movementManager;
        public ConcernManager concernManager;
        public DetectionManager detectionManager;
        public AnimationManager animationManager;
        public ActionManager actionManager;
        [HideInInspector]
        public NavMeshAgent navMeshAgent;

        // Variables - Other
        [HideInInspector]
        public bool busy = false;
        private int seconds = 60;
       
       

        // Functions - Mono
        private void Awake()
        {
            concernManager.init(this);
            movementManager.init(this);
            detectionManager.init(this);
            animationManager.init(this);
            actionManager.init(this);

            navMeshAgent = GetComponent<NavMeshAgent>();
         
        }

        private void Update()
        {
            if (!busy)
            {
                concernManager.runConcerns();
            }
        }

      

       

    }
}
