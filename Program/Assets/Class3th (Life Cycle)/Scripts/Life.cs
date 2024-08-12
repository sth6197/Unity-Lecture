using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    private void Awake()
    {
        // Awake()
        // 게임 오브젝트가 생성되었을 때, 단 한번만 호출되며,
        // 스크립트가 비활성화된 상태일 때도 호출되는 이벤트 함수입니다.

        // Getcomponent, 데이터 세팅은 Awake() 에서 할 것

        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        // OnEnable()
        // 게임 오브젝트가 활성화되었을 때, 호출되는 이벤트 함수입니다.

        Debug.Log("OnEnable");
    }
    void Start()
    {
        // Start()
        // 게임 오브젝트가 생성되었을 때, 단 한번만 호출되며,
        // 스크립트가 비활성화된 상태일 때는 호출되지 않는 이벤트 함수입니다.

        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        // FixedUpdate()
        // TimeStep 이라는 값에 따라 일정한 간격으로 호출되는 이벤트 함수입니다.
        
        // 키 입력 등의 반응은 FixedUpdate()

        Debug.Log("Fixed Update");
    }
    void Update()
    {
        // 키 입력 등은 Update()

        // Update()
        // 프레임마다 호출되는 이벤트 함수입니다.

        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        // LateUpdate()
        // Update 함수가 끝난 후에 호출되는 이벤트 함수입니다.

        // 카메라 연출 등

        Debug.Log("LateUpdate");
    }
    private void OnDisable()
    {
        // OnDisable()
        // 게임 오브젝트가 비활성화되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        // OnDestroy()
        // 게임 오브젝트가 파괴되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnDestroy");
    }

}
