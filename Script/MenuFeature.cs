using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFeature : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField] private GameObject objects;

    //  Instantiate(objects, new Vector3(0, 1, 0), Quaternion.identity);
     public GameObject[] objectsToActivate;

    // ���ô˷���������������
    public void ActivateAllObjects()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true); // ��������
            }
        }
    }


}
