using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") && gameManager.hasKey) {
            print("you unlocked the door");
            gameManager.isDoorLocked = false;
        } else {
            print("door is locked!");
        }
    }
}
