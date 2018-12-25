using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWave : MonoBehaviour {

    [SerializeField, Range(0.01f, 360f)]
    float _amp = 0.1f;

    [SerializeField, Range(0.01f, 100f)]
    float _freq = 0.1f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.localEulerAngles = new Vector3(0f, Mathf.Sin(Time.time * _freq) * _amp, 0f);

	}
}
