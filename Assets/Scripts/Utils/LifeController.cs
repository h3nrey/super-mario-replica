using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour {
    [SerializeField] int life = 1;
    int currentLife;
    [SerializeField] GameObject gameObj;

    void Start() {
        life = currentLife;
    }    
    internal void TakeDamage(int damage = 1){
        if(currentLife > 0) {
	 	    currentLife -= damage;
	    } else {
		    DestroyMe(gameObj);
	    }
    }

    void DestroyMe(GameObject obj){
	    Destroy(obj);
    }
}
