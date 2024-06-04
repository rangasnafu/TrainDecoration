using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting1 : MonoBehaviour
{
    public GameObject paintingOption1;
    public GameObject paintingOption2;
    public GameObject paintingOption3;

    public GameObject dottedLine;

    public void paintingOptionOne()
    {
        paintingOption1.SetActive(true);
        paintingOption2.SetActive(false);
        paintingOption3.SetActive(false);
        dottedLine.SetActive(false);
    }

    public void paintingOptionTwo()
    {
        paintingOption1.SetActive(false);
        paintingOption2.SetActive(true);
        paintingOption3.SetActive(false);
        dottedLine.SetActive(false);
    }

    public void paintingOptionThree()
    {
        paintingOption1.SetActive(false);
        paintingOption2.SetActive(false);
        paintingOption3.SetActive(true);
        dottedLine.SetActive(false);
    }
}
