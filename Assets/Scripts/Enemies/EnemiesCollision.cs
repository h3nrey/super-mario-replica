using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCollision : MonoBehaviour
{
    [SerializeField] internal  LifeController _life;

    private void OnCollisionEnter2D(Collision2D other){
          if(other.gameObject.tag == "Player"){
             _life.TakeDamage();
          }
    }
}
