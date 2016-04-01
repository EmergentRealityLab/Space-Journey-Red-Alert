using UnityEngine;
using System.Collections;

public class EngineControl : MonoBehaviour {
	public Engines engine;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)){
			if (Camera.main == null) {
				print ("Shit's fucked yo");
			}
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

		
			if(Physics.Raycast(ray, out hit)){
				print("hi");
			}
		}

	
	}


}
