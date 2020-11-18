using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{
    private const string display = "Fps {0}";
    private const float fpsMeasurePeriod = 0.5f;
    private int m_CurrentFps;
    private int m_FpsAccumulator = 0;
    private float m_FpsNextPeriod = 0;
    private Text m_Text;

    private void Start()
    {
        m_FpsNextPeriod = Time.realtimeSinceStartup + fpsMeasurePeriod;
        m_Text = GetComponent<Text>();
    }

    private void Update()
    {
        m_FpsAccumulator++;
        if (Time.realtimeSinceStartup > m_FpsNextPeriod)
        {
            m_CurrentFps = (int)(m_FpsAccumulator / fpsMeasurePeriod);
            m_FpsAccumulator = 0;
            m_FpsNextPeriod += fpsMeasurePeriod;
            m_Text.text = string.Format(display, m_CurrentFps);
        }
    }
}