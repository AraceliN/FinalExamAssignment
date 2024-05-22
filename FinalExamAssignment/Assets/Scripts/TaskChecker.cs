using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TaskChecker : MonoBehaviour
{

    VanessaTileTracker VanessaTileTracker;
    string VTask;
    List<string> VTasks = new List<string>();

    public GameObject VanessaSprite;

    GameObject door1;
    GameObject door2;
    GameObject door3;
    GameObject door4;
   

    public bool westHall = false;
    public bool backRoom = false;
    public bool blueblockInBoysBathroom = false;
    public bool blueblockInGirlsBathroom = false;
    public bool blueblockInUnisexBathroom = false;

    public TaskHoursManager taskHoursManager;

    private void Start()
    {
        taskHoursManager = GetComponent<TaskHoursManager>();
    }

  /*  public void OnTriggerEnter2D(Collider2D task)
    {
        if (task.tag == "WestHallBlue") //Vent
        {
            VTask = "WestHallBlue";
            westHall = true;

            CheckSpecificTaskCompletion();

        }

        else if (task.tag == "BackroomBlue")     //Vent
        {
            VTask = "BackRoomBlue";

            backRoom = true;

            CheckSpecificTaskCompletion();

        }

        else if (task.tag == "GirlsBlue") //Vent
        {
            VTask = "GirlsBlue";
            
        }

        else if (task.tag == "BoysBlue") //Vent
        {
            VTask = "BoysBlue";
            blueblockInBoysBathroom = true;
            CheckSpecificTaskCompletion();

        }

        else if (task.tag == "EastHallBlue") //Vent
        {
            VTask = "EastHallBlue";
            taskHoursManager.TaskThreeDone();

        }

        else if (task.tag == "KitchenVent")//Vent
        {
            VTask = "Backroom";
           
        }




        VTasks.Add(VTask);
        Debug.Log(VTask);

    }



        

       

      
        }

        if (other.tag == "GirlsBlue")
        {
            blueblockInGirlsBathroom = true;
            Debug.Log("Girls' bathroom cleaned");
            CheckSpecificTaskCompletion();
        }

        if (other.tag == "UnisexBlue")
        {
            blueblockInUnisexBathroom = true;
            Debug.Log("Unisex bathroom cleaned");
            CheckSpecificTaskCompletion();
        }

    }

    private void CheckSpecificTaskCompletion()
    {
        if (WestHall && backRoom)
        {
            Debug.Log("Task 2 completed: fixed the breakers in the West Hall and the Back Room: +2 hours.");

            refScript.TaskOneDone();
        }

        if (blueblockInBoysBathroom && blueblockInGirlsBathroom && blueblockInUnisexBathroom)
        {
            Debug.Log("Task 4 completed: +2 hours.");
            refScript.TaskFourDone();
        }
    }
  */
}
