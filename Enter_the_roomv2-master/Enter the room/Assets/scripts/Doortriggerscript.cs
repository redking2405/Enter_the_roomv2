using UnityEngine;
using System.Collections;

public class Doortriggerscript : MonoBehaviour {

    [SerializeField]

    GameObject Door;

    public GameObject DoorTrigger;
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            Door.GetComponent<DoorBehaviorScript>().DoorOpen = true;
            Destroy(DoorTrigger);

        }
    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
