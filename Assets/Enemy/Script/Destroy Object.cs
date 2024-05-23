using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] private float timer;
    private void Update()
    {
        Destroy(gameObject, timer);
    }
}
