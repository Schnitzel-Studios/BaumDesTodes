using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTree : MonoBehaviour
{
    public float trunkSegments =  3;
    public float trunkHeight =  3;
    public float maxBranches = 3;
    public float branchLength = 1;
    [Range(0f, 1f)]
    public float lengthDecrease = 0.1f;
    [Space]
    public Branch branchPrefab;
    public GameObject stand;

    List<Branch> branches;

    // Start is called before the first frame update
    void Start()
    {
        branches = new List<Branch>();

        for (int i = 0; i < trunkSegments; i++)
        {
            Branch branch = Instantiate(branchPrefab, stand.transform);
            branch.transform.position = stand.transform.position + Vector3.up * trunkHeight * (i +1);
            branch.connectedBody = i == 0 ? stand.GetComponent<Rigidbody2D>() : branches[i - 1].GetComponent<Rigidbody2D>();
            branches.Add(branch);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
