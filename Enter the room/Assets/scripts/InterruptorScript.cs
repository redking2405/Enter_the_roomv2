using UnityEngine;
using System.Collections;

public class InterruptorScript : MonoBehaviour {

    [SerializeField]

    GameObject Interruptor;

    public bool IsActivated = false;

    void OnTriggerEnter(Collider Other)
    {
        if(Other.gameObject.tag == Interruptor.tag)
        {
            IsActivated = true;
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
