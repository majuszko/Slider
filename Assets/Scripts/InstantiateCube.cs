using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCube : MonoBehaviour
{
    public Transform prefab;
    private int counter = 0;
    void Start()
    {
        /*for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i, i, i), Quaternion.identity);
        }*/
        
        //InvokeRepeating("CubeClones", 2f, 1f);
        Invoke("CubeClones", 2f);
        
    }

    
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3(counter*2.0f, 0, 0), Quaternion.identity);
            counter++;
        }*/
    }

    public void CubeClones()
    {
        Instantiate(prefab, new Vector3(counter*2.0f, 0, 0), Quaternion.identity);
        counter++;

        if (counter >= 5)
        {
            CancelInvoke();
        }
    }
}
