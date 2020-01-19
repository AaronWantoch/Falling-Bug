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

    // Start is called before the first frame update
    void Start()
    {
        Singleton();

        player = FindObjectOfType<PlayerMovement>();
        player.enabled = false;

        StartCoroutine(SwapTexts());
    }

    private void Singleton()
    {
        DontDestroyOnLoad(this.gameObject);
        if (FindObjectsOfType<Menu>().Length > 1)
            Destroy(this.gameObject);
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
