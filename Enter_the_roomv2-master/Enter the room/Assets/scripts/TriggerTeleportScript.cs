using UnityEngine;
using System.Collections;

public class TriggerTeleportScript : MonoBehaviour {

    [SerializeField]

    GameObject Destination;

    

    

    
    void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.layer==8)
        {

            Other.gameObject.transform.position = Destination.transform.position;
           
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
