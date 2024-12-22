using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject m_spawner1;
    [SerializeField] private GameObject m_spawner2;

    private void Start()
    {
        StartCoroutine(Spawner1());
    }

    private IEnumerator Spawner1()
    {
        yield return new WaitForSeconds(30f);
        m_spawner1.SetActive(true);

        yield return new WaitForSeconds(60f);
        m_spawner2.SetActive(true);

    }
}
