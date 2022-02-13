using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour {
    [SerializeField] int life = 1;
    int currentLife;
    [SerializeField] GameObject gameObj;
    [SerializeField] Collider2D coll;

    [SerializeField] EnemiesAnimation _enemiesAnimation;

    void Start() {
        life = currentLife;
    }    
    internal void TakeDamage(int damage = 1){
        if(currentLife > 0) {
	 	    currentLife -= damage;
	    } else {
		    StartCoroutine(DestroyMe(gameObj));
	    }
    }

    IEnumerator DestroyMe(GameObject obj){
        // coll.enabled = false;
        _enemiesAnimation.SetAnimationTriggers("hitted");
        yield return new WaitForSeconds(0.3f);
	    Destroy(obj);
    }
}
