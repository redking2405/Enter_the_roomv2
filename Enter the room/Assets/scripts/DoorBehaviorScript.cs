using UnityEngine;
using System.Collections;

public class DoorBehaviorScript : MonoBehaviour {

    public bool DoorOpen = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (DoorOpen)
        {
            Debug.Log("La porte est ouverte");
        }
	
	}
}
