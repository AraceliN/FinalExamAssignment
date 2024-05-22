using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Timers;

public class VanessaVenting : MonoBehaviour
{

    VanessaTileTracker VanessaTileTracker;
    string VVent;
    List<string> Vvents = new List<string>();

    public GameObject VanessaSprite;

    public Transform Vanessa;
    public Transform GirlsBlue;
    public Transform EastHallBlue;
    public Transform BackroomBlue;
    public Transform KitchenBlue;
    public Transform SupplyClosetBlue;
    public Transform ControlroomBlue;

    public int countdownTime;
    static Timer myTimer = new Timer(1000);

    private void Start()
    {
        VanessaSprite.GetComponent<VPlayerMovement>().enabled = false;
    }

    public void OnTriggerEnter2D(Collider2D room)
    {
       if (room.tag == "ControlroomVent") //Vent
        {
            VVent = "EastHall";
            Vanessa.transform.position = EastHallBlue.position;
            VentMovementDelay();
        }

        else if (room.tag == "BackroomVent")     //Vent
        {
            VVent = "Kitchen";
            Vanessa.transform.position = KitchenBlue.position;
            VentMovementDelay();
        }

        else if (room.tag == "GirlsVent") //Vent
        {
            VVent = "SupplyCloset";
            Vanessa.transform.position = SupplyClosetBlue.position;
            VentMovementDelay();
        }

        else if (room.tag == "SupplyClosetVent") //Vent
        {
            VVent = "Girls";
            Vanessa.transform.position = GirlsBlue.position;
            VentMovementDelay();
        }

        else if (room.tag == "EastHallVent") //Vent
        {
            VVent = "Controlroom";
            Vanessa.transform.position = ControlroomBlue.position;
            VentMovementDelay();
        }

        else if (room.tag == "KitchenVent")//Vent
        {
            VVent = "Backroom";
            Vanessa.transform.position = BackroomBlue.position;
            VentMovementDelay();
        }




        Vvents.Add(VVent);
        Debug.Log(VVent);

    }

    public void VentMovementDelay()
    { 
        StartCoroutine(OneSecondTimerVMovement());
    }

    IEnumerator OneSecondTimerVMovement()
    {
        
        VanessaSprite.GetComponent<VPlayerMovement>().enabled = false;
        countdownTime = 1;
        //myTimer.Elapsed -= countdownTime;
        while (countdownTime > 0)
        {

            yield return new WaitForSeconds(1f);
            countdownTime--;
            ;
        }


        VanessaSprite.GetComponent<VPlayerMovement>().enabled = true;
    }
}
