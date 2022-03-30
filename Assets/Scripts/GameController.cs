using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public static int _numGold = 0;
    public static float _numMetter = 0;
    // button
    public GameObject _continue;
    public GameObject _reStart;
    public Image _xam;
    // text
    public Text _txtNumGold;
    public Text _txtNumMetter;
    //final sorce
    public Image _imgFinalSocre;
    public Text _txtFinalMetter;
    public Text _txtFinalGold;


    private void Start()
    {
        _continue.SetActive(false);
        _reStart.SetActive(false);
        _xam.enabled = false;
        _imgFinalSocre.enabled = false;
        _txtFinalGold.enabled = false;
        _txtFinalMetter.enabled = false;
    }
    public void Update()
    {     
        _txtNumMetter.text = _numMetter +" m";
        _txtNumGold.text = _numGold.ToString();

    }
    public void LoadScence(string nameScence)
    {
        SceneManager.LoadScene(nameScence, LoadSceneMode.Single);
    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        _continue.SetActive(true);
        _xam.enabled = true;
   
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        _continue.SetActive(false);
        _xam.enabled = false;
       
    }
    
    public void GameOver()
    {
        Time.timeScale = 0f;
        _reStart.SetActive(true);
        _xam.enabled = true;
        // final
        _imgFinalSocre.enabled = true;
        _txtFinalGold.enabled = true;
        _txtFinalMetter.enabled = true;

        _txtFinalGold.text = _numGold.ToString();
        _txtFinalMetter.text = _numMetter + " m";

    }
    public void ReStart(GameObject _player)
    {

        _player.transform.position = new Vector3(-5f, -2.593f, 0f);
        _reStart.SetActive(false);
        _xam.enabled = false;
        _numGold = 0;
        _numMetter = 0;
        //final
        _imgFinalSocre.enabled = false;
        _txtFinalGold.enabled = false;
        _txtFinalMetter.enabled = false;
        Player._speed = 4f;
        Time.timeScale = 1f;
        
        
    }
   
}
