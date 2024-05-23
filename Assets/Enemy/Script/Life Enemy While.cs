using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEnemy : Life
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet While"))
        {
            ChangeLife(other.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);
        }
    }
}
