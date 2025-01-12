using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();

    }
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Key"))
        {
            anim.SetBool("drwerOpen", true);
            
        }
    }
}
