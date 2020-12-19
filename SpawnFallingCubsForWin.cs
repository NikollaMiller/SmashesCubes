using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFallingCubsForWin : MonoBehaviour
{
    public GameObject[] cubs;
    public Animator[] editObjects;
    public GameObject[] editobjectss;
    public Transform NeutralPos;
    public Animator rotatkemenka;
    public GameObject RotatkeMenu;
    private bool najal;

    public void SpawnToStartAndSpawn() 
    {
        Invoke("Spawnka",1);

        for (int i = 0; i < editObjects.Length; i++)
        {
            editObjects[i].SetInteger("Lvlanka",2);
        }
        rotatkemenka.SetInteger("Triangles", 1);
        Invoke("CloseRotatkeMenka", 1);
        Invoke("delte",1);
    }

    private void delte() 
    {
        for (int i = 0; i < editobjectss.Length; i++)
        {
            editobjectss[i].SetActive(false);
        }
    }

    private void Spawnka() 
    {
         for (int i = 0; i < cubs.Length; i++)
         {
                var cell = Instantiate(cubs[i],NeutralPos);
                cell.transform.localPosition = new Vector3(0,0,0);
         }
    }

    private void CloseRotatkeMenka()
    {
        RotatkeMenu.SetActive(false);
    }
}
