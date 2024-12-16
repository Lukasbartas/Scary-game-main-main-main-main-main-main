using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float health = 100f;
    public float damage = 10f;
    public float speed = 3f;

    
    public void MakeStronger(float healthBoost, float damageBoost, float speedBoost)
    {
        health += healthBoost;
        damage += damageBoost;
        speed += speedBoost;

        Debug.Log("Monster is now stronger!");
    }

    
    void Update()
    {
        
    }
}
