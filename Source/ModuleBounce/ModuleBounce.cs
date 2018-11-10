using UnityEngine;

namespace SXT
{
    public class ModuleBounce : PartModule
    {
        [KSPField(isPersistant = false)]
        public float bounciness = 0.5f;

        public override void OnStart(PartModule.StartState state)
        {
            //Debug.LogError("ModuleBounce OnStart", gameObject);
            //ModuleBounceCollider bounce = part.collider.GetComponent<ModuleBounceCollider>();
            ModuleBounceCollider bounce = gameObject.GetComponent<ModuleBounceCollider>();

            if (bounce != null)
                return;

            //bounce = part.collider.gameObject.AddComponent<ModuleBounceCollider>();
            bounce = gameObject.AddComponent<ModuleBounceCollider>();
            bounce.bounciness = bounciness;
            bounce.part = part;
            //Debug.LogError("ModuleBounce " + part.collider.gameObject.name);
        }
    }

    public class ModuleBounceCollider : MonoBehaviour
    {
        public float bounciness = 0.5f;
        public Part part;

        private Rigidbody _rigidbody;

        /*void Start()
        {
            Debug.LogError("ModuleBounceCollider Start", gameObject);
        }*/

        Vector3 lastVel = Vector3.zero;
        void FixedUpdate()
        {
            //lastVel = part.vessel.GetSrfVelocity();
            if (this.GetComponentCached(ref _rigidbody) != null)
                lastVel = this.GetComponentCached(ref _rigidbody).velocity;
        }

        private void OnCollisionEnter(Collision col)
        {
            //Debug.Log("collision " + col.collider.gameObject.name);

            //Mikes method
            /*float velocityMagnitude = col.relativeVelocity.magnitude;
            Vector3 velocityNormalized = -col.relativeVelocity / velocityMagnitude;
            float bounce = (bounciness * velocityMagnitude) / col.contacts.Length;

            for (int i = 0; i < col.contacts.Length; ++i)
                rigidbody.AddForce(Vector3.Reflect(velocityNormalized, col.contacts[i].normal) * bounce, ForceMode.Impulse);*/

            /*float velocityMagnitude = col.relativeVelocity.magnitude;
            Vector3 velocityNormalized = col.relativeVelocity.normalized;
            float bounce = (bounciness * velocityMagnitude) / col.contacts.Length;*/

            //best working "standard" method, doesn't work well at all actually cause the deflection physics is wrongish
            /*Vector3 force = Vector3.zero;
            for (int i = 0; i < col.contacts.Length; ++i)
                force += col.contacts[i].normal;
            rigidbody.AddForce(force.normalized * col.relativeVelocity.magnitude * bounciness * part.mass, ForceMode.Impulse);*/

            //in theory a better solution but the whole "hit other vessel" part doesn't work
            //which means you cand properly "kick" a ball and expect its velocity to change according to the momentum of the object hitting it.
            /*if (col.collider.attachedRigidbody != null)
            {
                Part hitPart = col.collider.attachedRigidbody.GetComponent<Part>();
                if (hitPart != null) //hit other vessel
                {

                    float m1 = part.mass;
                    float m2 = hitPart.mass;

                    Vector3 impulse = Vector3.zero;
                    for (int i = 0; i < col.contacts.Length; ++i)
                        impulse += col.contacts[i].point - part.transform.position;
                    impulse = impulse.normalized;

                    Vector3 impact = hitPart.rigidbody.velocity - lastVel;
                    float impactSpeed = Vector3.Dot(impact, impulse);
                    Vector3 impulse2 = impulse * impactSpeed * m1 * m2;
                    rigidbody.velocity = lastVel + (impulse2 / m1);

                    Debug.Log("collision " + hitPart.partName + " | v1 " + lastVel + " | v2 " + hitPart.rigidbody.velocity + " | outVel " + rigidbody.velocity + " | impact " + impact + " | impulse " + impulse + " | impulse2 " + impulse2 + " | is " + impactSpeed);
                }
            }
            else //assume planet or something big :p
            {
                Debug.Log("collision " + col.collider.name);
                Vector3 normal = Vector3.zero;
                foreach (ContactPoint c in col.contacts)
                    normal += c.normal;
                normal.Normalize();
                Vector3 inVelocity = lastVel;
                //Vector3 inVelocity = rigidbody.velocity;
                Vector3 outVelocity = bounciness * (-2f * (Vector3.Dot(inVelocity, normal) * normal) + inVelocity);
                rigidbody.velocity = outVelocity;
            }*/

            //a pure "deflection" method, works by simply using bounciness as a scalar on the deflected vector.
            //Debug.Log("collision " + col.collider.name);
            Vector3 normal = Vector3.zero;
            ContactPoint[] contacts = col.contacts;

            for (int i = contacts.Length - 1; i >= 0; --i)
            {
                normal += contacts[i].normal;
            }

            normal.Normalize();
            Vector3 inVelocity = lastVel;
            //Vector3 inVelocity = rigidbody.velocity;
            Vector3 outVelocity = bounciness * (-2f * (Vector3.Dot(inVelocity, normal) * normal) + inVelocity);

            if (this.GetComponentCached(ref _rigidbody) != null)
                this.GetComponentCached(ref _rigidbody).velocity = outVelocity;
        }
    }
}