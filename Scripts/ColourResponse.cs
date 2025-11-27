using UnityEngine;

public class ColourResponse : MonoBehaviour
{
  public Color detected_color = Color.green;
  public Color lost_color = Color.red;

  private Renderer rend;

  private void Awake()
  {
    rend = GetComponent<Renderer>();
  }

  // 👉 MÉTODO PARA "On Target Found"
  public void SetDetectedColor()
  {
    rend.material.color = detected_color;
    Debug.Log("EVENTO → target encontrado (SetDetectedColor)");
  }

  // 👉 MÉTODO PARA "On Target Lost"
  public void SetLostColor()
  {
    rend.material.color = lost_color;
    Debug.Log("EVENTO → target perdido (SetLostColor)");
  }
}
