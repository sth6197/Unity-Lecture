using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public void OnMove(Vector3 direction)
    {
        transform.position += direction;
    }
}
