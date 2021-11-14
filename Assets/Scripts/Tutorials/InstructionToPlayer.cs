using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstructionToPlayer : MonoBehaviour
{
    public TextMeshPro instruction;

    private void Awake()
    {
        instruction.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        instruction.enabled = true;
    }

}
