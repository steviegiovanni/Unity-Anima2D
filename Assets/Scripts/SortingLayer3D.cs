using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingLayer3D : MonoBehaviour {
	public string sortingLayer;

	// Use this for initialization
	void Start () {
		
		MeshRenderer meshRenderer = GetComponent<MeshRenderer> ();
		if (meshRenderer) {
			Debug.Log ("reached");
			meshRenderer.sortingLayerName = sortingLayer;
			meshRenderer.sortingOrder = -99;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
