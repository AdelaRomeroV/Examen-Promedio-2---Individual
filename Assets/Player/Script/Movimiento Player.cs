using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : Motion
{
    protected override void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
       
        rb.velocity = new Vector3(transform.right.x * horizontal * speed, transform.up.y * vertical * speed);
    }
}
