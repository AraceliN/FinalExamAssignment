using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManage : MonoBehaviour
{
    public void DisplayCanvas(Canvas canvas)
    {
        Canvas[] canvases = FindObjectsOfType<Canvas>();
        foreach (Canvas c in canvases)
        {
            c.gameObject.SetActive(false);
        }
        canvas.gameObject.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
