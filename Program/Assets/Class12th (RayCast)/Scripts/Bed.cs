using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("침대입니다.");
    }
}
