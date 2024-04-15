using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Switch : MonoBehaviour
{
    public void PlayGame( )
    {
        SceneManager.LoadScene("Platformer1");
    }

    public void Scene2()
    {
        SceneManager.LoadScene("menu");
    }
}