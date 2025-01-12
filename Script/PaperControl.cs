using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject paperOpen;
    public GameObject paperClose;

    public void Paper()
    {
        paperOpen.SetActive(true);
        paperClose.SetActive(false);
    }
}
