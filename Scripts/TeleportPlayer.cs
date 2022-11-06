using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class TeleportPlayer : MonoBehaviour
{
    private CharacterController playerController;
    [SerializeField] private GameObject sandbox;
    void Start()
    {
        playerController = gameObject.GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine("Teleport");
        }
    }

    IEnumerator Teleport()
    {
        playerController.disabled = true;
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = sandbox.transform.position + new Vector3(0f, 2f, 0f);
        yield return new WaitForSeconds(0.5f);
        playerController.disabled = false;
    }
}
