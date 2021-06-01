﻿using UnityEngine;

namespace Crafting
{
    public class Ventana : MonoBehaviour
    {
        public Receta[] recetas;
        public static Ventana instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void AlAbrirInventario()
        {
            gameObject.SetActive(false);
        }

        public void OnEnable()
        {
            Jugador.Inventario.instancia.abrirInventario.AddListener(AlAbrirInventario);
        }

        public void OnDisable()
        {
            Jugador.Inventario.instancia.abrirInventario.RemoveListener(AlAbrirInventario);
        }

        public void Craftear(Assets.Receta receta)
        {
            int i = 0;
            while (i < receta.costes.Length)
            {
                int j = 0;
                while (j < receta.costes[i].cantidad)
                {
                    Jugador.Inventario.instancia.QuitarObjeto(receta.costes[i].objeto);
                    j += 1;
                }

                i += 1;
            }

            Jugador.Inventario.instancia.AñadirObjeto(receta.objetoACraftear);

            int k = 0;
            while (k < recetas.Length)
            {
                recetas[k].ComprobarPuedeCraftear();

                k += 1;
            }
        }
    }
}
