using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    [SerializeField, Range(0.1f, 100f)]
    float _rotVel = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(0f, Time.deltaTime * _rotVel, 0f));
		
	}
}
