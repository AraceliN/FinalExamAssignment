using System.Collections.Generic;
using UnityEngine;
using static TileTypes;
public class TaskTracker : MonoBehaviour
{
    GameObject door1;
    GameObject door2;
    GameObject door3;
    GameObject door4;
    GameObject EastHall;
    GameObject WestHall;
    GameObject BackRoom;

    public bool westHall = false;
    public bool backRoom = false;
    public bool blueblockInBoysBathroom = false;
    public bool blueblockInGirlsBathroom = false;
    public bool blueblockInUnisexBathroom = false;

    public TaskHoursManager taskHoursManager;
    public DoorAbility DoorAbility;
    public int RoundsInEastHall;
    public bool OnEastHallBlue;

    public void Start()
    {
        RoundsInEastHall = 0;
        OnEastHallBlue = false;
        //Task2();
    }

    public void Update()
    {
        Task2();
    }

    void Task2()
    {
       if (DoorAbility.doorsDownForThreeRounds >= 4 )
        {
            taskHoursManager.TaskTwoDone();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // for (int i = 0; i < 3; i++) //not the actual round tracker
        // {
        if (other.tag == "EastHall")
        {

            OnEastHallBlue = true;
            RoundsInEastHall += 1;

            if (RoundsInEastHall == 3)
            {
                taskHoursManager.TaskThreeDone();
            }
            Debug.Log(RoundsInEastHall);
            Debug.Log(OnEastHallBlue);
           // taskHoursManager.TaskThreeDone();
            Debug.Log("Task 3 completed: stayed in East Hall for 3 consecutive rounds: +2 hours");
            

        }
        //  }

        if (other.tag != "EastHall" && other.tag!= "EastHallBlue")
        {
            OnEastHallBlue = false;
            RoundsInEastHall = 0;
        }

        //Task1: must fix breakers in the west hall and backroom
        if (other.tag == "WestHallBlue")
        {
            westHall = true;

            Debug.Log("Visited: " + other.name);

            CheckTaskOneCompletion();

        }

        if (other.tag == "BackroomBlue")

        {
            backRoom = true;

            Debug.Log("Visited: " + other.name);

            CheckTaskOneCompletion();
        }

        //Task4: cleaning 3 bathrooms
        if (other.tag == "BoysBlue")
        {
            blueblockInBoysBathroom = true;
            Debug.Log("Boys' bathroom cleaned");
            CheckTaskFourCompletion();
        }

        if (other.tag == "GirlsBlue")
        {
            blueblockInGirlsBathroom = true;
            Debug.Log("Girls' bathroom cleaned");
            CheckTaskFourCompletion();
        }

        if (other.tag == "UnisexBlue")
        {
            blueblockInUnisexBathroom = true;
            Debug.Log("Unisex bathroom cleaned");
            CheckTaskFourCompletion();
        }

    }


    private void CheckTaskOneCompletion()
    {
        if (westHall && backRoom)
        {
            Debug.Log("Task 2 completed: fixed the breakers in the West Hall and the Back Room: +2 hours.");
            taskHoursManager.taskOnedone = true;
            taskHoursManager.TaskOneDone();
        }

    }

    private void CheckTaskFourCompletion()
    {
        if (blueblockInBoysBathroom && blueblockInGirlsBathroom && blueblockInUnisexBathroom)
        {
            Debug.Log("Task 4 completed: +2 hours.");
            taskHoursManager.taskFourdone = true;
            taskHoursManager.TaskFourDone();
        }
    }

    public void decreaseRoundInEastHall()
    {
        if(OnEastHallBlue)
        {
            RoundsInEastHall--;
        }
        
    }
}