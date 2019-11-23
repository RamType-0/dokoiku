using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.Find("SceneManager").GetComponent<SceneManager>().ShowResult();
            Destroy(this.gameObject);
        }
    }
}
