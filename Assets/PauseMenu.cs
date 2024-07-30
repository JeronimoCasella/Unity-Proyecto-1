using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    // Update is called once per frame
    void Update()
    {

    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        // Verifica si estamos en el editor o en una compilaci�n
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detener la reproducci�n en el Editor
#else
        Application.Quit(); // Salir del juego en una compilaci�n
#endif
    }
}