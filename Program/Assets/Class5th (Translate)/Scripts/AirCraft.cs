using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraft : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 1.0f;
    
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize();

        // P(���� �̵��� ��ġ) = P0(���� ��ġ) + vt(����, �ð�)
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
