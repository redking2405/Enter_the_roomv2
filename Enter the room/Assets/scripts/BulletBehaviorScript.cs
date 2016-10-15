using UnityEngine;
using System.Collections;

public class BulletBehaviorScript : MonoBehaviour {

    public GameObject Bullet;

    private bool Hastriggered = false;


    void OnTriggerEnter(Collider Other)
    {
        if(Other.gameObject.layer!=8)
        {
            Destroy(Bullet);
        }

        if (Other.gameObject.layer == 12 && !Hastriggered)
        {
            Other.gameObject.GetComponent<TargetScript>().IsShot = true;
            Hastriggered = true;
            
                
            
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
