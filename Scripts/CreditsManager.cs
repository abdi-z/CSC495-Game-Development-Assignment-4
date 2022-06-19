using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenGithub()
    {
        Application.OpenURL("https://github.com/mishaosipovprodigy2");
    }
    public void CreditsManagerFunc()
    {
        Debug.Log("Pressed Credits Manager");
        SceneManager.LoadScene(0);
    }
}
