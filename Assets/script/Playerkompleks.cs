using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerkompleks : MonoBehaviour
{
    void OnControllerColliderHit(ControllerColliderHit col)
    {
        if (col.gameObject.name == "NoSql")
        {
             Destroy(col.gameObject);
        }
    }
}
