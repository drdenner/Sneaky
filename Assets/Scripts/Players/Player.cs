using UnityEngine;
using System.Collections;

namespace Player
{
    public class Player : MonoBehaviour
    {

        public static Player Instance { get; private set; }

        private void Awake()
        {
            setSingleton();
        }

        private void setSingleton()
        {
            if (Instance != null && Instance != this)
            {

                Destroy(gameObject);
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
