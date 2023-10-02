using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{
  const float SPEED = 6f;
  
  [SerializedField]
  Transform SectionInfo;
  
  Vector3 desiredScale = Vector3.zero;
  
  void Update()
  {
    SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
  }
  
  public void OpenInfo()
  {
    desiredScale = Vector3.one;
  }
  
  public void CloseInfo()
  {
    desiredScale = Vector3.zero;
  }
