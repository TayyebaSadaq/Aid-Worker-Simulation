using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalDialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject info;
    public GameObject options;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        info.SetActive(false);
        options.SetActive(false);
        StartDialogue(); // Auto-start dialogue when the scene loads
    }

    // Method to be called by the UI button
    public void next()
    {
        if (textComponent.text == lines[index])
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            textComponent.text = lines[index];
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        textComponent.text = string.Empty; // Clear the text box before typing the next line

        // Type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false); // Hide the dialogue panel or perform another action when all lines are done
            info.SetActive(true);

        }
    }
}
