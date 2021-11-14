using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Passcode : MonoBehaviour
{
    public int[] code;
    public TextMeshPro codeOne;

    private void OnTriggerEnter(Collider other)
    {
        codeOne.text = code[0].ToString();
    }
}
