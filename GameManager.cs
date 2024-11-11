using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, transform.position, Quaternion.identity);
        InvokeRepeating("CreateEnemy", 2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateEnemy()
    {
        Instantiate(Enemy, new Vector3(8f, Random.Range(-6f, 6f), 0),
        Quaternion.identity);
    }
}
