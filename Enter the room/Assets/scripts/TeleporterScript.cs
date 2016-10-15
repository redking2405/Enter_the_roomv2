using UnityEngine;
using System.Collections;

public class TeleporterScript : MonoBehaviour {

    [SerializeField]

    GameObject Destination;

 

    public bool isActivated=false;

    public TirPlayerScript CanShoot;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            CanShoot = Other.gameObject.GetComponent<TirPlayerScript>();
            CanShoot.CanShoot = false;
        }
    }

    void OnTriggerStay(Collider Other)
    {
        if(Input.GetKeyDown(KeyCode.Space)&&isActivated)
        {
            Other.gameObject.transform.position = Destination.transform.position;
        }
    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            CanShoot = Other.gameObject.GetComponent<TirPlayerScript>();
            CanShoot.CanShoot = true;
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
