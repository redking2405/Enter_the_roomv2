using UnityEngine;
using System.Collections;

public class Doortriggerscript : MonoBehaviour {

    [SerializeField]

    GameObject Door;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            Door.GetComponent<DoorBehaviorScript>().DoorOpen = true;

        }
    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            Door.GetComponent<DoorBehaviorScript>().DoorOpen = false;
        }
    }



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
