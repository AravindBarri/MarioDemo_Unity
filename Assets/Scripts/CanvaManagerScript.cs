using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvaManagerScript : MonoBehaviour
{
  public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
