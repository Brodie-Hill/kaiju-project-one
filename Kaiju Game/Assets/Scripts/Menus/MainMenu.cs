using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] DialogBox quitConfirmationBox = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TryQuit()
    {
        quitConfirmationBox.gameObject.SetActive(true);
    }
    public void ConfirmQuit()
    {
        Application.Quit();
    }
}
