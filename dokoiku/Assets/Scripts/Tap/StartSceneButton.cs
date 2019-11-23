using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneButton : MonoBehaviour
{
    public void PushStartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
    public void PushHistoryButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("HistoryScene");
    }
}
