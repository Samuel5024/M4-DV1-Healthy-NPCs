using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    private Slider _slider;
    
    private void Start()
    {
        _slider = getComponentInChildren<Slider>();
        GetComponentInParent<NPC>.OnHPPctChanged += HandlePPctChanged;
    }

    private void HandleHPPctChanged(float pct)
    {
        _slider.value = pct;
    }
}
