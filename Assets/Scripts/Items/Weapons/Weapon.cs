using UnityEngine;
using System.Collections;

namespace Items.Weapons
{
    public class Weapon : MonoBehaviour
    {
        // Variables - Inspector
        public GameObject projectile;
        public float cooldown = 1f;

        // Variables - Other
        private bool isReady = true;
        private float cooldownCount;

        // Functions - Mono
        public void Start()
        {
            cooldownCount = cooldown;
        }

        // Functions - Public
        public void activate()
        {
            if (isReady)
            {
                shoot();
            }
        }

        // Functions - Private
        private void shoot()
        {
            GameObject obj = Managers.PoolManager.Instance.getPoolObject("Bullet");
            Quaternion rot = gameObject.transform.rotation;
            rot.x = 0;
            rot.z = 0;
            obj.transform.position = gameObject.transform.position;
            obj.transform.rotation = rot;
            obj.SetActive(true);
            isReady = false;

            InvokeRepeating("countdown", cooldown, cooldown);
        }

        private void countdown()
        {            
            if (--cooldownCount == 0)
            {
                isReady = true;
                cooldownCount = cooldown;
            }
        }
    }
   
}
