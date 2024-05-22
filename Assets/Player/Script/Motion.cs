using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody rb;

    private void Awake()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {

    }
}
