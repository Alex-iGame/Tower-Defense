using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour
{
    [HideInInspector] public Text _textLife;

    [SerializeField] [Range(0, 10)] private int Castle_Life;
    [SerializeField] [Range(0, 5)] private int Castle_Damage;
   



    private void Awake()
    {
        _textLife.text = Castle_Life.ToString();
    }


    private void Update()
    {
        CheckAndReloadScene();
       
    }



    public void Damage()
    {
        Castle_Life -= Castle_Damage;
        _textLife.text = Castle_Life.ToString();
    }

    private void CheckAndReloadScene()
    {

        if (Castle_Life <= 0)
        {
            SceneManager.LoadScene("Scenes/Game");
        }

    }
}