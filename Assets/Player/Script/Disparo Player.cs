using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPlayer :Arma
{
    void Update()
    {
        ContadorBalas();
    }

    protected virtual void ContadorBalas()
    {
        if (CountBullet > 0)
        {
            if (Input.GetMouseButton(0))
            {
                GetDisparo(0);
            }

            if (Input.GetMouseButton(1))
            {
                GetDisparo(1);
            }
        }
    }
}
