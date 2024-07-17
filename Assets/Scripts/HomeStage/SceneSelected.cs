using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelected : MonoBehaviour
{
    public void UploadASceneApplePicker()
    {
        SceneManager.LoadScene("ApplePicker");
    }

    public void UploadASceneShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void UploadASceneHomeOffice()
    {
        SceneManager.LoadScene("HomeOffice");
    }

    public void UploadASceneHomeStage()
    {
        SceneManager.LoadScene("HomeStage");
    }

    public void ClearProgress()
    {
        PlayerPrefs.DeleteAll();
    }

}

