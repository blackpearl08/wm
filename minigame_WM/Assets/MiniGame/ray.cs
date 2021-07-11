using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ray : MonoBehaviour
{
    public GameObject block;
    public float k;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hitinfo;


        float v = Mathf.Abs((block.transform.position - Camera.main.transform.position).magnitude);
        //Debug.Log(v);
        print(v);
        if (v <= k)
        {

            if (Physics.Raycast(ray, out hitinfo))
            {
                //큐브인가?

                if (hitinfo.collider.gameObject.name == "Treasure1")
                {
                    //UI 띄운다.
                    button.SetActive(true);
                }
                else
                {
                    button.SetActive(false);

                }
            }
            
        }
        else
        {
            button.SetActive(false);
        }
    }
}
