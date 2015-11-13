using UnityEngine;
using System.Collections;

public class bg_back : MonoBehaviour {
	// Use this for initialization
	void Start () {
		int enemycnt = 0 ;
		int enemymax = 100 ;
		if(enemycnt < enemymax) {
			for (; enemycnt < enemymax; enemycnt++) {
				Enemy.Add (Random.Range (100, 300), Random.Range (100, 300));
			}
			enemycnt--;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
