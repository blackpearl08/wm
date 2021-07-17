using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Picking : MonoBehaviour
{
    void StartingM_ActiveFalse() { StartingMessage.SetActive(false); }
    void ErrorMessage_ActiveFalse() { ErrorMessage.SetActive(false); }
    void b_ActiveFalse() { b.SetActive(false); }
    void c_ActiveFalse() { c.SetActive(false); }
    void d_ActiveFalse() { d.SetActive(false); }
    void e_ActiveFalse() { e.SetActive(false); }

    public GameObject treasure_a;
    public GameObject treasure_b;
    public GameObject treasure_c;
    public GameObject treasure_d;
    public GameObject treasure_e;

        //= {treasure_a, treasure_b, treasure_c, treasure_d, treasure_e }
    //    = new GameObject[5];

    //treasures[1]= {treasure_a };

    //treasures = {treasure_a, treasure_b, treasure_c, treasure_d, treasure_e };
    

    public float k = 3;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;

    int flag = 0;

    public GameObject StartingMessage;
    public GameObject ErrorMessage;

    // Start is called before the first frame update
    void Start()
    {
        StartingMessage.SetActive(true);
        ErrorMessage.SetActive(false);
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
        
            if (Mathf.Abs((transform.position - treasure_a.transform.position).magnitude) <= k)
            {
                if (treasure_a.activeSelf == true && treasure_b.activeSelf == true && treasure_c.activeSelf == true && treasure_d.activeSelf == true && treasure_e.activeSelf == true)
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




        if (Mathf.Abs((transform.position - treasure_b.transform.position).magnitude) <= k)
        {
            if (treasure_b.activeSelf == true&& treasure_a.activeSelf == false)
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
            else if(treasure_a.activeSelf == true&& Input.GetButtonDown("Fire1"))
            { ErrorMessage.SetActive(true); Invoke("ErrorMessage_ActiveFalse", 3.0f); a.SetActive(false);
               
            }
        }




        

        if (Mathf.Abs((transform.position - treasure_c.transform.position).magnitude) <= k)
        {
            if (treasure_a.activeSelf == false && treasure_b.activeSelf == false&& treasure_c.activeSelf == true)
            {

                a.SetActive(true);




                if (Input.GetButtonDown("Fire1"))
                {
                    a.SetActive(false);
                    treasure_c.SetActive(false);



                    d.SetActive(true);
                    flag += 1;
                    Invoke("d_ActiveFalse", 3.0f);

                }


            }
            else
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    ErrorMessage.SetActive(true); Invoke("ErrorMessage_ActiveFalse", 3.0f); a.SetActive(false);
                }
                
            }
        }

        
        

        if (Mathf.Abs((transform.position - treasure_d.transform.position).magnitude) <= k)
        {
            if (treasure_d.activeSelf == true&& treasure_a.activeSelf == false&& treasure_b.activeSelf == false&& treasure_c.activeSelf == false)
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
            else
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    ErrorMessage.SetActive(true); Invoke("ErrorMessage_ActiveFalse", 3.0f); a.SetActive(false);
                }
            }

        }


        if (Mathf.Abs((transform.position - treasure_e.transform.position).magnitude) <= k)
        {
            if (treasure_a.activeSelf==false&& treasure_b.activeSelf == false && treasure_c.activeSelf == false && treasure_d.activeSelf == false&& treasure_e.activeSelf == true)
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
            else
            {
                if (Input.GetButtonDown("Fire1"))
                { ErrorMessage.SetActive(true); Invoke("ErrorMessage_ActiveFalse", 3.0f); a.SetActive(false); }
            }





        }

        if (flag == 5)
        {
            ErrorMessage_ActiveFalse();
        }

    }
}

   

     
