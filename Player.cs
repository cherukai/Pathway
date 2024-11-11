using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variables
    //1. access level: public or private
    //2. type: int (e.g., 2, 4, 123, 3456, etc.), float (e.g, 2.5, 3.67, etc.)
    //3. name: (1) start w/ lowercase (2) if it is multiple words, then the other
    //4. optional: give it an initial value
    private float horizontalInput;
    private float verticalInput;
    private float speed;
   
    public GameObject bullet;
    BoxCollider myBodyCollider;
    // Start is called before the first frame update
    void Start()
    {
        speed = 6f;
        myBodyCollider = GetComponent<BoxCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        Moving();
        Shooting();
    }
    void Moving()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);

        if (transform.position.x > 11.5f || transform.position.x <= -11.5f)
        {
            transform.position = new Vector3(transform.position.x * -1,
            transform.position.y, 0);
        }
        if (transform.position.y > 1f || transform.position.y <= -6f)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y * -0, 0);
        }
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }

    void Die()
    {
       FindObjectOfType<GameSession>().ProcessPlayerDeath();
    }

    void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Enemy")
        {
            Die();
        }
    }
    



}

