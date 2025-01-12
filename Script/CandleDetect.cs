using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleDetect : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject plate01;
    public GameObject plate02;
    public GameObject plate03;
    public GameObject plate04;
    public GameObject rewared;
    void Update()
    {
        if (plate01.activeSelf && plate02.activeSelf && plate03.activeSelf && plate04.activeSelf) 
        {
            rewared.SetActive(true);
        }

    }
}
