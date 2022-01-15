using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {
	[SerializeField] Animator anim;
	[SerializeField] internal string groundParam;
	[SerializeField] internal string walkingParam;
	[SerializeField] internal string RunningParam;
 	[SerializeField] internal string jumpingParam;
	[SerializeField] internal string speedParam;

	[SerializeField] private PlayerBehaviour _playerBehaviour;

	internal void SetAnimationTriggers(string triggerName) {
		anim.SetTrigger(triggerName);
	}
	internal void SetBolleans(string booleanName, bool booleanStage) {
		anim.SetBool(booleanName, booleanStage);
	}

	internal void SetAnimationFloat(string floatName, float floatValue) {
		anim.SetFloat(floatName, floatValue);
	}
}
