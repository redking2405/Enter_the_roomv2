using UnityEngine;
using System.Collections;

public class ObjectDetectorScript : MonoBehaviour {

    public TirPlayerScript CanShoot;
    public PlayerCarryScript CanCarry;


    [SerializeField]

    GameObject Player;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.layer == 9)
        {
            CanShoot = Player.GetComponent<TirPlayerScript>();
            CanCarry = Player.GetComponent<PlayerCarryScript>();
            CanShoot.CanShoot = false;
            CanCarry.Target = Other.gameObject;
            CanCarry.CanCarry = true;
        }

        if (Other.gameObject.tag == "key")
        {
            Player.GetComponent<PlayerKeyControlScript>().AddKey();
            Destroy(Other.gameObject);
        }


    }

    void OnTriggerStay(Collider Other)
    {
        if (Other.gameObject.layer == 9)
        {
            CanCarry.Target = Other.gameObject;
        }
        
    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.layer == 9)
        {
            CanCarry = Player.GetComponent<PlayerCarryScript>();
            CanShoot = Player.GetComponent<TirPlayerScript>();
            CanCarry.CanCarry = false;
            if(!CanCarry.IsCarrying)
            {
                CanShoot.CanShoot = true;
                CanCarry.Target = null;
            }
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
