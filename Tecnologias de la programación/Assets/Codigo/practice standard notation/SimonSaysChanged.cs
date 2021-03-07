using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimonSaysChanged : MonoBehaviour
{
    public Image counter;

    public GameObject gameManager; 

    public List<Color> colors; 

    public int numberOfColors; 
    public int showColor; 

    public int disappear; 
    public Text dissapearText; 

    public List<int> sequence;

    public Text levelText;

    void Start()
    {
        sequence = new List<int>();
        StartCoroutine(Starten());
    }

    public void Generator()
    {
        numberOfColors++;

        levelText.text = "Level: " + numberOfColors;

        sequence.Add(Random.Range(0, 4));

        Preview();
    }

    public void Preview()
    {
        if (sequence.Count <= showColor)
        {
            counter.color = Color.white;
            showColor = 0;
            disappear = sequence.Count;
            dissapearText.text = disappear.ToString();
            gameManager.SetActive(false);
        }
        else
        {
            counter.color = colors[sequence[showColor]];

            StartCoroutine(NextColor());
        }
    }

    public void ButtonOfColors(int ID)
    {
        if (ID == sequence[showColor])
        {
            showColor++;
            disappear--;
            dissapearText.text = disappear.ToString();

            if (showColor == sequence.Count)
            {
                gameManager.SetActive(true);
                dissapearText.text = "";
                disappear = 0;
                showColor = 0;
                StartCoroutine(Starten());
            }
        }
        else
        {
            dissapearText.text = "error";
            Time.timeScale = 0;
        }

    }

    public void Reboot()
    {
        sequence = new List<int>();
        numberOfColors = 0;
        levelText.text = "Level" + numberOfColors;
        StartCoroutine(Starten());
    }

    IEnumerator Starten()
    {
        yield return new WaitForSeconds(0.01f);

        Generator();
    }

    IEnumerator NextColor()
    {
        if (numberOfColors == 8)
        {
            SceneManager.LoadScene("Library");
        }

        yield return new WaitForSeconds(0.5f);

        counter.color = Color.white;

        yield return new WaitForSeconds(0.7f);

        showColor++;

        Preview();



    }

    public void Retry()
    {
        SceneManager.LoadScene("SimonSays");
        Time.timeScale = 1;
    }

    public void Exit()
    {
        SceneManager.LoadScene("Library");
        Time.timeScale = 1;
    }
}
