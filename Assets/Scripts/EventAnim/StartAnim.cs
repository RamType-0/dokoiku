using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    GameObject myChild;

    private void Start()
    {
        int objectCount = this.transform.childCount;
        objectCount = Random.Range(0, objectCount);
        myChild = transform.GetChild(objectCount).gameObject;
        myChild.SetActive(true);
    }
    public void ExcutionStartAnim(GameObject _gameObject)
    {
        myChild.GetComponent<AnimEvent>().StartAnimEvent(_gameObject);
    }

    public void ExcutionFinishFlip(GameObject _gameObject)
    {
        myChild.GetComponent<AnimEvent>().FinishFlip();
    }
}
