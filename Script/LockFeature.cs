using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using System.Globalization;
using System.Diagnostics;
//using com;

public class LockFeature : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public int[] password1 = { 3, 1, 2, 1, 0, 0 };
    [SerializeField] public int[] userCode = { 10, 10, 10, 10, 10, 10 };
    public TextMeshPro code;




    // 要激活的物体

    [SerializeField] private GameObject paper2;



    
    public void OnClick1()
    {

        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 1;
                int[] selectedNumbers = userCode.Take(i+1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                // item1.gameObject.SetActive(true);
                break;
            }
        }
    }

    public void OnClick2()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 2;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick3()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 3;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick4()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 4;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick5()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 5;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick6()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 6;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick7()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 7;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick8()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 8;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick9()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 9;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void OnClick0()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            if (userCode[i] == 10)
            {
                userCode[i] = 0;
                int[] selectedNumbers = userCode.Take(i + 1).ToArray();
                string dispalyCode = string.Join("", selectedNumbers);
                code.text = dispalyCode;
                break;
            }
        }
    }

    public void IdentifyCode()
    {
        bool areEqual = userCode.SequenceEqual(password1);
        if (areEqual)
        {
            paper2.SetActive(true);
        }

    }

    public void Cancel()
    {
        for (int i = 0; i < userCode.Length; i++)
        {
            userCode[i] = 10;
            code.text = "";

        }
    }

   
}
