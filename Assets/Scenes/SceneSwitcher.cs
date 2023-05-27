using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{
    public string scene1 = "Scene1";
    public string scene2 = "Scene2";
    public float delay = 15f;
    public Text countdownText;  // obiekt Text do wyświetlania odliczania

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        StartCoroutine(SwitchScene());
    }

    IEnumerator SwitchScene()
    {
        while (true)
        {
            for (float timer = delay; timer >= 0; timer -= Time.deltaTime)
            {
                countdownText.text = timer.ToString("0");
                yield return null;
            }

            var currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene == scene1 ? scene2 : scene1);
        }
    }
}


