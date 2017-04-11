using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleFollow : MonoBehaviour {

	Vector3 diff;

	public GameObject target; // 追従ターゲット
	public float followSpeed;

	void Start () {
		diff = target.transform.position - transform.position; // 追従距離の計算
	}

	void LateUpdate () { // 全てのUpdate関数が終わった後に実行される
		// 線形補間関数によるスムージング
		transform.position = Vector3.Lerp (transform.position, target.transform.position - diff, Time.deltaTime * followSpeed);
	}
}
