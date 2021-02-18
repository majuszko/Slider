using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody rb;
    private bool directionRight = true;
    private GameManager gm;
    public Transform player;
    public GameObject effect;
    
    void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!gm.gameStarted)
        {
            return;
        }
        
        rb.transform.position = transform.position + transform.forward * 2 * Time.deltaTime;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LeftRight();
        }

        if (transform.position.y < -3)
        {
            SceneManager.LoadScene("Scenes/GameOver");
        }
    }

    void LeftRight()
    {

        if (!gm.gameStarted)
        {
            return;
        }

        directionRight = !directionRight;

        if (directionRight)
        {
            transform.rotation = Quaternion.Euler(0,45,0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0,-45,0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gold"))
        {
            gm.ScoreAdd();
            GameObject g = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(g, 2);
            Destroy(other.gameObject);
        }
    }
}
