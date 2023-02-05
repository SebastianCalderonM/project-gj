using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public  GameObject menu; 
    public void LoadMenuInicial()
    {
        // Load scene
        SceneManager.LoadScene("Menu inicial", LoadSceneMode.Single);
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene("Nivel1-testing", LoadSceneMode.Single);
    }
}
