using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class textlocation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Camera;
    [SerializeField] TextMeshProUGUI PackageNotDeliveredText;
    public int score;
    public Delivery package;
    // Update is called once per frame
    void Update()
    {
        score = package.presentsNotDelivered;
        
        transform.position = Camera.transform.position +new Vector3 (5,5,-10);
        PackageNotDeliveredText.text = "Packages Left:" + score.ToString();
    }
    
}
