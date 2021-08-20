using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //If the player has entered the collider
        if (other && other.CompareTag("Player"))
        {
            //Get script ref
            EnterLeaveBoat enterLeaveBoat = other.GetComponent<EnterLeaveBoat>();

            //If script ref fails or player isn't in the boat
            if (!enterLeaveBoat || !enterLeaveBoat.isInBoat()) return;

            enterLeaveBoat.leaveBoat();
        }
    }
}
