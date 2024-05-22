using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] private GameObject[] bullet;
    [SerializeField] private Transform shootPoint;
    [SerializeField] protected int CountBullet;
    [SerializeField] protected float coolDawn;

    private bool canShoot = true;

    protected virtual void GetDisparo(int bulletType)
    {
        if (CountBullet > 0 && canShoot)
        {
            StartCoroutine(Shoot(bulletType));         
        } 
    }

    private IEnumerator Shoot(int bulletType)
    {
        canShoot = false;

        GameObject obj = Instantiate(bullet[bulletType]);
        obj.transform.position = shootPoint.position;
        obj.GetComponent<BulletPlayer>().SetDirection(shootPoint.up);
        CountBullet--;

        yield return new WaitForSeconds(coolDawn);//espera del disparo

        canShoot = true; //activacion del disparo
    }
}
