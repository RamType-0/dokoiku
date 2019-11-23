using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    public void PushRestartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartScene");
    }
}
