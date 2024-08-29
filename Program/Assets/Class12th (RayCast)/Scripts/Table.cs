using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("책상입니다.");
    }
}
