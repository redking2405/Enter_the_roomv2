using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

    public bool IsShot=false;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            Debug.Log("cible en haut");
            //lancer anim target down

        }


    }

    void OnTriggerExit(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            Debug.Log("La cible est en bas");
            //lancer anim target down
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
