using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesCollision : MonoBehaviour
{
    [SerializeField] internal  LifeController _life;
    [Header("Ground Checking")]
    [SerializeField] private Transform playerChecker;
    private bool hitted;
    [SerializeField] private LayerMask playerMask;
    [Range(0.1f, 0.5f)][SerializeField] private float playerCheckerRange = 0.5f;

    [Header("Gizmos")]
	[SerializeField] private Color32 corzinha;
     private void OnCollisionEnter2D(Collision2D other){
         if(other.gameObject.tag == "fire"){
            _life.TakeDamage();
         }
     }

    private void Update() {
        if(hitted)
        _life.TakeDamage();
    }

    private void FixedUpdate() {
        hitted = Physics2D.OverlapCircle(playerChecker.position, playerCheckerRange, playerMask);
    }

    void OnDrawGizmosSelected() {
		Gizmos.color = corzinha;
		Gizmos.DrawWireSphere(playerChecker.position, playerCheckerRange);
	}

}
