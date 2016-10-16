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
    private Vector3 Tartampion; 
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
            Tartampion = new Vector3(ObjectDetector.transform.position.x, 0.5f, ObjectDetector.transform.position.z);
            Target.transform.position = Tartampion;
            
            GetComponent<TirPlayerScript>().CanShoot = true;
            IsCarrying = false;
            flag = true;
            CanCarry = false;
            
        }
	}
}
