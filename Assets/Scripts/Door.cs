using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public int lvlToLoad;
    private PlayCollectibles playerCollectibles;
    private BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        playerCollectibles = GameObject.FindWithTag("Player").GetComponent<PlayCollectibles>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollectibles.gemNumber >= 3)
        {
            boxCollider.enabled = true;
        }
    }

    private void LoadLevel()
    {
        SceneManager.LoadScene(lvlToLoad);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<BoxCollider2D>().enabled = false;
            other.GetComponent<GatherInput>().DisableControls();
            LoadLevel();
        }
    }

}
