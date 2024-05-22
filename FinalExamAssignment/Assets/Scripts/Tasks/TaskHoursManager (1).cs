using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class TaskHoursManager : MonoBehaviour
{
    [SerializeField]
    private int taskOne = 0;

    [SerializeField]
    private int taskTwo = 0;

    [SerializeField]
    private int taskThree = 0;

    [SerializeField]
    private int taskFour = 0;

    [SerializeField]
    private int taskFive = 0;

    public int totalHours;

    bool freecam = false;

    int emergencydoor = 0;

    public GameManager gameManager;

    public TMP_Text HoursTxt;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    void Update()
    {
        TaskOneChecker();
        TaskTwoChecker();
        taskThreeChecker();
        taskFourChecker();
       // taskFiveChecker();
        HourChecker();
        HoursTxt.text = totalHours.ToString() +"h";
    }


    public void HourChecker()
    {
        totalHours = taskOne + taskTwo + taskThree + taskFour /*+ taskFive*/;

        if (totalHours >= 2)
        {
            bool freecam = true;

            if (totalHours == 4 && (emergencydoor == 0 || emergencydoor == 1))
            {
                emergencydoor = 1;
                if (totalHours == 6)
                {
                   // gameManager.UpdateGameState(Gamestate.VanessaVictory);
                }
            }
            else
            {
                emergencydoor = -1;
                if (totalHours == 6)
                {
                    //gameManager.UpdateGameState(Gamestate.VanessaVictory);
                }
            }
        }

        //Debug.Log(totalHours);
    }




    //Breakers task in the west hall and Backroom
    public bool taskOnedone = false;

    void TaskOneChecker()
    {
        if (taskOnedone == true)
        {
            taskOne = 2;
        }
        else
        {
            taskOne = 0;
        }
    }


    //Doors task: 4 doors down for 3 consecutive rounds
    public bool taskTwodone = false;

    void TaskTwoChecker()
    {
        if (taskTwodone == true)
        {
            taskTwo = 2;
        }
        else
        {
            taskTwo = 0;
        }
    }


    // East hall for 3 rounds task
    public bool taskThreedone = false;

    void taskThreeChecker()
    {
        if (taskThreedone == true)
        {
            taskThree = 2;
        }
        else
        {
            taskThree = 0;
        }
    }


    // Bathroom task: Have all 3 bathrooms been cleaned?
    public bool taskFourdone = false;

    void taskFourChecker()
    {
        if (taskFourdone == true)
        {
            taskFour = 2;
        }
        else
        {
            taskFour = 0;
        }
    }


    // when tasks are completed sets them as true
    //West Hall and Backrooms
    public void TaskOneDone()
    {
        taskOnedone = true;
    }


    // Doors
    public void TaskTwoDone()
    {
        taskTwodone = true;
    }

    //East Hall
    public void TaskThreeDone()
    {
        taskThreedone = true;
    }

    //Bathrooms
   public void TaskFourDone()
    {
        taskFourdone = true;
    }


    //Cards task: has Vanessa collected 2 or more cards?
    //bool taskFivedone = false;

    /* Card task is no longer included in current version of game
     * void taskFiveChecker()
     {
         if (taskFivedone == true)
         {
             taskFive = 1;
         }
         else
         {
             taskFive = 0;
         }
     }
     */
}
