using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyCollection 
{
    [SerializeField] private List<GameObject> enemies;
    public List<GameObject> Enemies {  get { return enemies; } }
}
