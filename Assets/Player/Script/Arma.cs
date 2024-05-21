using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] private GameObject[] bullet;
    [SerializeField] private Transform shootPoint;
    [SerializeField] protected int CountBullet;

    protected virtual void GetDisparo(int bulletType)
    {
        if (CountBullet > 0)
        {
            GameObject obj = Instantiate(bullet[bulletType]);
            obj.transform.position = shootPoint.position;
            obj.GetComponent<BulletPlayer >().SetDirection(shootPoint.up);
            CountBullet--;
           
        } 
    }
}
