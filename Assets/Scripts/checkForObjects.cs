using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class checkForObjects : MonoBehaviour
{
    //public GameObject item;
    
    void Update()
    {
        /*RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100f))
        {
            //Debug.Log("Uwazaj na dupe, "+hit.transform.position);
            Debug.Log("Uwazaj na dupe, "+hit.distance);
        }
        else
        {
            Debug.Log("Nic ni ma");
        }*/

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.Log("uderz " + hit.collider.gameObject.name);

            gameObject.GetComponent<Renderer>().material.color = Color.magenta;

        }
    }
}
