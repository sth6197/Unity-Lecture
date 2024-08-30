using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;

    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        // ForceMode.Force : �������� ���� ���� ���� ������Ʈ�� �����̴� ����Դϴ�. (���� O)
        // ForceMode.Acceleration : �������� ���� ���� ���� ������Ʈ�� �����̴� ����Դϴ�. (���� X)

        // ForceMode.Impulse : �������� ���� ���� ���� ������Ʈ�� �����̴� ����Դϴ�. (���� O)
        // ForceMode.VelocityChange : �������� ���� ���� ���� ������Ʈ�� �����̴� ����Դϴ�. (���� X)


        rigidBody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
