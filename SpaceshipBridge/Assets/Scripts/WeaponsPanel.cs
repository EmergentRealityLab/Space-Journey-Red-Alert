using UnityEngine;
using System.Collections;

public class WeaponsPanel : MonoBehaviour {

    GameObject missile;

	// Use this for initialization
	void Start () {
        missile = Resources.Load<GameObject>("Prefabs/Missile");
	}
	
	// Update is called once per frame
	void Update () {

        //Fire missile on mouse click
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FireMissile();
        }
	}

    void FireMissile()
    {
        Instantiate(missile);
    }
}
