using Mirror;
using UnityEngine;

public class GunTrigger : NetworkBehaviour
{
    public float force;

    //public new Rigidbody rigidbody;
    private Rigidbody rb;

    public Gun Gun;
    private Gun gun;
    public Gun[] guns;

    private void Awake()
    {
        gun = Gun.GetComponent<Gun>();
        rb = GetComponent<Rigidbody>();
    }

    public void Update()
    {
        if (!isLocalPlayer) return;
        if (Input.GetMouseButton(0) == true)
        {
            if (gun.AmmoCount >= 1)
            {
                rb.AddRelativeForce(Vector3.back * force);
            }
            foreach (var gun in guns)
            {
                gun.Fire(Vector3.zero);
            }
        }
    }
}