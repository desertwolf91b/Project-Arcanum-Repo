using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLeaveBoat : MonoBehaviour
{
    public GameObject boat;

    //True when player is in the boat
    private bool inBoat = false;

    // Update is called once per frame
    void Update()
    {
        //When the player is in the boat, have the boat follow player movement
        if (inBoat) mirrorPlayerMovement(gameObject, boat);
    }

    public void enterBoat()
    {
        Debug.Log("ENTERED BOAT");        
        inBoat = true;
    }

    public void leaveBoat()
    {
        Debug.Log("LEFT BOAT");        
        inBoat = false;
    }

    public bool isInBoat()
    {
        return inBoat;
    }

    //Boat explicity follows player movement and rotation
    //This behaivor only occurs when |inBoat| is true
    //TODO : child index crap dependency
    private static void mirrorPlayerMovement(GameObject Player, GameObject boat)
    {
        boat.transform.position = Player.transform.position;
        boat.transform.rotation = Player.transform.GetChild(0).rotation;
    }
}
