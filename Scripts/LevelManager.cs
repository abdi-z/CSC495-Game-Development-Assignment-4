using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void toLevel1()
    {
        SceneManager.LoadScene(2);
    }
    public void toLevel2()
    {
        SceneManager.LoadScene(3);
    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
