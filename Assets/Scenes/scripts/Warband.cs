using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarbandNamespace;

namespace WarbandNamespace
{
    public class Humanoid
    {
        public void Yell()
        {
            Debug.Log("Humanoid yelling");
        }
    }
    public class Enemy : Humanoid
    {
        new public void Yell()
        {
            Debug.Log("Enemy yelling");
        }
    }
    public class Orc : Enemy
    {
        new public void Yell()
        {
            Debug.Log("Orc yelling");
        }
    }
}
public class Warband : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var humanoid = new Humanoid();
        var enemy = new Enemy();
        var orc = new Orc();

        humanoid.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
