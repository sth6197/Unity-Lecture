using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public enum State
{
    WALK,
    ATTACK,
    DIE
}

public class Knight : MonoBehaviour
{
    [SerializeField] State state;

    [SerializeField] float speed = 2.5f;
    [SerializeField] float time;

    [SerializeField] Animator animator;

    private WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);

    void Start()
    {
        state = State.WALK;
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        switch(state)
        {
            case State.WALK: Walk();
                break;
            case State.ATTACK: Attack();
                break;
            case State.DIE: Die();
                break;
        }
    }

    public void Walk()
    {
        animator.SetBool("Attack", false);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void Attack()
    {
        animator.SetBool("Attack", true);
    }

    public void Die()
    {
        animator.Play("Die");
    }

    private IEnumerator KonckBack(Collider other)
    {
        yield return waitForSeconds;

        other.transform.position += new Vector3(0, 0, -3);
    }

    private void OnTriggerEnter(Collider other)
    {
        // OnTriggerEnter() : ���� ������Ʈ�� ���������� ���� �浹�� ���� ��
        //                    ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        state = State.ATTACK;

        StartCoroutine(KonckBack(other));
    }

    private void OnTriggerStay(Collider other)
    {
        // OnTriggerStay() : ���� ������Ʈ�� ���������� ���� �浹 ���� ��
        //                   ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        
    }

    private void OnTriggerExit(Collider other)
    {
        // OnTriggerExit() : ���� ������Ʈ�� ���������� ���� �浹���� ����� ��
        //                   ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        state = State.DIE;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // OnCollisionEnter() : ���� ������Ʈ�� �������� �浹�� ���� ��
        //                      ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        // OnCollisionStay() : ���� ������Ʈ�� �������� �浹 ���� ��
        //                     ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        // OnCollistionExit() : ���� ������Ʈ�� �������� �浹�� ����� ��
        //                      ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnCollisionExit");
    }
}
