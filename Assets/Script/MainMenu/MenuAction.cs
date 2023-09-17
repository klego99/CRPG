using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAction : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject trainingMenu;
    [SerializeField] GameObject fightMenu;
    [SerializeField] GameObject character;
    [SerializeField] GameObject healthBar;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(true);
        trainingMenu.SetActive(false);
        fightMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MyInfo()
    {
        
    }
    public void Training()
    {
        menu.SetActive(false);
        trainingMenu.SetActive(true);
    }
    public void Store()
    {

    }
    public void Equipment()
    {

    }
    public void Event()
    {

    }
    public void Fight()
    {
        menu.SetActive(false);
        trainingMenu.SetActive(false);
        fightMenu.SetActive(true);
    }
    public void Backward()
    {
        menu.SetActive(true);
        trainingMenu.SetActive(false);
        fightMenu.SetActive(false);
    }
}
