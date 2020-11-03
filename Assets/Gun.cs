using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private Animator anim;

    public int magBullets = 30;
    public int totalBullets = 200;
    public int currentBullets;

    public float damage = 10f;
    public float fireRate = 0.1f;
    public float range = 100f;

    public Transform shootPoint;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentBullets = magBullets;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        RaycastHit hit;

        if(Physics.Raycast(shootPoint.position, shootPoint.transform.forward, out hit, range)){

            Debug.Log(hit.transform.name + "Was hit");

        }

        anim.SetBool("Fire", true);

        currentBullets--;

        AnimatorStateInfo info = anim.GetCurrentAnimatorStateInfo(0);

        if(info.IsName("Fire")){

            anim.SetBool("Fire", false);

        }
    }
}
