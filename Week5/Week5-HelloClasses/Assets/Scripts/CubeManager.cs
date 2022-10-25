using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeManager : MonoBehaviour
{
    private Cube myCube;

    public Slider heightSlider;
    public Slider widthSlider;
    public Slider LengthSlider;

    public GameObject heightTextObject;
    public GameObject widthTextObject;
    public GameObject VolumeTextObject;
    public GameObject EdgeLengthTextObject;
    public GameObject LengthTextObject;

    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI VolumeText { get; set; }
    private TextMeshProUGUI EdgeLengthText { get; set; }
    private TextMeshProUGUI LengthText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        VolumeText = VolumeTextObject.GetComponent<TextMeshProUGUI>();
        EdgeLengthText = EdgeLengthTextObject.GetComponent<TextMeshProUGUI>();
        LengthText = LengthTextObject.GetComponent<TextMeshProUGUI>();

        // Calls basic constructor, but sets height and width to 0
        myCube = new Cube();

        GetValuesFromSliders();
    }

    // Update is called once per frame
    void Update()
    {
        heightText.text = "Cube Height: " + myCube.GetHeight().ToString();
        widthText.text = "Cube Width: " + myCube.GetWidth().ToString();
        VolumeText.text = "Cube Volume: " + myCube.GetVolume().ToString();
        EdgeLengthText.text = "Cube EdgeLength: " + myCube.GetEdgeLength().ToString();
        LengthText.text = "Cube Length: " + myCube.GetLength().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myCube.SetHeight(heightSlider.value);
        myCube.SetWidth(widthSlider.value);
        myCube.SetLength(LengthSlider.value);
    }
}

