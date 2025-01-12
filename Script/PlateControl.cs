using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateControl : MonoBehaviour
{
    public GameObject flame;
    public GameObject plate01;
    public string plateName;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == plateName)
        {
            if (flame.gameObject.activeSelf)
            {
                plate01.SetActive(true);
            }
        }
    }
}
