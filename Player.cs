using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float speed;
    private float horizontalScreenLimit;
    private float verticalScreenLimit;

    public GameObject Bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 6f;
        horizontalScreenLimit = 11.5f;
        verticalScreenLimit = 7.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
       transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);
        
        if (transform.position.x > horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit) 
        {
            transform.position = new Vector3(transform.position.x * -1, transform.position.y, 0);
        }
        if (transform.position.y > verticalScreenLimit || transform.position.y <= -verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y * -1, 0);
        }
    }

    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }

    void CoinPickup()
    {
        FindObjectOfType<Score>().ScorePlusOne();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            CoinPickup();
        }
    }
}
