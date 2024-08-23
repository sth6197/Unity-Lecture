using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] int count = 0;

    [SerializeField] GameObject [] foods;
    
    [SerializeField] GameObject clone;

    [SerializeField] float time;

    WaitForSeconds waitForSeconds = new WaitForSeconds(5.0f);

    private void Start()
    {
        StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while (count < foods.Length)
        {
            if (clone == null)
            {
                clone = Instantiate(foods[count++]);
            }
            
                yield return waitForSeconds;
        }
    }
}
