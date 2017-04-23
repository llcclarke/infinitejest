using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class GenerateTerrain : MonoBehaviour {

	int heightScale = 3;
	float detailScale = 5.0f;
	List<GameObject> myTrees = new List<GameObject>();


	// Use this for initialization
	void Start ()
	{
		Mesh mesh = this.GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		for(int v = 0; v < vertices.Length; v++)
		{
			vertices[v].y = Mathf.PerlinNoise((vertices[v].x + this.transform.position.x)/detailScale,
												(vertices[v].z + this.transform.position.z)/detailScale)*heightScale;

			if (vertices [v].y > 2.1) {
				GameObject newTree = TreePool.getTree();
				if (newTree != null) {
					Vector3 treePos = new Vector3 (vertices [v].x + this.transform.position.x,
						                  vertices [v].y,
						                  vertices [v].x + this.transform.position.z);
					newTree.transform.position = treePos;
					newTree.SetActive(true);
					myTrees.Add(newTree);
				}

			}
				

		}

		mesh.vertices = vertices;
		mesh.RecalculateBounds();
		mesh.RecalculateNormals();
		this.gameObject.AddComponent<MeshCollider>();

	}

	// Update is called once per frame
	void Update () {

	}
}
