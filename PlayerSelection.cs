using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelection : MonoBehaviour
{
    public List<GameObject> prefabsList;
   // public List<CapsuleCollider> colliderList;
    public int i =0;
    public void NextPlayer()
    {
        if (i < prefabsList.Count - 1)
        {
            i += 1;
        }
        else i = 0;

        foreach (GameObject prefab in prefabsList)
        {
            prefab.SetActive(false);
        }
        //foreach (CapsuleCollider col in colliderList)
        //{
        //    col.enabled = false;
        //}
        prefabsList[i].SetActive(true);
      //  colliderList[i].enabled = true;

    }
    public void PrevPlayer()
    {
        if (i > 0)
        {
            i -= 1;
        }
        else i = prefabsList.Count - 1;

        foreach (GameObject prefab in prefabsList)
        {
            prefab.SetActive(false);
        }
        //foreach (CapsuleCollider col in colliderList)
        //{
        //    col.enabled = false;
        //}

        prefabsList[i].SetActive(true);
        //colliderList[i].enabled = true;
    }
}
