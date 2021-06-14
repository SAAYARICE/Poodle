using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ClicEventDetection : MonoBehaviour
{

    public void OnGrayClick(BaseEventData date)
    {
        PlayerPrefs.SetString("Character","Gray");
        SceneManager.LoadScene("Stage1");
    }
    public void OnWhiteClick(BaseEventData date)
    {
        PlayerPrefs.SetString("Character", "White");
        SceneManager.LoadScene("Stage1");
    }
    public void OnCreamClick(BaseEventData date)
    {
        PlayerPrefs.SetString("Character", "Cream");
        SceneManager.LoadScene("Stage1");
    }
}
