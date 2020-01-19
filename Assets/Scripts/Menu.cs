using System.Collections;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textObject;

    [SerializeField] string firstText;

    [SerializeField] string secondText;

    [SerializeField] float interval = 1f;

    PlayerMovement player;

    static int instances;

    // Start is called before the first frame update
    void Start()
    {
        instances++;
        if (instances > 1)
        {
            Destroy(this.gameObject);
            return;
        }
            

        player = FindObjectOfType<PlayerMovement>();
        player.enabled = false;

        StartCoroutine(SwapTexts());
    }

    IEnumerator SwapTexts()
    {
        while(true)
        {
            textObject.SetText(firstText);
            yield return new WaitForSeconds(interval);
            textObject.SetText(secondText);
            yield return new WaitForSeconds(interval);
        }
    }

    public void StartGame()
    {
        player.enabled = true;

        this.gameObject.SetActive(false);
    }
}
