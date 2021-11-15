using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlay() {
        SceneManager.LoadScene("Main");
    }

    public void OnCredits() {
        SceneManager.LoadScene("credits");
    }

    public void OnBack() {
        SceneManager.LoadScene("Menu");
    }

    public void Exit() {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
