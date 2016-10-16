using UnityEngine;
using System.Collections;

public class DoorBehaviorScript : MonoBehaviour {

    public GameObject Door;

    public bool DoorOpen = false;

    public float Distance = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (DoorOpen)
        {
            Door.transform.Translate(Vector3.up*Distance, Space.World);
        }
	
	}
}
