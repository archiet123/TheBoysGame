using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public GameObject Prompt;
    public GameObject panel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    private Queue<string> sentences;

    void Start()
    {
        panel.SetActive(false);
        sentences = new Queue<string>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        panel.SetActive(true);
        HidePrompt();
        nameText.text = dialogue.npc_name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
            Debug.Log("test");
        }

        DisplayNextSentence();
    }
    public void HidePrompt()
    {
        // DialogueManager.GetComponent<DialogueSystem>().StartDialogue(dialogue);
        Prompt.SetActive(false);
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue()
    {
        sentences = new Queue<string>();
        ;
        panel.SetActive(false);
        Prompt.SetActive(true);
        dialogueText.text = "";
        nameText.text = "";
    }
}
