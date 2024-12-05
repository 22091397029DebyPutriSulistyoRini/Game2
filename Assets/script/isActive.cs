using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isActive : MonoBehaviour
{
    public GameObject activeObject;
    public void gameobjectactive()
    {
        activeObject.SetActive(true);
    }

    public void deactivate()
    {
        activeObject.SetActive(false);
    }    
}