using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoruntineSample : MonoBehaviour
{
    [SerializeField] private GameObject gameoverPanel;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(timer());
    }

    private IEnumerator timer()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(1);

            gameoverPanel.SetActive(true);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
