using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingData : MonoBehaviour
{
    private int nr = 0;
    
    
    void Start()
    {
        Debug.Log("XD patrz: " +getNr());
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nr++;
            if (nr > getNr())
            {
                PlayerPrefs.SetInt("Numerek", nr);
                
            }
            Debug.Log(nr);
        }
    }

    int getNr()
    {
        int numerek = PlayerPrefs.GetInt("Numerek", 0);
        return numerek;
    }
}
