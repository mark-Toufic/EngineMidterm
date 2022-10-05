using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public PlayerController playerController;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            playerController.timeBetweenAttacks = 0;
            Destroy(gameObject);
        }
    }
}
