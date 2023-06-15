using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float velocity;
    Rigidbody2D myRB2D;

    private void Start()
    {
        myRB2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float inputs = Input.GetAxis("Horizontal");
        myRB2D.velocity = new Vector2(inputs * velocity, myRB2D.velocity.y);


    }
}
