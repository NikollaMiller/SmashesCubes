using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawn : MonoBehaviour
{
    private bool platform;
    private bool tringle;
    private bool circle;
    private bool rigtht;
    private bool Left;

    public int PlatformCH;
    public int CircleCH;
    public int TriangleCH;

    public GameObject PlatfomB;
    public GameObject tringleB;
    public GameObject circleB;

    public GameObject SelectedPlat;
    public GameObject SelectedTrin;
    public GameObject SelectedSpher;

    public GameObject RotatkeMenu;

    public Animator rotatkemenka;

    public GameObject ForSelectedPlatform;
    public GameObject ForSelectedTriangle;
    public GameObject ForSelectedSphere;
    public Transform PositionForSpawn;

    public Text triangletrackBG;
    public Text platformtrackBG;
    public Text CircletravkBG;

    public Text platformtrack;
    public Text Circletravk;
    public Text triangletrack;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x,Input.mousePosition.y,1));

            if (Physics.Raycast(ray,out hit)) 
            {
                if (hit.transform.name == "Wall" && platform && PlatformCH > 0) 
                {
                    Instantiate(PlatfomB, hit.point,Quaternion.identity);
                    PlatformCH = PlatformCH - 1;
                }

                if (hit.transform.name == "Wall" && tringle && TriangleCH > 0)
                {
                    Instantiate(tringleB, hit.point, Quaternion.identity);
                    hit.transform.rotation *= Quaternion.Euler(0f, 0f, 0f);
                    TriangleCH = TriangleCH - 1;
                    RotatkeMenu.SetActive(true);
                }

                if (hit.transform.name == "Wall" && circle && CircleCH > 0)
                {
                    Instantiate(circleB, hit.point, Quaternion.identity);
                    CircleCH = CircleCH - 1;
                }
            }

            if (Physics.Raycast(ray, out hit)) 
            {
                if (hit.transform.tag == "Platform" && !platform)
                {
                    Destroy(hit.transform.gameObject);
                    PlatformCH = PlatformCH + 1;
                }

                if (hit.transform.tag == "Triangle" && !tringle)
                {
                    Destroy(hit.transform.gameObject);
                    TriangleCH = TriangleCH + 1;
                    rotatkemenka.SetInteger("Triangles",1);
                    Invoke("CloseRotatkeMenka",1);
                }

                if (hit.transform.tag == "Circle" && !circle)
                {
                    Destroy(hit.transform.gameObject);
                    CircleCH = CircleCH + 1;
                }
            }
            if (Left) 
            {
                if (Physics.Raycast(ray, out hit)) 
                {
                    if (hit.transform.tag == "Triangle")
                    {
                        hit.transform.rotation *= Quaternion.Euler(0f, 0f, 900f * Time.deltaTime);
                    }
                }
            }
            if (rigtht)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.tag == "Triangle")
                    {
                        hit.transform.rotation *= Quaternion.Euler(0f, 0f, -900f * Time.deltaTime);
                    }
                }
            }

        }

        platformtrack.text = "X" + PlatformCH;
        platformtrackBG.text = "X" + PlatformCH;
        CircletravkBG.text = "X" + CircleCH;
        Circletravk.text = "X" + CircleCH;
        triangletrackBG.text = "X" + TriangleCH;
        triangletrack.text = "X" + TriangleCH;      
    }


    private void CloseRotatkeMenka() 
    {
        RotatkeMenu.SetActive(false);
    }
    public void RotateToRight() 
    {
        rigtht = true;
        Left = false;
    }
    public void RotateToLeft()
    {
        rigtht = false;
        Left = true;
    }

    public void choosePlatform() 
    {
        platform = true;
        tringle = false;
        circle = false;

        SelectedPlat.SetActive(true);
        SelectedTrin.SetActive(false);
        SelectedSpher.SetActive(false);

        var cell = Instantiate(ForSelectedPlatform, PositionForSpawn);
        cell.transform.localPosition = new Vector3(0, 0, 0);
        ForSelectedPlatform.SetActive(true);
    }

    public void choosetringle()
    {
        tringle = true;
        platform = false;
        circle = false;
        var cell = Instantiate(ForSelectedTriangle, PositionForSpawn);
        cell.transform.localPosition = new Vector3(0, 0, 0);
        ForSelectedTriangle.SetActive(true);

        SelectedPlat.SetActive(false);
        SelectedTrin.SetActive(true);
        SelectedSpher.SetActive(false);
    }
    public void chooseCircle()
    {
        circle = true;
        tringle = false;
        platform = false;
        var cell = Instantiate(ForSelectedSphere, PositionForSpawn);
        cell.transform.localPosition = new Vector3(0, 0, 0);
        ForSelectedSphere.SetActive(true);

        SelectedPlat.SetActive(false);
        SelectedTrin.SetActive(false);
        SelectedSpher.SetActive(true);
    }

    public void DelBut() 
    {
        platform = false;
        tringle = false;
        circle = false;

        SelectedPlat.SetActive(false);
        SelectedSpher.SetActive(false);
        SelectedTrin.SetActive(false);
    }

    
}
