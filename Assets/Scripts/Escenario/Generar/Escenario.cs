using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Escenario.Generar
{
    public class Escenario : MonoBehaviour
    {
        [Header("Debug")]
        public bool aleatorio;
        public bool coloresGeneracion;
        public bool agua;
        public bool ponerLlano;
        public bool portapapeles;

        [Header("Prefabs")]
        public Casilla[] casillasDebug;
        //public Terreno[] casillasInvierno;
        //public Terreno[] casillasPrimavera;
        //public Terreno[] casillasVerano;
        //public Terreno[] casillasOtoño;

        [HideInInspector]
        public Casilla[,] terrenos = new Casilla[1, 1];

        [Header("Opciones")]
        public float alturaMaxima = 10f;
        public int tamañoEscenarioX = 100;
        public int tamañoEscenarioZ = 100;
        public float casillasEscala = 1f;

        [HideInInspector]
        public int limitesMapa = 3;

        public static Escenario instancia;

        public void Awake()
        {
            instancia = this;
        }

        public void Start()
        {
            terrenos = new Casilla[tamañoEscenarioX, tamañoEscenarioZ];

            List<Vector3> listadoTerrenoInicial = new List<Vector3>();

            if (aleatorio == true)
            {
                listadoTerrenoInicial = Vectores.instancia.GenerarTerreno(terrenos, (int)tamañoEscenarioX, (int)tamañoEscenarioZ, alturaMaxima, limitesMapa);
            }
            else
            {
                listadoTerrenoInicial = new List<Vector3> {
new Vector3(67, 4, 5),
new Vector3(70, 3.5f, 8),
new Vector3(63, 3.5f, 5),
new Vector3(63, 3.5f, 5),
new Vector3(70, 3.5f, 2),
new Vector3(72, 3, 10),
new Vector3(72, 3, 10),
new Vector3(61, 3, 5),
new Vector3(73, 3, 5),
new Vector3(59, 2.5f, 6),
new Vector3(59, 2.5f, 3),
new Vector3(59, 2.5f, 7),
new Vector3(59, 2.5f, 2),
new Vector3(75, 2, 13),
new Vector3(75, 2, 14),
new Vector3(75, 2, 15),
new Vector3(76, 2, 13),
new Vector3(76, 2, 14),
new Vector3(76, 2, 15),
new Vector3(77, 2, 13),
new Vector3(77, 2, 14),
new Vector3(77, 2, 15),
new Vector3(63, 2, 14),
new Vector3(63, 2, 15),
new Vector3(63, 2, 16),
new Vector3(64, 2, 14),
new Vector3(64, 2, 15),
new Vector3(64, 2, 16),
new Vector3(65, 2, 14),
new Vector3(65, 2, 15),
new Vector3(65, 2, 16),
new Vector3(76, 2, 5),
new Vector3(76, 2, 6),
new Vector3(76, 2, 7),
new Vector3(77, 2, 5),
new Vector3(77, 2, 6),
new Vector3(77, 2, 7),
new Vector3(78, 2, 5),
new Vector3(78, 2, 6),
new Vector3(78, 2, 7),
new Vector3(75, 2, 13),
new Vector3(75, 2, 14),
new Vector3(75, 2, 15),
new Vector3(76, 2, 13),
new Vector3(76, 2, 14),
new Vector3(76, 2, 15),
new Vector3(77, 2, 13),
new Vector3(77, 2, 14),
new Vector3(77, 2, 15),
new Vector3(56, 2, 3),
new Vector3(56, 2, 4),
new Vector3(56, 2, 5),
new Vector3(57, 2, 3),
new Vector3(57, 2, 4),
new Vector3(57, 2, 5),
new Vector3(58, 2, 3),
new Vector3(58, 2, 4),
new Vector3(58, 2, 5),
new Vector3(77, 1.5f, 15),
new Vector3(77, 1.5f, 16),
new Vector3(77, 1.5f, 17),
new Vector3(78, 1.5f, 15),
new Vector3(78, 1.5f, 16),
new Vector3(78, 1.5f, 17),
new Vector3(79, 1.5f, 15),
new Vector3(79, 1.5f, 16),
new Vector3(79, 1.5f, 17),
new Vector3(77, 1.5f, 15),
new Vector3(77, 1.5f, 16),
new Vector3(77, 1.5f, 17),
new Vector3(78, 1.5f, 15),
new Vector3(78, 1.5f, 16),
new Vector3(78, 1.5f, 17),
new Vector3(79, 1.5f, 15),
new Vector3(79, 1.5f, 16),
new Vector3(79, 1.5f, 17),
new Vector3(62, 1.5f, 16),
new Vector3(62, 1.5f, 17),
new Vector3(62, 1.5f, 18),
new Vector3(63, 1.5f, 16),
new Vector3(63, 1.5f, 17),
new Vector3(63, 1.5f, 18),
new Vector3(64, 1.5f, 16),
new Vector3(64, 1.5f, 17),
new Vector3(64, 1.5f, 18),
new Vector3(78, 1, 16),
new Vector3(78, 1, 17),
new Vector3(78, 1, 18),
new Vector3(78, 1, 19),
new Vector3(78, 1, 20),
new Vector3(79, 1, 16),
new Vector3(79, 1, 17),
new Vector3(79, 1, 18),
new Vector3(79, 1, 19),
new Vector3(79, 1, 20),
new Vector3(80, 1, 16),
new Vector3(80, 1, 17),
new Vector3(80, 1, 18),
new Vector3(80, 1, 19),
new Vector3(80, 1, 20),
new Vector3(81, 1, 16),
new Vector3(81, 1, 17),
new Vector3(81, 1, 18),
new Vector3(81, 1, 19),
new Vector3(81, 1, 20),
new Vector3(82, 1, 16),
new Vector3(82, 1, 17),
new Vector3(82, 1, 18),
new Vector3(82, 1, 19),
new Vector3(82, 1, 20),
new Vector3(52, 1, 16),
new Vector3(52, 1, 17),
new Vector3(52, 1, 18),
new Vector3(52, 1, 19),
new Vector3(52, 1, 20),
new Vector3(53, 1, 16),
new Vector3(53, 1, 17),
new Vector3(53, 1, 18),
new Vector3(53, 1, 19),
new Vector3(53, 1, 20),
new Vector3(54, 1, 16),
new Vector3(54, 1, 17),
new Vector3(54, 1, 18),
new Vector3(54, 1, 19),
new Vector3(54, 1, 20),
new Vector3(55, 1, 16),
new Vector3(55, 1, 17),
new Vector3(55, 1, 18),
new Vector3(55, 1, 19),
new Vector3(55, 1, 20),
new Vector3(56, 1, 16),
new Vector3(56, 1, 17),
new Vector3(56, 1, 18),
new Vector3(56, 1, 19),
new Vector3(56, 1, 20),
new Vector3(78, 1, 16),
new Vector3(78, 1, 17),
new Vector3(78, 1, 18),
new Vector3(78, 1, 19),
new Vector3(78, 1, 20),
new Vector3(79, 1, 16),
new Vector3(79, 1, 17),
new Vector3(79, 1, 18),
new Vector3(79, 1, 19),
new Vector3(79, 1, 20),
new Vector3(80, 1, 16),
new Vector3(80, 1, 17),
new Vector3(80, 1, 18),
new Vector3(80, 1, 19),
new Vector3(80, 1, 20),
new Vector3(81, 1, 16),
new Vector3(81, 1, 17),
new Vector3(81, 1, 18),
new Vector3(81, 1, 19),
new Vector3(81, 1, 20),
new Vector3(82, 1, 16),
new Vector3(82, 1, 17),
new Vector3(82, 1, 18),
new Vector3(82, 1, 19),
new Vector3(82, 1, 20),
new Vector3(65, 1, 17),
new Vector3(65, 1, 18),
new Vector3(65, 1, 19),
new Vector3(65, 1, 20),
new Vector3(65, 1, 21),
new Vector3(66, 1, 17),
new Vector3(66, 1, 18),
new Vector3(66, 1, 19),
new Vector3(66, 1, 20),
new Vector3(66, 1, 21),
new Vector3(67, 1, 17),
new Vector3(67, 1, 18),
new Vector3(67, 1, 19),
new Vector3(67, 1, 20),
new Vector3(67, 1, 21),
new Vector3(68, 1, 17),
new Vector3(68, 1, 18),
new Vector3(68, 1, 19),
new Vector3(68, 1, 20),
new Vector3(68, 1, 21),
new Vector3(69, 1, 17),
new Vector3(69, 1, 18),
new Vector3(69, 1, 19),
new Vector3(69, 1, 20),
new Vector3(69, 1, 21),
new Vector3(62, 1, 17),
new Vector3(62, 1, 18),
new Vector3(62, 1, 19),
new Vector3(62, 1, 20),
new Vector3(62, 1, 21),
new Vector3(63, 1, 17),
new Vector3(63, 1, 18),
new Vector3(63, 1, 19),
new Vector3(63, 1, 20),
new Vector3(63, 1, 21),
new Vector3(64, 1, 17),
new Vector3(64, 1, 18),
new Vector3(64, 1, 19),
new Vector3(64, 1, 20),
new Vector3(64, 1, 21),
new Vector3(65, 1, 17),
new Vector3(65, 1, 18),
new Vector3(65, 1, 19),
new Vector3(65, 1, 20),
new Vector3(65, 1, 21),
new Vector3(66, 1, 17),
new Vector3(66, 1, 18),
new Vector3(66, 1, 19),
new Vector3(66, 1, 20),
new Vector3(66, 1, 21),
new Vector3(36, 5, 31),
new Vector3(36, 4.5f, 35),
new Vector3(35, 4.5f, 35),
new Vector3(32, 4.5f, 30),
new Vector3(36, 4.5f, 35),
new Vector3(31, 4, 26),
new Vector3(30, 4, 32),
new Vector3(31, 4, 26),
new Vector3(41, 4, 26),
new Vector3(43, 3.5f, 38),
new Vector3(26, 3, 33),
new Vector3(45, 3, 22),
new Vector3(46, 3, 34),
new Vector3(46, 3, 28),
new Vector3(34, 3, 21),
new Vector3(27, 3, 22),
new Vector3(46, 3, 32),
new Vector3(24, 2.5f, 35),
new Vector3(36, 2.5f, 43),
new Vector3(48, 2.5f, 29),
new Vector3(38, 2.5f, 43),
new Vector3(31, 2.5f, 43),
new Vector3(38, 2.5f, 43),
new Vector3(48, 2.5f, 27),
new Vector3(48, 2, 17),
new Vector3(48, 2, 18),
new Vector3(48, 2, 19),
new Vector3(49, 2, 17),
new Vector3(49, 2, 18),
new Vector3(49, 2, 19),
new Vector3(50, 2, 17),
new Vector3(50, 2, 18),
new Vector3(50, 2, 19),
new Vector3(49, 2, 35),
new Vector3(49, 2, 36),
new Vector3(49, 2, 37),
new Vector3(50, 2, 35),
new Vector3(50, 2, 36),
new Vector3(50, 2, 37),
new Vector3(51, 2, 35),
new Vector3(51, 2, 36),
new Vector3(51, 2, 37),
new Vector3(22, 2, 17),
new Vector3(22, 2, 18),
new Vector3(22, 2, 19),
new Vector3(23, 2, 17),
new Vector3(23, 2, 18),
new Vector3(23, 2, 19),
new Vector3(24, 2, 17),
new Vector3(24, 2, 18),
new Vector3(24, 2, 19),
new Vector3(48, 2, 43),
new Vector3(48, 2, 44),
new Vector3(48, 2, 45),
new Vector3(49, 2, 43),
new Vector3(49, 2, 44),
new Vector3(49, 2, 45),
new Vector3(50, 2, 43),
new Vector3(50, 2, 44),
new Vector3(50, 2, 45),
new Vector3(48, 2, 17),
new Vector3(48, 2, 18),
new Vector3(48, 2, 19),
new Vector3(49, 2, 17),
new Vector3(49, 2, 18),
new Vector3(49, 2, 19),
new Vector3(50, 2, 17),
new Vector3(50, 2, 18),
new Vector3(50, 2, 19),
new Vector3(19, 1.5f, 25),
new Vector3(19, 1.5f, 26),
new Vector3(19, 1.5f, 27),
new Vector3(20, 1.5f, 25),
new Vector3(20, 1.5f, 26),
new Vector3(20, 1.5f, 27),
new Vector3(21, 1.5f, 25),
new Vector3(21, 1.5f, 26),
new Vector3(21, 1.5f, 27),
new Vector3(51, 1.5f, 33),
new Vector3(51, 1.5f, 34),
new Vector3(51, 1.5f, 35),
new Vector3(52, 1.5f, 33),
new Vector3(52, 1.5f, 34),
new Vector3(52, 1.5f, 35),
new Vector3(53, 1.5f, 33),
new Vector3(53, 1.5f, 34),
new Vector3(53, 1.5f, 35),
new Vector3(52, 1, 31),
new Vector3(52, 1, 32),
new Vector3(52, 1, 33),
new Vector3(52, 1, 34),
new Vector3(52, 1, 35),
new Vector3(53, 1, 31),
new Vector3(53, 1, 32),
new Vector3(53, 1, 33),
new Vector3(53, 1, 34),
new Vector3(53, 1, 35),
new Vector3(54, 1, 31),
new Vector3(54, 1, 32),
new Vector3(54, 1, 33),
new Vector3(54, 1, 34),
new Vector3(54, 1, 35),
new Vector3(55, 1, 31),
new Vector3(55, 1, 32),
new Vector3(55, 1, 33),
new Vector3(55, 1, 34),
new Vector3(55, 1, 35),
new Vector3(56, 1, 31),
new Vector3(56, 1, 32),
new Vector3(56, 1, 33),
new Vector3(56, 1, 34),
new Vector3(56, 1, 35),
new Vector3(52, 1, 28),
new Vector3(52, 1, 29),
new Vector3(52, 1, 30),
new Vector3(52, 1, 31),
new Vector3(52, 1, 32),
new Vector3(53, 1, 28),
new Vector3(53, 1, 29),
new Vector3(53, 1, 30),
new Vector3(53, 1, 31),
new Vector3(53, 1, 32),
new Vector3(54, 1, 28),
new Vector3(54, 1, 29),
new Vector3(54, 1, 30),
new Vector3(54, 1, 31),
new Vector3(54, 1, 32),
new Vector3(55, 1, 28),
new Vector3(55, 1, 29),
new Vector3(55, 1, 30),
new Vector3(55, 1, 31),
new Vector3(55, 1, 32),
new Vector3(56, 1, 28),
new Vector3(56, 1, 29),
new Vector3(56, 1, 30),
new Vector3(56, 1, 31),
new Vector3(56, 1, 32),
};
            }

            int k = 0;
            float alturaMaxima2 = alturaMaxima;
            int tope = (int)alturaMaxima * 2;
            while (k < tope)
            {
                if (alturaMaxima2 == 0.5f)
                {
                    break;
                }

                alturaMaxima2 -= 0.5f;

                if (alturaMaxima2 < 0.5f)
                {
                    alturaMaxima2 = 0.5f;
                }

                try
                {
                    GenerarNivel(alturaMaxima2, listadoTerrenoInicial);
                }
                catch (Exception fallo)
                {
                    Debug.Log(fallo);
                    k -= 1;
                }

                k += 1;
            }

            //----------------------------------------------------------

            if (agua == true)
            {
                List<Vector3> listadoAguaInicial = new List<Vector3>();

                if (aleatorio == true)
                {
                    listadoAguaInicial = Vectores.instancia.GenerarAgua(terrenos, (int)tamañoEscenarioX, (int)tamañoEscenarioZ, alturaMaxima, limitesMapa);
                }
                else
                {
                    listadoAguaInicial = new List<Vector3> {
new Vector3(53, 0.25f, 3),
new Vector3(52, 0.25f, 3),
new Vector3(54, 0.25f, 3),
new Vector3(53, 0.25f, 3),
new Vector3(52, 0.25f, 3),
new Vector3(54, 0.25f, 3),
new Vector3(53, 0.25f, 4),
new Vector3(52, 0.25f, 4),
new Vector3(54, 0.25f, 4),
new Vector3(53, 0.25f, 5),
new Vector3(52, 0.25f, 5),
new Vector3(54, 0.25f, 5),
new Vector3(53, 0.25f, 6),
new Vector3(52, 0.25f, 6),
new Vector3(54, 0.25f, 6),
new Vector3(53, 0.25f, 7),
new Vector3(52, 0.25f, 7),
new Vector3(54, 0.25f, 7),
new Vector3(53, 0.25f, 8),
new Vector3(52, 0.25f, 8),
new Vector3(54, 0.25f, 8),
new Vector3(53, 0.25f, 9),
new Vector3(52, 0.25f, 9),
new Vector3(54, 0.25f, 9),
new Vector3(53, 0.25f, 10),
new Vector3(52, 0.25f, 10),
new Vector3(54, 0.25f, 10),
new Vector3(53, 0.25f, 11),
new Vector3(52, 0.25f, 11),
new Vector3(54, 0.25f, 11),
new Vector3(53, 0.25f, 12),
new Vector3(52, 0.25f, 12),
new Vector3(54, 0.25f, 12),
new Vector3(53, 0.25f, 13),
new Vector3(52, 0.25f, 13),
new Vector3(54, 0.25f, 13),
new Vector3(53, 0.25f, 14),
new Vector3(52, 0.25f, 14),
new Vector3(54, 0.25f, 14),
new Vector3(53, 0.25f, 15),
new Vector3(52, 0.25f, 15),
new Vector3(54, 0.25f, 15),
new Vector3(53, 0.25f, 16),
new Vector3(52, 0.25f, 16),
new Vector3(54, 0.25f, 16),
new Vector3(53, 0.25f, 17),
new Vector3(52, 0.25f, 17),
new Vector3(54, 0.25f, 17),
new Vector3(53, 0.25f, 18),
new Vector3(52, 0.25f, 18),
new Vector3(54, 0.25f, 18),
new Vector3(53, 0.25f, 19),
new Vector3(52, 0.25f, 19),
new Vector3(54, 0.25f, 19),
new Vector3(53, 0.25f, 20),
new Vector3(52, 0.25f, 20),
new Vector3(54, 0.25f, 20),
new Vector3(53, 0.25f, 21),
new Vector3(52, 0.25f, 21),
new Vector3(54, 0.25f, 21),
new Vector3(53, 0.25f, 22),
new Vector3(52, 0.25f, 22),
new Vector3(54, 0.25f, 22),
new Vector3(53, 0.25f, 23),
new Vector3(52, 0.25f, 23),
new Vector3(54, 0.25f, 23),
new Vector3(53, 0.25f, 24),
new Vector3(52, 0.25f, 24),
new Vector3(54, 0.25f, 24),
new Vector3(53, 0.25f, 25),
new Vector3(52, 0.25f, 25),
new Vector3(54, 0.25f, 25),
new Vector3(53, 0.25f, 26),
new Vector3(52, 0.25f, 26),
new Vector3(54, 0.25f, 26),
new Vector3(53, 0.25f, 27),
new Vector3(52, 0.25f, 27),
new Vector3(54, 0.25f, 27),
new Vector3(53, 0.25f, 28),
new Vector3(52, 0.25f, 28),
new Vector3(54, 0.25f, 28),
new Vector3(53, 0.25f, 29),
new Vector3(52, 0.25f, 29),
new Vector3(54, 0.25f, 29),
new Vector3(53, 0.25f, 30),
new Vector3(52, 0.25f, 30),
new Vector3(54, 0.25f, 30),
new Vector3(53, 0.25f, 31),
new Vector3(52, 0.25f, 31),
new Vector3(54, 0.25f, 31),
new Vector3(53, 0.25f, 32),
new Vector3(52, 0.25f, 32),
new Vector3(54, 0.25f, 32),
new Vector3(53, 0.25f, 33),
new Vector3(52, 0.25f, 33),
new Vector3(54, 0.25f, 33),
new Vector3(53, 0.25f, 34),
new Vector3(52, 0.25f, 34),
new Vector3(54, 0.25f, 34),
new Vector3(53, 0.25f, 35),
new Vector3(52, 0.25f, 35),
new Vector3(54, 0.25f, 35),
new Vector3(53, 0.25f, 36),
new Vector3(52, 0.25f, 36),
new Vector3(54, 0.25f, 36),
new Vector3(53, 0.25f, 37),
new Vector3(52, 0.25f, 37),
new Vector3(54, 0.25f, 37),
new Vector3(53, 0.25f, 38),
new Vector3(52, 0.25f, 38),
new Vector3(54, 0.25f, 38),
new Vector3(53, 0.25f, 39),
new Vector3(52, 0.25f, 39),
new Vector3(54, 0.25f, 39),
new Vector3(53, 0.25f, 40),
new Vector3(52, 0.25f, 40),
new Vector3(54, 0.25f, 40),
new Vector3(53, 0.25f, 41),
new Vector3(52, 0.25f, 41),
new Vector3(54, 0.25f, 41),
new Vector3(53, 0.25f, 42),
new Vector3(52, 0.25f, 42),
new Vector3(54, 0.25f, 42),
new Vector3(53, 0.25f, 43),
new Vector3(52, 0.25f, 43),
new Vector3(54, 0.25f, 43),
new Vector3(53, 0.25f, 44),
new Vector3(52, 0.25f, 44),
new Vector3(54, 0.25f, 44),
new Vector3(53, 0.25f, 45),
new Vector3(52, 0.25f, 45),
new Vector3(54, 0.25f, 45),
new Vector3(53, 0.25f, 46),
new Vector3(52, 0.25f, 46),
new Vector3(54, 0.25f, 46),
new Vector3(53, 0.25f, 47),
new Vector3(52, 0.25f, 47),
new Vector3(54, 0.25f, 47),
new Vector3(53, 0.25f, 48),
new Vector3(52, 0.25f, 47),
new Vector3(54, 0.25f, 49),
new Vector3(52, 0.25f, 48),
new Vector3(51, 0.25f, 47),
new Vector3(53, 0.25f, 49),
new Vector3(51, 0.25f, 48),
new Vector3(50, 0.25f, 47),
new Vector3(52, 0.25f, 49),
new Vector3(50, 0.25f, 48),
new Vector3(49, 0.25f, 47),
new Vector3(51, 0.25f, 49),
new Vector3(49, 0.25f, 48),
new Vector3(48, 0.25f, 47),
new Vector3(50, 0.25f, 49),
new Vector3(48, 0.25f, 48),
new Vector3(47, 0.25f, 47),
new Vector3(49, 0.25f, 49),
new Vector3(47, 0.25f, 48),
new Vector3(46, 0.25f, 48),
new Vector3(48, 0.25f, 48),
new Vector3(47, 0.25f, 49),
new Vector3(46, 0.25f, 48),
new Vector3(48, 0.25f, 50),
new Vector3(48, 0.25f, 49),
new Vector3(47, 0.25f, 48),
new Vector3(49, 0.25f, 50),
new Vector3(49, 0.25f, 49),
new Vector3(48, 0.25f, 48),
new Vector3(50, 0.25f, 50),
new Vector3(50, 0.25f, 49),
new Vector3(49, 0.25f, 48),
new Vector3(51, 0.25f, 50),
new Vector3(51, 0.25f, 49),
new Vector3(50, 0.25f, 48),
new Vector3(52, 0.25f, 50),
new Vector3(52, 0.25f, 49),
new Vector3(51, 0.25f, 48),
new Vector3(53, 0.25f, 50),
new Vector3(51, 0.25f, 49),
new Vector3(50, 0.25f, 48),
new Vector3(52, 0.25f, 50),
new Vector3(50, 0.25f, 49),
new Vector3(49, 0.25f, 48),
new Vector3(51, 0.25f, 50),
new Vector3(49, 0.25f, 49),
new Vector3(48, 0.25f, 48),
new Vector3(50, 0.25f, 50),
new Vector3(48, 0.25f, 49),
new Vector3(47, 0.25f, 48),
new Vector3(49, 0.25f, 50),
new Vector3(47, 0.25f, 49),
new Vector3(46, 0.25f, 48),
new Vector3(48, 0.25f, 50),
new Vector3(46, 0.25f, 49),
new Vector3(45, 0.25f, 49),
new Vector3(47, 0.25f, 49),
new Vector3(46, 0.25f, 50),
new Vector3(45, 0.25f, 49),
new Vector3(47, 0.25f, 51),
new Vector3(47, 0.25f, 50),
new Vector3(46, 0.25f, 49),
new Vector3(48, 0.25f, 51),
new Vector3(48, 0.25f, 50),
new Vector3(47, 0.25f, 49),
new Vector3(49, 0.25f, 51),
new Vector3(49, 0.25f, 50),
new Vector3(48, 0.25f, 49),
new Vector3(50, 0.25f, 51),
new Vector3(50, 0.25f, 50),
new Vector3(49, 0.25f, 49),
new Vector3(51, 0.25f, 51),
new Vector3(51, 0.25f, 50),
new Vector3(50, 0.25f, 49),
new Vector3(52, 0.25f, 51),
new Vector3(52, 0.25f, 50),
new Vector3(51, 0.25f, 49),
new Vector3(53, 0.25f, 51),
new Vector3(51, 0.25f, 50),
new Vector3(50, 0.25f, 49),
new Vector3(52, 0.25f, 51),
new Vector3(50, 0.25f, 50),
new Vector3(49, 0.25f, 49),
new Vector3(51, 0.25f, 51),
new Vector3(49, 0.25f, 50),
new Vector3(48, 0.25f, 49),
new Vector3(50, 0.25f, 51),
new Vector3(48, 0.25f, 50),
new Vector3(47, 0.25f, 49),
new Vector3(49, 0.25f, 51),
new Vector3(47, 0.25f, 50),
new Vector3(46, 0.25f, 49),
new Vector3(48, 0.25f, 51),
new Vector3(46, 0.25f, 50),
new Vector3(45, 0.25f, 50),
new Vector3(47, 0.25f, 50),
new Vector3(46, 0.25f, 51),
new Vector3(45, 0.25f, 50),
new Vector3(47, 0.25f, 52),
new Vector3(47, 0.25f, 51),
new Vector3(46, 0.25f, 50),
new Vector3(48, 0.25f, 52),
new Vector3(48, 0.25f, 51),
new Vector3(47, 0.25f, 50),
new Vector3(49, 0.25f, 52),
new Vector3(49, 0.25f, 51),
new Vector3(48, 0.25f, 50),
new Vector3(50, 0.25f, 52),
new Vector3(50, 0.25f, 51),
new Vector3(49, 0.25f, 50),
new Vector3(51, 0.25f, 52),
new Vector3(51, 0.25f, 51),
new Vector3(50, 0.25f, 50),
new Vector3(52, 0.25f, 52),
new Vector3(52, 0.25f, 51),
new Vector3(51, 0.25f, 50),
new Vector3(53, 0.25f, 52),
new Vector3(51, 0.25f, 51),
new Vector3(50, 0.25f, 50),
new Vector3(52, 0.25f, 52),
new Vector3(50, 0.25f, 51),
new Vector3(49, 0.25f, 50),
new Vector3(51, 0.25f, 52),
new Vector3(49, 0.25f, 51),
new Vector3(48, 0.25f, 50),
new Vector3(50, 0.25f, 52),
new Vector3(48, 0.25f, 51),
new Vector3(47, 0.25f, 50),
new Vector3(49, 0.25f, 52),
new Vector3(47, 0.25f, 51),
new Vector3(46, 0.25f, 50),
new Vector3(48, 0.25f, 52),
new Vector3(46, 0.25f, 51),
new Vector3(45, 0.25f, 51),
new Vector3(47, 0.25f, 51),
new Vector3(46, 0.25f, 52),
new Vector3(45, 0.25f, 51),
new Vector3(47, 0.25f, 53),
new Vector3(47, 0.25f, 52),
new Vector3(46, 0.25f, 51),
new Vector3(48, 0.25f, 53),
new Vector3(48, 0.25f, 52),
new Vector3(47, 0.25f, 51),
new Vector3(49, 0.25f, 53),
new Vector3(49, 0.25f, 52),
new Vector3(48, 0.25f, 51),
new Vector3(50, 0.25f, 53),
new Vector3(50, 0.25f, 52),
new Vector3(49, 0.25f, 51),
new Vector3(51, 0.25f, 53),
new Vector3(51, 0.25f, 52),
new Vector3(50, 0.25f, 51),
new Vector3(52, 0.25f, 53),
new Vector3(52, 0.25f, 52),
new Vector3(51, 0.25f, 51),
new Vector3(53, 0.25f, 53),
new Vector3(51, 0.25f, 52),
new Vector3(50, 0.25f, 51),
new Vector3(52, 0.25f, 53),
new Vector3(50, 0.25f, 52),
new Vector3(49, 0.25f, 51),
new Vector3(51, 0.25f, 53),
new Vector3(49, 0.25f, 52),
new Vector3(48, 0.25f, 51),
new Vector3(50, 0.25f, 53),
new Vector3(48, 0.25f, 52),
new Vector3(47, 0.25f, 51),
new Vector3(49, 0.25f, 53),
new Vector3(47, 0.25f, 52),
new Vector3(46, 0.25f, 51),
new Vector3(48, 0.25f, 53),
new Vector3(46, 0.25f, 52),
new Vector3(45, 0.25f, 52),
new Vector3(47, 0.25f, 52),
new Vector3(46, 0.25f, 53),
new Vector3(45, 0.25f, 52),
new Vector3(47, 0.25f, 54),
new Vector3(47, 0.25f, 53),
new Vector3(46, 0.25f, 52),
new Vector3(48, 0.25f, 54),
new Vector3(48, 0.25f, 53),
new Vector3(47, 0.25f, 52),
new Vector3(49, 0.25f, 54),
new Vector3(49, 0.25f, 53),
new Vector3(48, 0.25f, 52),
new Vector3(50, 0.25f, 54),
new Vector3(50, 0.25f, 53),
new Vector3(49, 0.25f, 52),
new Vector3(51, 0.25f, 54),
new Vector3(51, 0.25f, 53),
new Vector3(50, 0.25f, 52),
new Vector3(52, 0.25f, 54),
new Vector3(52, 0.25f, 53),
new Vector3(51, 0.25f, 52),
new Vector3(53, 0.25f, 54),
new Vector3(51, 0.25f, 53),
new Vector3(50, 0.25f, 52),
new Vector3(52, 0.25f, 54),
new Vector3(50, 0.25f, 53),
new Vector3(49, 0.25f, 52),
new Vector3(51, 0.25f, 54),
new Vector3(49, 0.25f, 53),
new Vector3(48, 0.25f, 52),
new Vector3(50, 0.25f, 54),
new Vector3(48, 0.25f, 53),
new Vector3(47, 0.25f, 52),
new Vector3(49, 0.25f, 54),
new Vector3(47, 0.25f, 53),
new Vector3(46, 0.25f, 52),
new Vector3(48, 0.25f, 54),
new Vector3(46, 0.25f, 53),
new Vector3(45, 0.25f, 53),
new Vector3(47, 0.25f, 53),
new Vector3(46, 0.25f, 54),
new Vector3(45, 0.25f, 53),
new Vector3(47, 0.25f, 55),
new Vector3(45, 0.25f, 54),
new Vector3(44, 0.25f, 53),
new Vector3(46, 0.25f, 55),
new Vector3(44, 0.25f, 54),
new Vector3(43, 0.25f, 53),
new Vector3(45, 0.25f, 55),
new Vector3(43, 0.25f, 54),
new Vector3(42, 0.25f, 53),
new Vector3(44, 0.25f, 55),
new Vector3(42, 0.25f, 54),
new Vector3(41, 0.25f, 53),
new Vector3(43, 0.25f, 55),
new Vector3(41, 0.25f, 54),
new Vector3(40, 0.25f, 53),
new Vector3(42, 0.25f, 55),
new Vector3(40, 0.25f, 54),
new Vector3(39, 0.25f, 54),
new Vector3(41, 0.25f, 54),
new Vector3(40, 0.25f, 55),
new Vector3(39, 0.25f, 55),
new Vector3(41, 0.25f, 55),
new Vector3(40, 0.25f, 56),
new Vector3(39, 0.25f, 56),
new Vector3(41, 0.25f, 56),
new Vector3(40, 0.25f, 57),
new Vector3(39, 0.25f, 57),
new Vector3(41, 0.25f, 57),
new Vector3(40, 0.25f, 58),
new Vector3(39, 0.25f, 58),
new Vector3(41, 0.25f, 58),
new Vector3(40, 0.25f, 59),
new Vector3(39, 0.25f, 59),
new Vector3(41, 0.25f, 59),
new Vector3(40, 0.25f, 60),
new Vector3(39, 0.25f, 60),
new Vector3(41, 0.25f, 60),
new Vector3(40, 0.25f, 61),
new Vector3(39, 0.25f, 61),
new Vector3(41, 0.25f, 61),
new Vector3(40, 0.25f, 62),
new Vector3(39, 0.25f, 62),
new Vector3(41, 0.25f, 62),
new Vector3(40, 0.25f, 63),
new Vector3(39, 0.25f, 63),
new Vector3(41, 0.25f, 63),
new Vector3(40, 0.25f, 64),
new Vector3(39, 0.25f, 64),
new Vector3(41, 0.25f, 64),
new Vector3(40, 0.25f, 65),
new Vector3(39, 0.25f, 65),
new Vector3(41, 0.25f, 65),
new Vector3(40, 0.25f, 66),
new Vector3(39, 0.25f, 66),
new Vector3(41, 0.25f, 66),
new Vector3(40, 0.25f, 67),
new Vector3(39, 0.25f, 67),
new Vector3(41, 0.25f, 67),
new Vector3(40, 0.25f, 68),
new Vector3(39, 0.25f, 68),
new Vector3(41, 0.25f, 68),
new Vector3(40, 0.25f, 69),
new Vector3(39, 0.25f, 69),
new Vector3(41, 0.25f, 69),
new Vector3(40, 0.25f, 70),
new Vector3(39, 0.25f, 70),
new Vector3(41, 0.25f, 70),
new Vector3(40, 0.25f, 71),
new Vector3(39, 0.25f, 71),
new Vector3(41, 0.25f, 71),
new Vector3(40, 0.25f, 72),
new Vector3(39, 0.25f, 72),
new Vector3(41, 0.25f, 72),
new Vector3(40, 0.25f, 73),
new Vector3(39, 0.25f, 73),
new Vector3(41, 0.25f, 73),
new Vector3(40, 0.25f, 74),
new Vector3(39, 0.25f, 74),
new Vector3(41, 0.25f, 74),
new Vector3(40, 0.25f, 75),
new Vector3(39, 0.25f, 75),
new Vector3(41, 0.25f, 75),
new Vector3(40, 0.25f, 76),
new Vector3(39, 0.25f, 76),
new Vector3(41, 0.25f, 76),
new Vector3(40, 0.25f, 77),
new Vector3(39, 0.25f, 77),
new Vector3(41, 0.25f, 77),
new Vector3(40, 0.25f, 78),
new Vector3(39, 0.25f, 78),
new Vector3(41, 0.25f, 78),
new Vector3(40, 0.25f, 79),
new Vector3(39, 0.25f, 79),
new Vector3(41, 0.25f, 79),
new Vector3(40, 0.25f, 80),
new Vector3(39, 0.25f, 80),
new Vector3(41, 0.25f, 80),
new Vector3(40, 0.25f, 81),
new Vector3(39, 0.25f, 81),
new Vector3(41, 0.25f, 81),
new Vector3(40, 0.25f, 82),
new Vector3(39, 0.25f, 82),
new Vector3(41, 0.25f, 82),
new Vector3(40, 0.25f, 83),
new Vector3(39, 0.25f, 83),
new Vector3(41, 0.25f, 83),
new Vector3(40, 0.25f, 84),
new Vector3(39, 0.25f, 84),
new Vector3(41, 0.25f, 84),
new Vector3(40, 0.25f, 85),
new Vector3(39, 0.25f, 85),
new Vector3(41, 0.25f, 85),
new Vector3(40, 0.25f, 86),
new Vector3(39, 0.25f, 86),
new Vector3(41, 0.25f, 86),
new Vector3(40, 0.25f, 87),
new Vector3(39, 0.25f, 87),
new Vector3(41, 0.25f, 87),
new Vector3(40, 0.25f, 88),
new Vector3(39, 0.25f, 88),
new Vector3(41, 0.25f, 88),
new Vector3(40, 0.25f, 89),
new Vector3(39, 0.25f, 89),
new Vector3(41, 0.25f, 89),
new Vector3(40, 0.25f, 90),
new Vector3(39, 0.25f, 90),
new Vector3(41, 0.25f, 90),
new Vector3(40, 0.25f, 91),
new Vector3(39, 0.25f, 91),
new Vector3(41, 0.25f, 91),
new Vector3(40, 0.25f, 92),
new Vector3(39, 0.25f, 92),
new Vector3(41, 0.25f, 92),
new Vector3(40, 0.25f, 93),
new Vector3(39, 0.25f, 93),
new Vector3(41, 0.25f, 93),
new Vector3(40, 0.25f, 94),
new Vector3(39, 0.25f, 94),
new Vector3(41, 0.25f, 94),
new Vector3(40, 0.25f, 95),
new Vector3(39, 0.25f, 95),
new Vector3(41, 0.25f, 95),
new Vector3(40, 0.25f, 96),
new Vector3(39, 0.25f, 96),
new Vector3(41, 0.25f, 96),
new Vector3(40, 0.25f, 97),
new Vector3(39, 0.25f, 97),
new Vector3(41, 0.25f, 97),
};
                }

                GenerarAgua(listadoAguaInicial);
            }

            //----------------------------------------------------------

            if (ponerLlano == true)
            {
                PonerLlano2(alturaMaxima2);
            }

          
        }

        public void Update()
        {

        }

        //------------------------------------------------------------------------------------------------------------------------------------

        private void GenerarNivel(float altura, List<Vector3> listadoTerrenoInicial)
        {
            foreach (Vector3 casillaInicial in listadoTerrenoInicial.ToList<Vector3>())
            {
                if (altura == casillaInicial.y)
                {
                    if (Limites.Comprobar((int)casillaInicial.x, 3, (int)tamañoEscenarioX) == true && Limites.Comprobar((int)casillaInicial.z, 3, (int)tamañoEscenarioZ) == true)
                    {
                        if (terrenos[(int)casillaInicial.x, (int)casillaInicial.z] == null)
                        {
                            PonerCasilla(new Casilla(0, 0, casillaInicial));
                            listadoTerrenoInicial.Remove(casillaInicial);
                        }
                    }
                }
            }

            foreach (Casilla subcasilla in terrenos)
            {
                if (subcasilla != null)
                {
                    int x = (int)subcasilla.posicion.x;
                    int z = (int)subcasilla.posicion.z;

                    float y = subcasilla.posicion.y;
                    y = y - 0.5f;

                    if (y < 0.0f)
                    {
                        y = 0.0f;
                    }

                    if ((y > 0) && (altura == subcasilla.posicion.y) && Limites.Comprobar(x, 2, tamañoEscenarioX) == true && Limites.Comprobar(z, 2, tamañoEscenarioZ) == true)
                    {
                        if (terrenos[x - 1, z - 1] == null)
                        {
                            CalcularTerreno_Xmenos1_Zmenos1(x, y, z);
                        }

                        if (terrenos[x - 1, z + 1] == null)
                        {
                            CalcularTerreno_Xmenos1_Zmas1(x, y, z);
                        }

                        if (terrenos[x + 1, z - 1] == null)
                        {
                            CalcularTerreno_Xmas1_Zmenos1(x, y, z);
                        }

                        if (terrenos[x + 1, z + 1] == null)
                        {
                            CalcularTerreno_Xmas1_Zmas1(x, y, z);
                        }

                        if (terrenos[x, z - 1] == null)
                        {
                            CalcularTerreno_X0_Zmenos1(x, y, z);
                        }

                        if (terrenos[x - 1, z] == null)
                        {
                            CalcularTerreno_Xmenos1_Z0(x, y, z);
                        }

                        if (terrenos[x, z + 1] == null)
                        {
                            CalcularTerreno_X0_Zmas1(x, y, z);
                        }

                        if (terrenos[x + 1, z] == null)
                        {
                            CalcularTerreno_Xmas1_Z0(x, y, z);
                        }
                    }
                }
            }
        }

        //Verde - esquina2rotacion180
        private void CalcularTerreno_Xmenos1_Zmenos1(int x, float y, int z)
        {
            Casilla rampas4rotacion90 = new Casilla(4, 90, new Vector3(x - 1, y, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarVacio(terrenos[x, z - 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarVacio(terrenos[x, z - 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarTerreno2(terrenos[x, z - 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarVacio(terrenos[x, z - 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            Casilla plano = new Casilla(0, 0, new Vector3(x - 1, y + 0.5f, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(3, 90, new Vector3(x - 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 2], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(3, 270, new Vector3(x - 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(3, 180, new Vector3(x - 1, y, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true && ComprobarTerreno0(terrenos[x, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla rampa1rotacion90 = new Casilla(1, 90, new Vector3(x - 1, y, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Casilla rampa1rotacion180 = new Casilla(1, 180, new Vector3(x - 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x, z - 1], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z - 1], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Casilla esquina2rotacion180 = new Casilla(2, 180, new Vector3(x - 1, y, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true)
            {
                PonerCasilla(esquina2rotacion180);
            }
        }

        //Gris - esquina2rotacion270
        private void CalcularTerreno_Xmenos1_Zmas1(int x, float y, int z)
        {
            Casilla rampas4rotacion0 = new Casilla(39, 0, new Vector3(x - 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z + 2], y, 90) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarVacio(terrenos[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z + 2], y, 90) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarTerreno2(terrenos[x, z + 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 2], y, 90) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarVacio(terrenos[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarVacio(terrenos[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarTerreno1(terrenos[x, z + 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x - 2, z]) == true && ComprobarTerreno3(terrenos[x, z + 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Casilla plano = new Casilla(35, 0, new Vector3(x - 1, y + 0.5f, z + 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 2, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(38, 180, new Vector3(x - 1, y, z + 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(38, 0, new Vector3(x - 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(38, 270, new Vector3(x - 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla rampa1rotacion270 = new Casilla(36, 270, new Vector3(x - 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion180 = new Casilla(36, 180, new Vector3(x - 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Casilla esquina2rotacion270 = new Casilla(37, 270, new Vector3(x - 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true)
            {
                PonerCasilla(esquina2rotacion270);
            }
        }

        //Marron Claro - esquina2rotacion90 
        private void CalcularTerreno_Xmas1_Zmenos1(int x, float y, int z)
        {
            Casilla rampas4rotacion0 = new Casilla(34, 0, new Vector3(x + 1, y, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno2(terrenos[x, z - 2], y - 0.5f, 0) == true && ComprobarVacio(terrenos[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarTerreno2(terrenos[x + 2, z], y - 0.5f, 180) == true && ComprobarVacio(terrenos[x, z - 2]) == true && ComprobarVacio(terrenos[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z - 1]) == true && ComprobarTerreno1(terrenos[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno1(terrenos[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno1(terrenos[x, z - 2], y - 0.5f, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno2(terrenos[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z - 1]) == true && ComprobarTerreno2(terrenos[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z - 1]) == true && ComprobarTerreno2(terrenos[x, z - 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno1(terrenos[x, z - 2], y - 0.5f, 270) == true && ComprobarVacio(terrenos[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno3(terrenos[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno3(terrenos[x, z - 2], y - 0.5f, 0) == true && ComprobarVacio(terrenos[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z - 1]) == true && ComprobarTerreno1(terrenos[x, z - 2], y - 0.5f, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Casilla plano = new Casilla(30, 0, new Vector3(x + 1, y + 0.5f, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z - 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(33, 180, new Vector3(x + 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarVacio(terrenos[x + 1, z - 2]) == true && ComprobarVacio(terrenos[x + 2, z]) == false)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(33, 0, new Vector3(x + 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(33, 90, new Vector3(x + 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true && ComprobarTerreno1(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 2], y, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Casilla rampa1rotacion0 = new Casilla(31, 0, new Vector3(x + 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Casilla rampa1rotacion90 = new Casilla(31, 90, new Vector3(x + 1, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Casilla esquina2rotacion90 = new Casilla(32, 90, new Vector3(x + 1, y, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true)
            {
                PonerCasilla(esquina2rotacion90);
            }
        }

        //Morado - esquina2rotacion0
        private void CalcularTerreno_Xmas1_Zmas1(int x, float y, int z)
        {
            Casilla rampas4rotacion90 = new Casilla(29, 90, new Vector3(x + 1, y, z + 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y - 0.5f, 270) == true && ComprobarVacio(terrenos[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z], y - 0.5f, 180) == true && ComprobarVacio(terrenos[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno2(terrenos[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarTerreno2(terrenos[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno3(terrenos[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarTerreno1(terrenos[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno1(terrenos[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno2(terrenos[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarTerreno1(terrenos[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarTerreno2(terrenos[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarTerreno0(terrenos[x + 1, z], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarTerreno1(terrenos[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarTerreno2(terrenos[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarTerreno2(terrenos[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            Casilla plano = new Casilla(25, 0, new Vector3(x + 1, y + 0.5f, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno1(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno1(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(28, 0, new Vector3(x + 1, y, z + 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true && ComprobarVacio(terrenos[x + 1, z]) == false)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true && ComprobarVacio(terrenos[x + 1, z]) == false && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true && ComprobarVacio(terrenos[x + 1, z]) == false)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true && ComprobarVacio(terrenos[x + 1, z]) == false)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(28, 90, new Vector3(x + 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarVacio(terrenos[x + 2, z]) == true && ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarVacio(terrenos[x, z + 2]) == false)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x + 2, z + 2]) == true && ComprobarVacio(terrenos[x + 2, z]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarVacio(terrenos[x + 2, z + 1]) == true && ComprobarVacio(terrenos[x, z + 1]) == false)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(28, 270, new Vector3(x + 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarVacio(terrenos[x + 1, z + 2]) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarVacio(terrenos[x + 1, z + 2]) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno3(terrenos[x + 2, z + 2], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion270 = new Casilla(26, 270, new Vector3(x + 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion0 = new Casilla(26, 0, new Vector3(x + 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Casilla esquina2rotacion0 = new Casilla(27, 0, new Vector3(x + 1, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion0);
            }
        }

        //Rojo - rampa1rotacion90
        private void CalcularTerreno_X0_Zmenos1(int x, float y, int z)
        {
            Casilla plano = new Casilla(20, 0, new Vector3(x, y + 0.5f, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(23, 90, new Vector3(x, y, z - 1));

            if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(23, 180, new Vector3(x, y, z - 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla rampa1rotacion90 = new Casilla(21, 90, new Vector3(x, y, z - 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
        }

        //Marron Oscuro - rampa1rotacion180
        private void CalcularTerreno_Xmenos1_Z0(int x, float y, int z)
        {
            Casilla plano = new Casilla(5, 0, new Vector3(x - 1, y + 0.5f, z));

            if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(8, 270, new Vector3(x - 1, y, z));

            if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla esquina3rotacion180 = new Casilla(8, 180, new Vector3(x - 1, y, z));

            if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla rampa1rotacion180 = new Casilla(6, 180, new Vector3(x - 1, y, z));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
        }

        //Blanco - rampa1rotacion270
        private void CalcularTerreno_X0_Zmas1(int x, float y, int z)
        {
            Casilla plano = new Casilla(10, 0, new Vector3(x, y + 0.5f, z + 1));

            if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(13, 0, new Vector3(x, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion270 = new Casilla(13, 270, new Vector3(x, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion270 = new Casilla(11, 270, new Vector3(x, y, z + 1));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
        }

        //Amarillo - rampa1rotacion0
        private void CalcularTerreno_Xmas1_Z0(int x, float y, int z)
        {
            Casilla plano = new Casilla(15, 0, new Vector3(x + 1, y + 0.5f, z));

            if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina3rotacion0 = new Casilla(18, 0, new Vector3(x + 1, y, z));

            if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Casilla esquina3rotacion90 = new Casilla(18, 90, new Vector3(x + 1, y, z));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno1(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno0(terrenos[x, z], y, 0) == true && ComprobarTerreno0(terrenos[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true && ComprobarTerreno2(terrenos[x, z + 1], y, 0) == true && ComprobarTerreno2(terrenos[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Casilla rampa1rotacion0 = new Casilla(16, 0, new Vector3(x + 1, y, z));

            if (ComprobarTerreno0(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno1(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarTerreno2(terrenos[x, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------

        private void GenerarAgua(List<Vector3> listadoAguaInicial)
        {
            foreach (Vector3 casillaInicial in listadoAguaInicial.ToList<Vector3>())
            {
                if (Limites.Comprobar((int)casillaInicial.x, 3, (int)tamañoEscenarioX) == true && Limites.Comprobar((int)casillaInicial.z, 3, (int)tamañoEscenarioZ) == true)
                {
                    if (terrenos[(int)casillaInicial.x, (int)casillaInicial.z] == null)
                    {
                        PonerCasilla(new Casilla(40, 0, casillaInicial));
                        listadoAguaInicial.Remove(casillaInicial);
                    }
                }
            }

            foreach (Casilla subcasilla in terrenos)
            {
                if (subcasilla != null)
                {
                    if (subcasilla.id == 5)
                    {
                        int x = (int)subcasilla.posicion.x;
                        int z = (int)subcasilla.posicion.z;

                        if (Limites.Comprobar(x, 2, tamañoEscenarioX) == true && Limites.Comprobar(z, 2, tamañoEscenarioZ) == true)
                        {
                            if (terrenos[x - 1, z - 1] == null)
                            {
                                CalcularAgua_Xmenos1_Zmenos1(x, z);
                            }

                            if (terrenos[x + 1, z + 1] == null)
                            {
                                CalcularAgua_Xmas1_Zmas1(x, z);
                            }

                            if (terrenos[x - 1, z + 1] == null)
                            {
                                CalcularAgua_Xmenos1_Zmas1(x, z);
                            }

                            if (terrenos[x + 1, z - 1] == null)
                            {
                                CalcularAgua_Xmas1_Zmenos1(x, z);
                            }

                            if (terrenos[x, z - 1] == null)
                            {
                                CalcularAgua_X0_Zmenos1(x, z);
                            }

                            if (terrenos[x, z + 1] == null)
                            {
                                CalcularAgua_X0_Zmas1(x, z);
                            }

                            if (terrenos[x - 1, z] == null)
                            {
                                CalcularAgua_Xmenos1_Z0(x, z);
                            }

                            if (terrenos[x + 1, z] == null)
                            {
                                CalcularAgua_Xmas1_Z0(x, z);
                            }
                        }
                    }
                }
            }
        }

        private void CalcularAgua_Xmenos1_Zmenos1(int x, int z)
        {
            Casilla esquina3rotacion0 = new Casilla(43, 0, new Vector3(x - 1, 0, z - 1));

            if (ComprobarVacio(terrenos[x - 1, z]) == true && ComprobarVacio(terrenos[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarAgua2(x - 1, z, 0) == true && ComprobarVacio(terrenos[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
        }

        private void CalcularAgua_Xmas1_Zmas1(int x, int z)
        {
            Casilla esquina3rotacion180 = new Casilla(43, 180, new Vector3(x + 1, 0, z + 1));

            if (ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarVacio(terrenos[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarAgua2(x + 1, z, 180) == true && ComprobarVacio(terrenos[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarAgua2(x, z + 1, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Casilla esquina2rotacion180 = new Casilla(42, 180, new Vector3(x + 1, 0, z + 1));

            if (ComprobarAgua0(x + 1, z) == true && ComprobarAgua0(x, z + 1) == true && ComprobarAgua0(x + 1, z + 2) == false)
            {
                PonerCasilla(esquina2rotacion180);
            }
        }

        private void CalcularAgua_Xmenos1_Zmas1(int x, int z)
        {
            Casilla esquina3rotacion90 = new Casilla(43, 90, new Vector3(x - 1, 0, z + 1));

            if (ComprobarVacio(terrenos[x - 1, z]) == true && ComprobarVacio(terrenos[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarAgua2(x - 1, z, 90) == true && ComprobarVacio(terrenos[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
        }

        private void CalcularAgua_Xmas1_Zmenos1(int x, int z)
        {
            Casilla esquina3rotacion270 = new Casilla(43, 270, new Vector3(x + 1, 0, z - 1));

            if (ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarVacio(terrenos[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarVacio(terrenos[x + 1, z]) == true && ComprobarAgua2(x, z - 1, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
        }

        private void CalcularAgua_X0_Zmenos1(int x, int z)
        {
            Casilla esquina2rotacion0 = new Casilla(42, 0, new Vector3(x, 0, z - 1));

            if (ComprobarAgua0(x + 1, z - 1) == true)
            {
                PonerCasilla(esquina2rotacion0);
            }

            //---------------------------------------

            Casilla rampa1rotacion270 = new Casilla(41, 270, new Vector3(x, 0, z - 1));

            PonerCasilla(rampa1rotacion270);
        }

        private void CalcularAgua_X0_Zmas1(int x, int z)
        {
            Casilla esquina2rotacion90 = new Casilla(42, 90, new Vector3(x, 0, z + 1));

            if (ComprobarAgua0(x + 1, z + 1) == true && ComprobarVacio(terrenos[x - 1, z + 2]) == true)
            {
                PonerCasilla(esquina2rotacion90);
            }

            //---------------------------------------

            Casilla rampa1rotacion90 = new Casilla(41, 90, new Vector3(x, 0, z + 1));

            PonerCasilla(rampa1rotacion90);
        }

        private void CalcularAgua_Xmenos1_Z0(int x, int z)
        {
            Casilla rampa1rotacion0 = new Casilla(41, 0, new Vector3(x - 1, 0, z));

            PonerCasilla(rampa1rotacion0);
        }

        private void CalcularAgua_Xmas1_Z0(int x, int z)
        {
            Casilla plano = new Casilla(40, 0, new Vector3(x + 1, 0.25f, z));

            if (ComprobarAgua0(x + 1, z - 1) == true && ComprobarAgua0(x + 1, z + 1) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Casilla esquina2rotacion270 = new Casilla(42, 270, new Vector3(x + 1, 0, z));

            if (ComprobarAgua0(x + 1, z + 1) == true && ComprobarVacio(terrenos[x + 2, z - 1]) == true)
            {
                PonerCasilla(esquina2rotacion270);
            }

            //---------------------------------------

            Casilla rampa1rotacion180 = new Casilla(41, 180, new Vector3(x + 1, 0, z));

            PonerCasilla(rampa1rotacion180);
        }

        //------------------------------------------------------------------------------------------------------------------------------------

        private void PonerCasilla(Casilla terreno)
        {
            Casilla[] casillasFinal;
            int id = terreno.id;

            if (coloresGeneracion == false)
            {
                //if (estacion == 0)
                //{
                //    casillasFinal = casillasInvierno;
                //}
                //else if (estacion == 1)
                //{
                //    casillasFinal = casillasPrimavera;
                //}
                //else if (estacion == 2)
                //{
                //    casillasFinal = casillasVerano;
                //}
                //else if (estacion == 3)
                //{
                //    casillasFinal = casillasOtoño;
                //}
                //else
                //{
                //    casillasFinal = casillasDebug;
                //}
                casillasFinal = casillasDebug;
                id = CalcularIDFinal(terreno.id);
            }
            else
            {
                casillasFinal = casillasDebug;
                id = terreno.id;
            }

            int x = (int)terreno.posicion.x;
            int z = (int)terreno.posicion.z;

            if (Limites.Comprobar(x, 3, tamañoEscenarioX) == true && Limites.Comprobar(z, 3, tamañoEscenarioZ) == true)
            {
                if (terrenos[x, z] == null)
                {
                    Vector3 posicionFinal = terreno.posicion;

                    if (casillasEscala != 0.5f)
                    {
                        posicionFinal.x = (posicionFinal.x + posicionFinal.x * (casillasEscala * 1.5f)) - (tamañoEscenarioX / 2);
                        posicionFinal.y = posicionFinal.y + posicionFinal.y * (casillasEscala * 1.5f);
                        posicionFinal.z = (posicionFinal.z + posicionFinal.z * (casillasEscala * 1.5f)) - (tamañoEscenarioZ / 2);
                    }
                    
                    Casilla terreno2 = Instantiate(casillasFinal[id], posicionFinal, Quaternion.identity);
                    terreno2.gameObject.transform.Rotate(Vector3.up, terreno.rotacion, Space.World);
                    terreno2.gameObject.transform.localScale = new Vector3(casillasEscala, casillasEscala, casillasEscala);
                    terreno2.rotacion = terreno.rotacion;
                    terreno2.posicion = terreno.posicion;
                    terreno2.idDebug = terreno.idDebug;

                    terrenos[x, z] = terreno2;
                }
            }
        }

        private int CalcularIDFinal(int id)
        {
            if (id >= 5 && id <= 9)
            {
                id = id - 5;
            }
            else if (id >= 10 && id <= 14)
            {
                id = id - 10;
            }
            else if (id >= 15 && id <= 19)
            {
                id = id - 15;
            }
            else if (id >= 20 && id <= 24)
            {
                id = id - 20;
            }
            else if (id >= 25 && id <= 29)
            {
                id = id - 25;
            }
            else if (id >= 30 && id <= 34)
            {
                id = id - 30;
            }
            else if (id >= 34 && id <= 39)
            {
                id = id - 35;
            }
            else if (id >= 40 && id <= 44)
            {
                id = id - 35;
            }

            return id;
        }

        private bool ComprobarTerreno0(Casilla terreno, float altura, int rotacion)
        {
            if (terreno != null)
            {
                if (ComprobarLimiteX((int)terreno.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)terreno.posicion.z, limitesMapa) == true)
                {
                    if (terreno.posicion.y == (altura + 0.5f))
                    {
                        if (terreno.rotacion == rotacion)
                        {
                            if (terreno.id == 0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarTerreno1(Casilla terreno, float altura, int rotacion)
        {
            if (terreno != null)
            {
                if (ComprobarLimiteX((int)terreno.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)terreno.posicion.z, limitesMapa) == true)
                {
                    if (terreno.posicion.y == (altura + 0.5f))
                    {
                        if (terreno.rotacion == rotacion)
                        {
                            if (terreno.id == 1)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarTerreno2(Casilla terreno, float altura, int rotacion)
        {
            if (terreno != null)
            {
                if (ComprobarLimiteX((int)terreno.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)terreno.posicion.z, limitesMapa) == true)
                {
                    if (terreno.posicion.y == (altura + 0.5f))
                    {
                        if (terreno.rotacion == rotacion)
                        {
                            if (terreno.id == 2)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarTerreno3(Casilla terreno, float altura, int rotacion)
        {
            if (terreno != null)
            {
                if (ComprobarLimiteX((int)terreno.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)terreno.posicion.z, limitesMapa) == true)
                {
                    if (terreno.posicion.y == (altura + 0.5f))
                    {
                        if (terreno.rotacion == rotacion)
                        {
                            if (terreno.id == 3)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarVacio(Casilla terreno)
        {
            if (terreno != null)
            {
                if (ComprobarLimiteX((int)terreno.posicion.x, 3) == true && ComprobarLimiteZ((int)terreno.posicion.z, 3) == true)
                {
                    if (terrenos[(int)terreno.posicion.x, (int)terreno.posicion.z] != null)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool ComprobarAgua0(int x, int z)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (terrenos[x, z] != null)
                {
                    if (terrenos[x, z].id == 5)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarAgua1(int x, int z, int rotacion)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (terrenos[x, z] != null)
                {
                    if (terrenos[x, z].id == 6 && terrenos[x, z].rotacion == rotacion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarAgua2(int x, int z, int rotacion)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (terrenos[x, z] != null)
                {
                    if (terrenos[x, z].id == 7 && terrenos[x, z].rotacion == rotacion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarAgua3(int x, int z, int rotacion)
        {
            if (ComprobarLimiteX(x, limitesMapa) == true && ComprobarLimiteZ(z, limitesMapa) == true)
            {
                if (terrenos[x, z] != null)
                {
                    if (terrenos[x, z].id == 8 && terrenos[x, z].rotacion == rotacion)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool ComprobarLimiteX(int x, int ajuste)
        {
            if ((x - ajuste >= 0) && (x + ajuste <= tamañoEscenarioX))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ComprobarLimiteZ(int z, int ajuste)
        {
            if ((z - ajuste >= 0) && (z + ajuste <= tamañoEscenarioZ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PonerLlano2(float altura)
        {
            for (int x = 0; x < terrenos.GetLength(0); x++)
            {
                for (int z = 0; z < terrenos.GetLength(1); z++)
                {
                    if (terrenos[x, z] == null)
                    {
                        if (x >= limitesMapa && z >= limitesMapa && x <= tamañoEscenarioX - limitesMapa && z <= tamañoEscenarioZ - limitesMapa)
                        {
                            Casilla plano = new Casilla(0, 0, new Vector3(x, altura, z));
                            PonerCasilla(plano);
                        }
                    }
                }
            }
        }
    }
}

