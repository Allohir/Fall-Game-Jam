using System.Collections;
using UnityEngine;
using TMPro;

public class TextTypingEffect : MonoBehaviour
{
    [SerializeField]
    private float typingSpeed = 0.03f;
    private string fullText;
    private string currentText = "";

    void Start()
    {
        fullText = this.GetComponent<TMP_Text>().text;
        GetComponent<TMP_Text>().text = "";
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (int i = 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            GetComponent<TMP_Text>().text = currentText;
            yield return new WaitForSeconds(typingSpeed);
        }

        GetComponent<TMP_Text>().text = fullText;
    }
}
