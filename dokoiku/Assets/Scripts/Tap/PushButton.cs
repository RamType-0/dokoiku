using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    bool destroyFlag = false;
    void Update()
    {
        if (destroyFlag)
        {
            Destroy(this.gameObject);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("SceneManager").GetComponent<SceneManager>().ResultScreen();
            destroyFlag = true;
        }
    }
}
