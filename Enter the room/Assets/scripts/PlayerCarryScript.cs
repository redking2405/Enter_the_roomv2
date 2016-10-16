using UnityEngine;
using System.Collections;

public class PlayerCarryScript : MonoBehaviour {


    [SerializeField]
    GameObject Player;

    [SerializeField]
    GameObject OriginBullet;

    [SerializeField]
    GameObject ObjectDetector;

    public bool CanCarry = false;
    public bool IsCarrying = false;
    public GameObject Target;
    private bool flag = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyUp(KeyCode.Space)&&CanCarry&&flag)
        {
            flag = false;
           
            Target.transform.parent = Player.transform;
            Target.transform.position = OriginBullet.transform.position;
            IsCarrying = true;
            CanCarry = false;
        }

        else if(Input.GetKeyUp(KeyCode.Space)&&IsCarrying)
        {
            Target.transform.parent = null;
            Target.transform.position = ObjectDetector.transform.position;
            GetComponent<TirPlayerScript>().CanShoot = true;
            IsCarrying = false;
            flag = true;
            CanCarry = false;
            
        }
	}
}
