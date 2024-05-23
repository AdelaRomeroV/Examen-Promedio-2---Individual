using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeEnemyBlack : Life
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet Black"))
        {
            ChangeLife(-other.gameObject.GetComponent<Damage>().GetDamage());
            Destroy(other.gameObject);
        }
    }
}
