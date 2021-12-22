using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texts : MonoBehaviour
{
    public Text healthText;
    public Text levelText;
    public Text x;
    public Text y;
    public Text z;

    
    private void Update()
    {
        healthText.text = Player.Instance.health.ToString();
        levelText.text = Player.Instance.level.ToString();
        x.text = Player.Instance.transform.position.x.ToString();
        y.text = Player.Instance.transform.position.y.ToString();
        z.text = Player.Instance.transform.position.z.ToString();
    }
}
