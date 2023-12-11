using UnityEngine;

public class WhenCoinCollected : MonoBehaviour
{
    [SerializeField]
    GameObject text;

    TextMesh myText;

    int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        myText = text.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "model(Clone)")
        { 
            other.gameObject.SetActive(false);
            coins += 1;
            myText.text = "Coins: " + coins;
        }
    } 
}
