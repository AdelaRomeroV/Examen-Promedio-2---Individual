using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private Vector3 dir;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SetDirection(Vector3 dir)
    {
        this.dir = dir;
    }

    private void Update()
    {
        rb.velocity = dir * speed;
        Destroy(gameObject,3f);
    }

}
