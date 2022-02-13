using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour {
    [SerializeField] int life = 1;
    int currentLife;
    [SerializeField] GameObject gameObj;
    [SerializeField] float restartTime= 3f;

    [SerializeField] private PlayerBehaviour _player;

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

    private void DestroyMe(GameObject obj){
        StartCoroutine(RestartScene());
	    // Destroy(obj);
    }

    IEnumerator RestartScene(){
        yield return new WaitForSeconds(restartTime);
        PlayerStats.instance.savedPlayerLife --;
        SceneCaller.CallScene(SceneManager.GetActiveScene().name);
    }
}
