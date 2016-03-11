// Pool Manager
// Creates an Objet Pool
// getPoolObject(name) returns a GameObject

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Managers
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager Instance { get; private set; }

        Dictionary<string,PoolObject> pool = new Dictionary<string,PoolObject>();

        private void Awake()
        {
            setSingleton();
        }

        private void Start()
        {
            createPoolList();
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


        private void createPoolList()
        {
            PoolObject[] poolObjects = GetComponents<PoolObject>();
		
            foreach (PoolObject poolObject in poolObjects)
            {
                pool [poolObject.prefab.name] = poolObject;
            }	
        }

        public GameObject getPoolObject(string name)
        {
            GameObject poolObject = pool [name].getObject();
            return poolObject;
        }
    }
}
