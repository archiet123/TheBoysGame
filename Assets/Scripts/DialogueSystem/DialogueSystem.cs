using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    //GameObjects
    public GameObject Prompt;
    public GameObject panel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    //sentence list
    private Queue<string> sentences;

    //bools
    [SerializeField] public bool DialogueEnded = false;

    void Start()
    {
        panel.SetActive(false);
        sentences = new Queue<string>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
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
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char Letter in sentence.ToCharArray())
        {
            dialogueText.text += Letter;
            yield return null;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        sentences = new Queue<string>();
        panel.SetActive(false);
        Prompt.SetActive(true);
        dialogueText.text = "";
        nameText.text = "";
        DialogueEnded = false;
        FindObjectOfType<PlayerInteract>().GetBool(DialogueEnded);
        Debug.Log("EndDialogue");
    }
}

