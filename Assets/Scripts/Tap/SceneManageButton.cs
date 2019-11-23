using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManageButton : MonoBehaviour
{
    public void PushStartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
    public void PushHistoryButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HistoryScene");
    }
    public void PushRestartButton()
    {
        PlayerPrefs.Save();
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartScene");
    }
}
