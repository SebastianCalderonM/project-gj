using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public  GameObject menu; 
    public void StartPlaying()
    {
        // disable menu
        menu.SetActive(false);
        // go to scene playing
        SceneManager.LoadScene("Nivel1-testing", LoadSceneMode.Single);
    }
}
