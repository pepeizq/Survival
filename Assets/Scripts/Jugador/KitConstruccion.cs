using UnityEngine;
using UnityEngine.InputSystem;

namespace Jugador
{
    public class KitConstruccion : Objeto.Camara
    {
        public GameObject ventana;
        private Assets.Construccion actualReceta;
        private Construccion.VistaPrevia vistaPrevia;

        public float ubicacionActualizacionVelocidad = 0.03f;
        private float ultimaUbicacionTiempo;
        public float ubicacionMaximaDistancia = 5;

        public LayerMask ubicacionLayerMask;

        public Vector3 ubicacionPosicion;
        private bool puedeUbicarConstruccion;
        private float rotacionEjeY;

        public float rotacionVelocidad = 180;

        private Camera camara;
        public static KitConstruccion instancia;

        public void Awake()
        {
            instancia = this;
            camara = Camera.main;
        }

        public void Start()
        {
            ventana = FindObjectOfType<Construccion.Ventana>(true).gameObject;
        }

        public override void AtacarInput()
        {
         
        }

        public override void Atacar2Input()
        {
            ventana.SetActive(true);
            Movimientos.instancia.EnseñarCursor(true); 
        }

        public void EstablecerNuevaRecetaConstruccion(Assets.Construccion receta)
        {
            actualReceta = receta;
            ventana.SetActive(false);
            Movimientos.instancia.EnseñarCursor(false);

            vistaPrevia = Instantiate(receta.vistaPreviaPrefab.gameObject).GetComponent<Construccion.VistaPrevia>();
        }

        public void Update()
        {
            if (actualReceta != null && vistaPrevia != null && Time.time - ultimaUbicacionTiempo > ubicacionActualizacionVelocidad)
            {
                ultimaUbicacionTiempo = Time.time;

                Ray ray = camara.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, ubicacionMaximaDistancia, ubicacionLayerMask) == true)
                {
                    vistaPrevia.transform.position = hit.point;
                    vistaPrevia.transform.up = hit.normal;
                }
            }

            if (Keyboard.current.rKey.isPressed == true)
            {

            }
        }

        public void OnDestroy()
        {
            
        }
    }
}

