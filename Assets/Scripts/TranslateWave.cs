using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateWave : MonoBehaviour {

    [SerializeField, Range(0.1f, 10f)]
    float _dist = 1f;

    [SerializeField, Range(0.1f, 10f)]
    float _speed = 1f;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.localPosition = new Vector3(0f, 0f, _dist * Mathf.Sin(Time.time * _speed));


	}
}
