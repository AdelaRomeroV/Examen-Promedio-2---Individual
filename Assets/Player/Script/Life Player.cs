using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePlayer : Life
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BulletEnemy"))
        {
            ChangeLife(-other.gameObject.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);
        }
    }
}
