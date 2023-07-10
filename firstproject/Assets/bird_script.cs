using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bird_script : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D my_rigid_body;
    public float flap_strength = 12;
    public logic_script logic;
    public bool bird_is_alive = true;
    void Start()
    {
        gameObject.name = "Cornelius";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) ||
            Input.GetMouseButtonDown(0)) &&
            (bird_is_alive == true))
        {
            my_rigid_body.velocity = Vector2.up * flap_strength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.game_over();
        bird_is_alive = false;
    }
}
