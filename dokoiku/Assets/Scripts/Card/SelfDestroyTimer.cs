using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyTimer : MonoBehaviour
{
    public float time = 0.1f;
    
    void Update()
    {
        if( time < 0.0f )
        {
            Destroy(this.gameObject);
        }

        time -= Time.deltaTime;
    }
}
