using UnityEngine;

public class CreateCoinScript : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    [SerializeField]
    int numberOfCoins;

    float planeSize = 45f;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstantiateCoins()
    {
        for (int i = 0; i < numberOfCoins; i++)
        {
            // Generate random positions for coins on the plane
            float randomX = Random.Range(-planeSize / 2, planeSize / 2);
            float randomZ = Random.Range(-planeSize / 2, planeSize / 2);

            Vector3 randomPosition = new Vector3(randomX, 0.5f, randomZ); // Assuming Y = 0.5 is the height above the plane
            // Instantiate the coin prefab at the random position
            GameObject result = Instantiate(prefab, randomPosition, Quaternion.identity);
            result.transform.eulerAngles = new Vector3(0, 0, 90);
            result.transform.position += new Vector3(0, 1, 0);
            Rigidbody coinRigidbody = result.AddComponent<Rigidbody>();
            coinRigidbody.isKinematic = true;
            MeshCollider coinMeshCollider = result.AddComponent<MeshCollider>();
            coinMeshCollider.convex = true;
            coinMeshCollider.isTrigger = true;
        }
    }
}
