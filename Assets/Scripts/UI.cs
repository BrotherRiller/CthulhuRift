using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    [SerializeField] GameObject redscreen;

    public void SetRedScreen(bool showRedscreen = false)
    {

        if (showRedscreen)
        {
            redscreen.SetActive(true);
            Invoke("ClearRedScreen", 0.4f);
        }
    }

    public void GameOver()
    {
        redscreen.SetActive(true);
    }

    void ClearRedScreen()
    {
        CancelInvoke();
        redscreen.SetActive(false);
    }
}
