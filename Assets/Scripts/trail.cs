using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class trail : MonoBehaviour
{
    public GameObject floorPref;
    public float offset = 0.71f;
    public Vector3 lastPos;
    private int counter = 0;

    public void BuildingCubes()
    {
        InvokeRepeating("NewCube", 1f, 0.5f);
    }

    public void NewCube()
    {
        print("bulbul");

        Vector3 spawn = Vector3.zero;
        float chance = Random.Range(0, 100);
        if (chance < 50)
        {
            spawn = new Vector3(lastPos.x + offset, lastPos.y, lastPos.z + offset);
        }
        else
        {
            spawn = new Vector3(lastPos.x-offset, lastPos.y, lastPos.z+offset);
        }

        GameObject g = Instantiate(floorPref, spawn, Quaternion.Euler(0, 45, 0));

        lastPos = g.transform.position;

        counter++;
        if (counter % 5 == 0)
        {
            g.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NewCube();
        }
    }*/
}
