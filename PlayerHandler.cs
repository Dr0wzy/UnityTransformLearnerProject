using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public int health = 10;
    public int level = 1;

    public float speed = 1.2f;

    private int scale_counter = 0;

    private void Start()
    {
        
        health += level;
        Debug.Log("Your character's health is : " + health); //Print out new health
    }

    private void Update()
    {
        if (gameObject.CompareTag("Player"))
        {
            Vector3 newPos = transform.position;

            if (Input.GetKey(KeyCode.W))
            {
                newPos.z += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                newPos.z -= speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                newPos.x -= speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                newPos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.E))
            {
                newPos.y += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.Q))
            {
                newPos.y -= speed * Time.deltaTime;
            }

            transform.position = newPos;

            if (Input.GetKeyDown(KeyCode.Z))
            {
                transform.position = new Vector3(3f, 1f, 4f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                transform.position = new Vector3(-4f, 2f, -3f);
            }
        }

        else if (gameObject.CompareTag("Green Cube"))
        {
            if (scale_counter == 0)
            {
                transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
                if (transform.localScale.y > 5f)
                {
                    scale_counter = 1;
                }
            }
            else
            {
                transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
                if (transform.localScale.y < 1f)
                {
                    scale_counter = 0;
                }
            }
        }

        else if (gameObject.CompareTag("Red Cube"))
        {

        }
    }
}
