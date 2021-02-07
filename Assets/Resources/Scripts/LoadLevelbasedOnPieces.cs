using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelbasedOnPieces : MonoBehaviour
{

    public static bool TraditionalPiecesLoad = false;
    public static bool RoboticPiecesLoad = false;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGameTradPieces()
    {
        TraditionalPiecesLoad = true;
        SceneManager.LoadScene("Scene2");
    }

    public void StartGameRoboPieces()
    {
        RoboticPiecesLoad = true;
        SceneManager.LoadScene("Scene2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
