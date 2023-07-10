using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_move_script : MonoBehaviour
{
    public float move_speed = 5;
    // Start is called before the first frame update
    public float dead_zone = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + 
                             (Vector3.left * move_speed * Time.deltaTime);
        if (transform.position.x < dead_zone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}
