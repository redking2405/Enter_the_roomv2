using UnityEngine;
using System.Collections;

public class PlayerMoveScript : MonoBehaviour {


    [SerializeField]

    float Speed = 10.0f;

    [SerializeField]

    float AnglePos = 5.0f;

    [SerializeField]

    float AngleNeg = -5.0f;

    [SerializeField]

    GameObject Player;

    private Vector3 Direction;

    
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Direction = Vector3.zero;
        

        if (Input.GetKey(KeyCode.Z))
        {
            Direction = Player.transform.forward;

            Player.transform.position += Direction * Speed * Time.deltaTime;
            

        }

        if(Input.GetKey(KeyCode.S))
        {
            Direction = -Player.transform.forward;

            Player.transform.position += Direction * Speed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.Q))
        {


            Player.transform.Rotate(-Vector3.up, AnglePos, Space.World);
        }

        if(Input.GetKey(KeyCode.D))
        {


            Player.transform.Rotate(Vector3.up, AngleNeg, Space.World);
        }
	
	}
}
