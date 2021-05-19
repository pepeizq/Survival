using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class Equipar : MonoBehaviour
    {
        public Objeto.Camara actualObjetoEquipado;
        public Transform objetoEquipado;

        private Movimientos movimientos;

        public static Equipar instancia;

        public void Awake()
        {
            instancia = this;
            movimientos = GetComponent<Movimientos>();
        }

        public void AtacarInput(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed && actualObjetoEquipado != null && movimientos.puedeMirar == true)
            {
                actualObjetoEquipado.AtacarInput();
            }
        }

        public void Atacar2Input(InputAction.CallbackContext contexto)
        {
            if (contexto.phase == InputActionPhase.Performed && actualObjetoEquipado != null && movimientos.puedeMirar == true)
            {
                actualObjetoEquipado.Atacar2Input();
            }
        }

        public void EquiparNuevo(Objeto.Datos objeto)
        {
            Desequipar();
            actualObjetoEquipado = Instantiate(objeto.objetoEquipado, objetoEquipado).GetComponent<Objeto.Camara>();
        }

        public void Desequipar()
        {
            if (actualObjetoEquipado != null)
            {
                Destroy(actualObjetoEquipado.gameObject);
                actualObjetoEquipado = null;
            }
        }
    }
}