using UnityEngine;
using System.Collections;

public class DoorBehaviorScript : MonoBehaviour {

    public GameObject Door;

    public bool DoorOpen = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (DoorOpen)
        {
            Destroy(Door);
        }
	
	}
}
