using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    void Awake(){
        rb= GetComponent<Rigidbody>();
    }
    void Update(){
        float horizontal = Input.GetAxis("Vertical");
        rb.velocity= new Vector3(horizontal*2,rb.velocity.y,0);
    }
}
