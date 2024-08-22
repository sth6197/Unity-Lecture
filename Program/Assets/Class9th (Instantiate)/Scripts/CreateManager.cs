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

    WaitForSeconds waitForSeconds = new WaitForSeconds(3.0f);

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
            else if (clone != null)
            {
                yield return waitForSeconds;

                for (int i = 0; i < foods.Length; i++)
                {
                    clone = Instantiate(foods[i]);

                    clone.transform.position = new Vector3(Random.Range(0, 101), Random.Range(0, 301));
                }
            }
        }
            yield return waitForSeconds;
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time >= 3.0f)
        {
            clone = Instantiate(foods[0]);


            time = 0.0f;
        }
    }
}
