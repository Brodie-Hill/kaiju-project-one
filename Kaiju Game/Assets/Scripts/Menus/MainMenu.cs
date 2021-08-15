using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] DialogBox quitConfirmationBox = null;
    // Start is called before the first frame update
    
    public void TryQuit()
    {
        quitConfirmationBox.gameObject.SetActive(true);
    }
    public void ConfirmQuit()
    {
        Application.Quit();
    }

    public void LoadPrototypeScene()
    {
        SceneManager.LoadScene(1);
    }
}
