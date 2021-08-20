using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatCollider : MonoBehaviour
{
    //Reference to the player
    public GameObject Player;

    //When the Player enters the boat
    private void OnTriggerEnter(Collider other)
    {
        //If the player is the collider
        if (other && other.CompareTag("Player"))
        {
            //Enter the boat
            other.GetComponent<EnterLeaveBoat>().enterBoat(); 
        }
    }
}
