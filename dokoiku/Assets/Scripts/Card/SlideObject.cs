using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideObject : MonoBehaviour
{
    public float slideLength = 6.0f;
    public float slideSpeed = 0.2f;
    public float waitTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        waitTime -= Time.deltaTime;

        if (waitTime <= 0.0f)
        {
            if (slideLength > 0.1f)
            {
                transform.Translate(-slideSpeed, 0, 0);
                slideLength -= slideSpeed;
            }
            else
            {
                enabled = false;
            }
        }
    }
}
