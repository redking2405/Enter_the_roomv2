using UnityEngine;
using System.Collections;

public class Room3Script : MonoBehaviour {

    [SerializeField]

    GameObject Target;

    [SerializeField]

    GameObject target1;

    [SerializeField]

    GameObject target2;

    [SerializeField]

    GameObject Door;

   

    public bool target1shot = false;
    public bool target2shot = false;
    public bool target3shot = false;
    public bool keypresent = false;

    private GameObject[] targets = new GameObject[3];	
    // Use this for initialization
	void Start () {
        targets.SetValue(Target, 0);
        targets.SetValue(target1, 1);
        targets.SetValue(target2, 2);
	}
	
	// Update is called once per frame
	void Update () {
       
        if (targets[0].GetComponent<TargetScript>().IsShot)
        {
            target1shot = true;
            

            if (targets[1].GetComponent<TargetScript>().IsShot && target1shot)
            {
                target2shot = true;

                if(targets[2].GetComponent<TargetScript>().IsShot && target1shot && target2shot)
                {
                    target3shot = true;

                   
                }
            }

            else if (targets[2].GetComponent<TargetScript>().IsShot && target1shot)
            {
                
                targets[2].GetComponent<TargetScript>().IsShot=false;
                targets[1].GetComponent<TargetScript>().IsShot=false;
                targets[0].GetComponent<TargetScript>().IsShot=false;
                target2shot = false;
                target1shot = false;
                target3shot = false;

            }
        }

        else if (targets[1].GetComponent<TargetScript>().IsShot && !target1shot)
        {
            
            
            targets[1].GetComponent<TargetScript>().IsShot =false;
           
            target2shot = false;
            target3shot = false;
            target1shot = false;

        }

        else if (targets[2].GetComponent<TargetScript>().IsShot && !target1shot && !target2shot)
        {
            

            targets[2].GetComponent<TargetScript>().IsShot = false;
            target2shot = false;
            target3shot = false;
            target1shot = false;
        }

        if (target1shot&&target2shot&&target3shot&&!keypresent)
        {
            Door.GetComponent<DoorBehaviorScript>().DoorOpen = true;
            keypresent = true;
        }
    }

  
    
}
