using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public  GameObject menu;
    public static bool GameIsPaused = false;
    public void Pausa()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
        GameIsPaused = true;
    }
    public void Reanudar()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        GameIsPaused = false;
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void SalirAlMenu()
    {
        Debug.Log("SalirAlMenu");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu inicial", LoadSceneMode.Single);
    }
    // Start is called before the first frame update
    void Start()
    {
        Reanudar();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Reanudar();
                Debug.Log("Reanudar");
            }
            else
            {
                Pausa();
                Debug.Log("Pausa");
            }
        }
    }
}
