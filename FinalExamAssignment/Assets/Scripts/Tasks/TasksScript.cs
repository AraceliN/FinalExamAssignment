using System.Collections.Generic;
using UnityEngine;

public class TaskTracker : MonoBehaviour
{
    GameObject door1;
    GameObject door2;
    GameObject door3;
    GameObject door4;
    GameObject EastHall;
    GameObject WestHall;
    GameObject BackRoom;

    bool westHall = false;
    bool backRoom = false;
    bool blueblockInBoysBathroom = false;
    bool blueblockInGirlsBathroom = false;
    bool blueblockInUnisexBathroom = false;

    TaskHoursManager refScript;

    public void Start()
    {
        refScript = GetComponent<TaskHoursManager>();
        Task2();
    }

    void Task2()
    {
        door1 = GameObject.Find("door1");
        door2 = GameObject.Find("door2");
        door3 = GameObject.Find("door3");
        door4 = GameObject.Find("door4");


        for (int i = 0; i < 3; i++) // Simulating three rounds of checks, not the actual round tracker though
        {
            if (door1.activeSelf && door2.activeSelf && door3.activeSelf && door4.activeSelf)
            {
                Debug.Log("Task 2 completed: 4 doors were kept closed for 3 consecutive rounds: +2 hours.");
                refScript.TaskTwoDone();
            }
            else
            {
                Debug.Log("All 4 doors are not shut in round " + (i + 1));
                break;  // Exit the loop as soon as one door is found open
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D other) 
    {
       for (int i = 0; i < 3; i++) //not the actual round tracker
       {
          if (other.gameObject.name == "East Hall")
          {
                Debug.Log("Task 3 completed: stayed in East Hall for 3 consecutive rounds: +2 hours");
                refScript.TaskThreeDone();
            }
       }
            
            
            //Task1: must fix breakers in the west hall and backroom
       if (other.CompareTag("West Hall"))
       {
          westHall = true;

          Debug.Log("Visited: " + other.name);

          CheckSpecificTaskCompletion();

       }

       if (other.CompareTag("Back Room"))

       {
            backRoom = true;

            Debug.Log("Visited: " + other.name);

            CheckSpecificTaskCompletion();
       }

        //Task4: cleaning 3 bathrooms
       if (other.gameObject.name == "blueblockBoys")
       {
            blueblockInBoysBathroom = true;
            Debug.Log("Boys' bathroom cleaned");
            CheckSpecificTaskCompletion();
       }

       if (other.gameObject.name == "blueblockGirls")
       {
            blueblockInGirlsBathroom= true;
            Debug.Log("Girls' bathroom cleaned");
            CheckSpecificTaskCompletion();
       }

       if (other.gameObject.name == "blueblockUnisex")
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
}
