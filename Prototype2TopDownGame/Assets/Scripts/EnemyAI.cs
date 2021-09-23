using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag("Projectile"))
            Destroy(gameObject);
    } 
}
