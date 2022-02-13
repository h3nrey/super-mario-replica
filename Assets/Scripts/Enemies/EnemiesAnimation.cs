using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void SetAnimationTriggers(string triggerName) {
		anim.SetTrigger(triggerName);
	}
}
