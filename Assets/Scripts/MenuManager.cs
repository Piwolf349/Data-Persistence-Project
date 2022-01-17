using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public TMP_InputField inputField;
    public static string playerName;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName()
    {
        playerName = inputField.GetComponent<TMP_InputField>().text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    // reste à s'assurer que le playerName est DontDestroyOnLoad pour le passer entre les scènes.

}
