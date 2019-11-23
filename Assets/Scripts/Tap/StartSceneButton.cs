using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySceneManager = UnityEngine.SceneManagement.SceneManager;
public class StartSceneButton : MonoBehaviour
{
    public void PushStartButton()
    {
        UnitySceneManager.LoadScene("GameScene");
    }
    public void PushHistoryButton()
    {
        UnitySceneManager.LoadScene("HistoryScene");
    }
}
