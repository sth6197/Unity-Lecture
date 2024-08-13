using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Move))]
public class Monster : MonoBehaviour
{
    [SerializeField] Move move;

    private void Awake()
    {
        move = GetComponent<Move>();
    }

    void Start()
    {
        move.OnMove(new Vector3(1, 1, 1));
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            move.OnMove(Vector3.forward);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            move.OnMove(Vector3.left);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            move.OnMove(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            move.OnMove(Vector3.right);
        }
        if(Input.GetKeyDown (KeyCode.Space)) 
        {
            move.OnMove(Vector3.up);
        }
        if( Input.GetKeyDown(KeyCode.LeftShift))
        {
            move.OnMove(Vector3.down);
        }
    }
}
