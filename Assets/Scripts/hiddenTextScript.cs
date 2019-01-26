using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenTextScript : MonoBehaviour {

    public GameObject m_player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, m_player.transform.position) < 4) {
            TextMesh mesh = GetComponent(typeof(TextMesh)) as TextMesh;

            if (mesh) {
                mesh.color = new Color(mesh.color.r, mesh.color.g, mesh.color.b, 255);
            }
        } else {
            TextMesh mesh = GetComponent(typeof(TextMesh)) as TextMesh;

            if (mesh) {
                mesh.color = new Color(mesh.color.r, mesh.color.g, mesh.color.b, 0);
            }
        }
    }
}
