using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogeManager : MonoBehaviour
{
    public TMP_Text dialogueText;
    public Button nextButton;
    public float letterDelay = 0.1f;

    public GameObject Close2Scene;
    public GameObject CloseScene;
    public GameObject NextScene;


    

    public AudioSource[] AudioSources;


    [SerializeField]
    string[] dialogues = new string[]
    {

    };

    private int currentDialogueIndex = 0;
    private bool isDisplaying = false;

    void Start()
    {
        nextButton.onClick.AddListener(NextDialogue);
        StartCoroutine(DisplayText(dialogues[currentDialogueIndex]));
    }

    public void NextDialogue()
    {
        if (!isDisplaying)
        {
            currentDialogueIndex++;
            if (currentDialogueIndex < dialogues.Length)
            {
                StartCoroutine(DisplayText(dialogues[currentDialogueIndex]));
                //if (AudioSources[currentDialogueIndex] != null)
                //    AudioSources[currentDialogueIndex].Play();


            }
            else
            {
                nextButton.interactable = false;
                NextScene.SetActive(true);
                CloseScene.SetActive(false);
                Close2Scene.SetActive(false);
            }
        }
    }

    IEnumerator DisplayText(string text)
    {
        isDisplaying = true;
        dialogueText.text = "";
        for (int i = 0; i < text.Length; i++)
        {
            dialogueText.text += text[i];
            yield return new WaitForSeconds(letterDelay);
        }
        isDisplaying = false;
    }
}