using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Picking : MonoBehaviour
{
    void StartingM_ActiveFalse
        ()
    { StartingMessage.SetActive(false); }
    void b_ActiveFalse() { b.SetActive(false); }
    void c_ActiveFalse() { c.SetActive(false); }
    void d_ActiveFalse() { d.SetActive(false); }
    void e_ActiveFalse() { e.SetActive(false); }

    public GameObject treasure_a;
    public GameObject treasure_b;
    public GameObject treasure_c;
    public GameObject treasure_d;
    public GameObject treasure_e;

    public float k = 3;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    int flag = 0;

    public GameObject StartingMessage;

    // Start is called before the first frame update
    void Start()
    {
        StartingMessage.SetActive(true);
        Invoke("StartingM_ActiveFalse", 4.0f);

        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        d.SetActive(false);
        e.SetActive(false);
        f.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (treasure_a.activeSelf == true)
        {
            if (Mathf.Abs((transform.position - treasure_a.transform.position).magnitude) <= k)
            {
                a.SetActive(true);




                if (Input.GetButtonDown("Fire1"))
                {
                    a.SetActive(false);
                    treasure_a.SetActive(false);


                    b.SetActive(true);
                    flag += 1;
                    Invoke("b_ActiveFalse", 3.0f);

                }






            }
        }
        if (treasure_e.activeSelf == true)
        {
            if (Mathf.Abs((transform.position - treasure_e.transform.position).magnitude) <= k)
            {
                a.SetActive(true);




                if (Input.GetButtonDown("Fire1"))
                {
                    a.SetActive(false);
                    treasure_e.SetActive(false);

                    f.SetActive(true);
                    Invoke("f_ActiveFalse", 3.0f);

                    flag += 1;
                }
            }






        }
        if (treasure_b.activeSelf == true)
        {
            if (Mathf.Abs((transform.position - treasure_b.transform.position).magnitude) <= k)
            {
                a.SetActive(true);




                if (Input.GetButtonDown("Fire1"))
                {
                    a.SetActive(false);
                    treasure_b.SetActive(false);



                    c.SetActive(true);
                    flag += 1;
                    Invoke("c_ActiveFalse", 3.0f);

                }






            }
        }
        if (treasure_c.activeSelf == true)
        {
            if (Mathf.Abs((transform.position - treasure_c.transform.position).magnitude) <= k)
            {
                a.SetActive(true);




                if (Input.GetButtonDown("Fire1"))
                {
                    a.SetActive(false);
                    treasure_c.SetActive(false);

                    d.SetActive(true);
                    Invoke("d_ActiveFalse", 3.0f);
                }






            }
        }
        if (treasure_d.activeSelf == true)
        {
            if (Mathf.Abs((transform.position - treasure_d.transform.position).magnitude) <= k)
            {
                a.SetActive(true);




                if (Input.GetButtonDown("Fire1"))
                {
                    a.SetActive(false);
                    treasure_d.SetActive(false);

                    e.SetActive(true);
                    Invoke("e_ActiveFalse", 3.0f);

                    flag += 1;
                }
            }
        
        }

    }
}

   

     
