using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public float zombieSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.zero - transform.position) * Quaternion.Euler(0,0,90);
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.zero, zombieSpeed * Time.deltaTime);
    }
}
