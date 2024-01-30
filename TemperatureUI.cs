using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class TemperatureUI : MonoBehaviour
{


    public class TemUi : MonoBehaviour
    {
        public Temperature temperature;
        public TextMeshProUGUI temperatureText;

        private void Update()
        {
            float rouTemp = Mathf.Round(temperature.tempNow * 10.0f) * 0.1f;
            temperatureText.text = rouTemp.ToString();

        }
    } 

    
}
