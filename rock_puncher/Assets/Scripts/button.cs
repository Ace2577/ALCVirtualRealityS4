using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public float oomphToGive;
    public float cost;
    public DamageCollider dCollider;
    void Start()
    {
        dCollider= GameObject.Find("XR Rig Full Body").GetComponent<DamageCollider>(;)
        oomphToGive=5.0f;
        cost=10;
    }
    void OnCollisionEnter(Collider collision)
    {
        if(Collision.CompareTag("Player"))
        {
            Damage==Damage+oomphToGive;
            cost+=5.0f;
        }
    }
}
