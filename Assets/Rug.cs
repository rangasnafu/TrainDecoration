using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rug : MonoBehaviour
{
    public GameObject rugOption1;
    public GameObject rugOption2;

    public GameObject dottedLine;

    public void paintingOptionOne()
    {
        rugOption1.SetActive(true);
        rugOption2.SetActive(false);
        dottedLine.SetActive(false);
    }

    public void paintingOptionTwo()
    {
        rugOption1.SetActive(false);
        rugOption2.SetActive(true);
        dottedLine.SetActive(false);
    }
}
