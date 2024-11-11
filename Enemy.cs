using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalSpeed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime * 3f);
        if (transform.position.x < -11.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
