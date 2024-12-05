using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPlayer : MonoBehaviour
{
    public GameObject panelsoal1; 

    private void OnCollisionEnter3D(Collision collision)
    {
        if (collision.gameObject.CompareTag("pertanyaan"))
        {
            panelsoal1.SetActive(true);
            
        }
    }

    public void matikanpanelsoal1()
    {
        panelsoal1.SetActive(false);
    }

}