using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Transform Door;

    private void OnCollisionEnter(Collision collision)
    {
        Door.gameObject.SetActive(false);
    }
}
