using UnityEngine;

public class WallTouching : MonoBehaviour
{
    [SerializeField]
    GameObject text;

    TextMesh myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = text.GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.name)
        {
            case "LeftWall":
                myText.text = "Last Touched Wall: " + "Left";
                break;
            case "RightWall":
                myText.text = "Last Touched Wall: " + "Right";
                break;
            case "FrontWall":
                myText.text = "Last Touched Wall: " + "Front";
                break;
            case "BackWall":
                myText.text = "Last Touched Wall: " + "Back";
                break;
            default:
                break;
        }
    }
}
