using System.Collections;
using UnityEngine;
using TMPro;

public class TriangleTrigger : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody2D m_rb;
    [SerializeField] private CharaController m_charaController;
    [SerializeField] private CharaAttack m_charaAttack;
    [SerializeField] private Jump m_jump;
    [SerializeField] private SpriteRenderer m_sprite;
    [SerializeField] private GameObject m_button;
    [SerializeField] private GameObject m_buttonMenu;
    [SerializeField] private ParticleSystem m_deathVFX;
    [SerializeField] private GameObject m_visuals;
    [SerializeField] private TriangleTrigger m_triangleTrigger;
    void Update()
    {
        //if (!IsGameOver())
        //{
        //    m_currentTimer += Time.deltaTime;
        //    float minutes = Mathf.FloorToInt(m_currentTimer / 60);
        //    float seconds = Mathf.FloorToInt(m_currentTimer % 60);

        //    m_timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        //}

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            StartCoroutine(C_Delay());
            //StartCoroutine(C_CameraShake());
            m_rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
            m_rb.gravityScale = 10f;
            m_charaController.enabled = false;
            m_charaAttack.enabled = false;
            m_jump.enabled = false;
            m_sprite.enabled = false;
            m_deathVFX.Play();
            m_visuals.SetActive(false);
            m_triangleTrigger.enabled = false;

        }
    }

    //public bool IsGameOver()
    //{
    //    if (!m_charaController) return true;
    //    if (!m_charaController.IsAlive) return true;
    //    return false;
    //}



    private IEnumerator C_Delay()
    {
        yield return new WaitForSeconds(5.5f);
        m_button.SetActive(true);
        m_buttonMenu.SetActive(true);
        yield return new WaitForSeconds(5f);
        m_deathVFX.Stop();
    }
    //private IEnumerator C_CameraShake()
    //{
    //    m_camera.transform.parent = m_deathVFX.transform;
    //    yield return new WaitForSeconds(5f);
    //    CameraShake.Instance.StartShaking(1f, Vector2.up * 1.5f);
    //    CameraShake.Instance.FreezeTime(0.1f, 0.05f);
    //    yield return new WaitForSeconds(0.5f);
    //    Destroy(m_deathVFX);
    //    Destroy(m_rb);
    //}
}
