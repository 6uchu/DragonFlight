using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartText : MonoBehaviour
{
    Text startText;
    Coroutine blinkCoroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startText = GetComponent<Text>();
        StartCoroutine(CntandStop(3));
        blinkCoroutine = StartCoroutine(BlinkText(0.5f));
    }

    //코루틴
    IEnumerator BlinkText(float interval)
    {
        while (true)
        {
            if (startText != null)
            {
                startText.enabled = !startText.enabled;
            }
            yield return new WaitForSeconds(interval);
        }
    }

    IEnumerator CntandStop(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            startText.text = "게임 시작까지 " + i + "초";
            yield return new WaitForSeconds(1f);
        }
        startText.text = "게임 시작!";
        yield return new WaitForSeconds(1f);

        StopCoroutine(blinkCoroutine);
        startText.enabled = false;
    }
}
