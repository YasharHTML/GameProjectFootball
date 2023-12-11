using UnityEngine;

public class GoalTrigger : MonoBehaviour
{

    [SerializeField]
    GameObject text;

    TextMesh myText;

    int goals = 0;

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
        if (other.name == "Ball")
        {
            goals += 1;
            myText.text = "Goals: " + goals;
            other.TryGetComponent<Rigidbody>(out Rigidbody rb);
            rb.velocity = new Vector3(0, 0, 0);
            other.transform.position = new Vector3(10, 1, 0);
        }
    }
}
