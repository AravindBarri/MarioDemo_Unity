using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuControlManager : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject OptionsPanel;
    public GameObject HelpPanel;
    public void OptionsMenu()
    {
        MainPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }
    public void HomeMenu()
    {
        OptionsPanel.SetActive(false);
        HelpPanel.SetActive(false);
        MainPanel.SetActive(true);
    }
    public void HelpMenu()
    {
        HelpPanel.SetActive(true);
        MainPanel.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
