using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class OxygenBar1 : MonoBehaviour
{
    private Slider slider;
    public InformationManager iM;

    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
        SetMaxOxygenLevel(iM.GetMaxOxygenLevel());
    }

    public void SetMaxOxygenLevel(float maxLevel)
    {
        slider.maxValue = maxLevel;
        slider.value = maxLevel;
    }

    public void SetOxygenLevel(float level)
    {
        slider.value = level;
    }

    private void Update()
    {
        SetOxygenLevel(iM.GetOxygenLevel());
    }
}