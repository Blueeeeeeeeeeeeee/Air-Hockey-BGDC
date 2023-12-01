using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Session6sc : MonoBehaviour
{
    public void PlayButtonThing(){
        SceneManager.LoadScene(1);
    }
    public void QuitButtonThing(){
        Debug.Log("Exited");
        Application.Quit();
    }
}
