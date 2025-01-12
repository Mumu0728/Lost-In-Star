using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManage : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    public AudioClip soundClip;

    void Start()
    {
        source.PlayOneShot(soundClip);
    }

    // Update is called once per frame
    
}
