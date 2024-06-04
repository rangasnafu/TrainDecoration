using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationSelection : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject painting1Camera;
    public GameObject painting2Camera;
    public GameObject rugCamera;

    public GameObject painting1UI;
    public GameObject painting2UI;
    public GameObject rugUI;

    public void Painting1()
    {
        mainCamera.SetActive(false);
        painting1UI.SetActive(true);
        painting1Camera.SetActive(true);
    }

    public void ExitPainting1()
    {
        mainCamera.SetActive(true);
        painting1UI.SetActive(false);
        painting1Camera.SetActive(false);
    }

    public void Painting2()
    {
        mainCamera.SetActive(false);
        painting2UI.SetActive(true);
        painting2Camera.SetActive(true);
    }

    public void ExitPainting2()
    {
        mainCamera.SetActive(true);
        painting2UI.SetActive(false);
        painting2Camera.SetActive(false);
    }

    public void Rug()
    {
        mainCamera.SetActive(false);
        rugUI.SetActive(true);
        rugCamera.SetActive(true);
    }

    public void ExitRug()
    {
        mainCamera.SetActive(true);
        rugUI.SetActive(false);
        rugCamera.SetActive(false);
    }
}
