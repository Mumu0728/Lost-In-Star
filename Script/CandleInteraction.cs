using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleInteraction : MonoBehaviour
{
    //public GameObject flameToEnable; // Ŀ����̨�Ļ�������
    //public GameObject pickupCandle; // ��ʰȡ����̨
    public AudioSource source;
    public AudioClip soundClip;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Candle"))
        {

            Transform child = other.transform.GetChild(0);
            child.gameObject.SetActive(true);
            source.PlayOneShot(soundClip);
        }
    }
}
