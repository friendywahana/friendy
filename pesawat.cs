using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pesawat : MonoBehaviour
{
    public float SpeedH;
    public float SpeedV;

    public Transform posisiLaser;
    public GameObject laser;

    public Transform posisiLaser2;
    public GameObject laser2;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");


        Debug.Log(h);

        Vector3 posisi = new Vector3(h, 0, 0) * Time.deltaTime * SpeedH;

        transform.Translate(posisi);


        float v = Input.GetAxis("Vertical");

        Debug.Log(v);

        Vector4 posisi2 = new Vector4(0, v, 0) * Time.deltaTime * SpeedV;

        transform.Translate(posisi2);


        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject l = Instantiate(laser);
            l.transform.position = posisiLaser.position;

            Destroy(l, 5f);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject l = Instantiate(laser2);
            l.transform.position = posisiLaser2.position;

            Destroy(l, 5f);
        }
    }
}
