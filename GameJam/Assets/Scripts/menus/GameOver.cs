using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public  GameObject menu;
    public static bool GameIsPaused = false;
    public vida_jugador vida;
    public void GOver()
    {
        Debug.Log("GameOver");
        Time.timeScale = 0f;
        menu.SetActive(true);
        GameIsPaused = true;
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void VolverMenuInicial()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu inicial", LoadSceneMode.Single);
    }
    
    void Start()
    {
        vida = GameObject.FindWithTag("Player").GetComponent<vida_jugador>();
    }
}
