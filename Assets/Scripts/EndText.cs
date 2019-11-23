using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour
{
    float myScale = 10.0f;
    private void Start()
    {
        transform.localScale = new Vector3(myScale,myScale,1);
    }
    void Update()
    {
        if(myScale > 2.0f)
        {
            myScale -= 0.5f;
            transform.localScale = new Vector3(myScale, myScale, 1);
        }
        else
        {
            Destroy(this);
        }
    }
}
