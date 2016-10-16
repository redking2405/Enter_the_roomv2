using UnityEngine;
using System.Collections;

public class TirPlayerScript : MonoBehaviour {

    [SerializeField]

    float Forces = 15000.0f;

    [SerializeField]

    GameObject OriginBullet;

    [SerializeField]

    GameObject PrefabBullet;



    public bool CanShoot = true;


   private Vector3 Direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space)&&CanShoot)
        {


            Direction = OriginBullet.transform.forward;

            GameObject Bullet = (GameObject) Instantiate(PrefabBullet, OriginBullet.transform.position, Quaternion.identity);

            Bullet.GetComponent<Rigidbody>().AddForce(Direction * Forces);

            Bullet.GetComponent<BulletBehaviorScript>().Bullet = Bullet;

        }
	
	}
}
