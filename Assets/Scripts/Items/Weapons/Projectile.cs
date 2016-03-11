using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    // Variables - Inspector
    public float projectileSpeed;


    // Variables - Others
         

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
    }
}
 