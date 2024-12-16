using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePickup : MonoBehaviour
{
    public MonsterController monster; 

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            
            monster.MakeStronger(50f, 5f, 4f);

            
            Destroy(gameObject);
        }
    }
}
