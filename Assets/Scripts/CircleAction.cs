using UnityEngine;
using UnityEngine.UIElements;

public class CircleAction : MonoBehaviour
{   //  UIDocumentをアタッチ
    [SerializeField] private UIDocument _uiDoc;
    //  移動させるボールをアタッチ
    [SerializeField] private Transform _circleTransform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var root = _uiDoc.rootVisualElement;

        var rightButton = root.Q<Button>("button-right");
        var leftButton = root.Q<Button>("button-left");
        rightButton.clicked+= () => _circleTransform.localPosition += Vector3.right * 0.1f;
        leftButton.clicked += () => _circleTransform.localPosition += Vector3.left * 0.1f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
