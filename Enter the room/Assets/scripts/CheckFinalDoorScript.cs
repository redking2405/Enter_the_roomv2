using UnityEngine;
using System.Collections;

public class CheckFinalDoorScript : MonoBehaviour {

    private int NumKeyRequired = 3;

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.layer == 8)
        {
            if (Other.gameObject.GetComponent<PlayerKeyControlScript>().NumKey < NumKeyRequired)
            {
                Debug.Log("Il manque des clés");
            }

            else if (Other.gameObject.GetComponent<PlayerKeyControlScript>().NumKey == NumKeyRequired)
            {
                Debug.Log("Vous avez gagné!");
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
