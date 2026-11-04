using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    private Slider _slider;
    
    private void Start()
    {
        _slider = GetComponentInChildren<Slider>();
        GetComponentInParent<NPC>().OnHPPctChanged += HandleHPPctChanged;
    }

    private void HandleHPPctChanged(float pct)
    {
        _slider.value = pct;
    }
}
