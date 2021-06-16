using UnityEngine;

namespace Construccion
{
    public class Propiedades : MonoBehaviour
    {
        public Assets.Construccion asset;

        public virtual string CogerPropiedades()
        {
            return string.Empty;
        }

        public virtual void RecibirPropiedades(string propiedades)
        {

        }
    }
}

