using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Escenario.Generar
{
    public class Escenario : MonoBehaviour
    {
        [Header("Opciones")]
        public bool aleatorio;
        public bool coloresGeneracion;
        public bool agua;
        public bool ponerLlano;
        public bool colocarJugador;
        public bool guardarDatos;

        [Header("Casillas")]
        public Assets.Casilla[] casillasDebug;
        public Assets.Isla[] islas;

        [HideInInspector]
        public Assets.Casilla[,] casillas = new Assets.Casilla[1, 1];

        private int tamañoEscenarioX = 0;
        private int tamañoEscenarioZ = 0;

        [HideInInspector]
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
            int alturaMaxima = 1;

            foreach (Assets.Isla isla in islas)
            {
                if (isla.alturaMaxima > alturaMaxima)
                {
                    alturaMaxima = (int)isla.alturaMaxima;
                }

                tamañoEscenarioX = tamañoEscenarioX + (int)isla.extensionMaxima.x + 50;
                tamañoEscenarioZ = tamañoEscenarioZ + (int)isla.extensionMaxima.y + 50;
            }

            casillas = new Assets.Casilla[tamañoEscenarioX, tamañoEscenarioZ];

            List<Vector3> listadoTerrenoInicial = new List<Vector3>();

            if (aleatorio == true)
            {
                listadoTerrenoInicial = Vectores.instancia.GenerarCasillas(casillas, islas, limitesMapa);
            }
            else
            {
                listadoTerrenoInicial = new List<Vector3> {
new Vector3(42, 4, 14),
new Vector3(39, 3.5f, 17),
new Vector3(46, 3.5f, 13),
new Vector3(46, 3.5f, 13),
new Vector3(45, 3.5f, 11),
new Vector3(41, 3.5f, 18),
new Vector3(37, 3, 9),
new Vector3(37, 3, 19),
new Vector3(47, 3, 19),
new Vector3(42, 2.5f, 22),
new Vector3(43, 2, 23),
new Vector3(43, 2, 24),
new Vector3(43, 2, 25),
new Vector3(44, 2, 23),
new Vector3(44, 2, 24),
new Vector3(44, 2, 25),
new Vector3(45, 2, 23),
new Vector3(45, 2, 24),
new Vector3(45, 2, 25),
new Vector3(41, 2, 23),
new Vector3(41, 2, 24),
new Vector3(41, 2, 25),
new Vector3(42, 2, 23),
new Vector3(42, 2, 24),
new Vector3(42, 2, 25),
new Vector3(43, 2, 23),
new Vector3(43, 2, 24),
new Vector3(43, 2, 25),
new Vector3(31, 2, 15),
new Vector3(31, 2, 16),
new Vector3(31, 2, 17),
new Vector3(32, 2, 15),
new Vector3(32, 2, 16),
new Vector3(32, 2, 17),
new Vector3(33, 2, 15),
new Vector3(33, 2, 16),
new Vector3(33, 2, 17),
new Vector3(39, 2, 23),
new Vector3(39, 2, 24),
new Vector3(39, 2, 25),
new Vector3(40, 2, 23),
new Vector3(40, 2, 24),
new Vector3(40, 2, 25),
new Vector3(41, 2, 23),
new Vector3(41, 2, 24),
new Vector3(41, 2, 25),
new Vector3(44, 1.5f, 2),
new Vector3(44, 1.5f, 3),
new Vector3(45, 1.5f, 2),
new Vector3(45, 1.5f, 3),
new Vector3(46, 1.5f, 2),
new Vector3(46, 1.5f, 3),
new Vector3(30, 1.5f, 24),
new Vector3(30, 1.5f, 25),
new Vector3(30, 1.5f, 26),
new Vector3(31, 1.5f, 24),
new Vector3(31, 1.5f, 25),
new Vector3(31, 1.5f, 26),
new Vector3(32, 1.5f, 24),
new Vector3(32, 1.5f, 25),
new Vector3(32, 1.5f, 26),
new Vector3(30, 1.5f, 2),
new Vector3(30, 1.5f, 3),
new Vector3(30, 1.5f, 4),
new Vector3(31, 1.5f, 2),
new Vector3(31, 1.5f, 3),
new Vector3(31, 1.5f, 4),
new Vector3(32, 1.5f, 2),
new Vector3(32, 1.5f, 3),
new Vector3(32, 1.5f, 4),
new Vector3(38, 1.5f, 25),
new Vector3(38, 1.5f, 26),
new Vector3(38, 1.5f, 27),
new Vector3(39, 1.5f, 25),
new Vector3(39, 1.5f, 26),
new Vector3(39, 1.5f, 27),
new Vector3(40, 1.5f, 25),
new Vector3(40, 1.5f, 26),
new Vector3(40, 1.5f, 27),
new Vector3(27, 1, 2),
new Vector3(27, 1, 3),
new Vector3(28, 1, 2),
new Vector3(28, 1, 3),
new Vector3(29, 1, 2),
new Vector3(29, 1, 3),
new Vector3(30, 1, 2),
new Vector3(30, 1, 3),
new Vector3(31, 1, 2),
new Vector3(31, 1, 3),
new Vector3(40, 3, 30),
new Vector3(44, 2.5f, 29),
new Vector3(40, 2.5f, 26),
new Vector3(39, 2, 35),
new Vector3(39, 2, 36),
new Vector3(39, 2, 37),
new Vector3(40, 2, 35),
new Vector3(40, 2, 36),
new Vector3(40, 2, 37),
new Vector3(41, 2, 35),
new Vector3(41, 2, 36),
new Vector3(41, 2, 37),
new Vector3(38, 2, 23),
new Vector3(38, 2, 24),
new Vector3(38, 2, 25),
new Vector3(39, 2, 23),
new Vector3(39, 2, 24),
new Vector3(39, 2, 25),
new Vector3(40, 2, 23),
new Vector3(40, 2, 24),
new Vector3(40, 2, 25),
new Vector3(44, 2, 24),
new Vector3(44, 2, 25),
new Vector3(44, 2, 26),
new Vector3(45, 2, 24),
new Vector3(45, 2, 25),
new Vector3(45, 2, 26),
new Vector3(46, 2, 24),
new Vector3(46, 2, 25),
new Vector3(46, 2, 26),
new Vector3(38, 2, 23),
new Vector3(38, 2, 24),
new Vector3(38, 2, 25),
new Vector3(39, 2, 23),
new Vector3(39, 2, 24),
new Vector3(39, 2, 25),
new Vector3(40, 2, 23),
new Vector3(40, 2, 24),
new Vector3(40, 2, 25),
new Vector3(44, 2, 34),
new Vector3(44, 2, 35),
new Vector3(44, 2, 36),
new Vector3(45, 2, 34),
new Vector3(45, 2, 35),
new Vector3(45, 2, 36),
new Vector3(46, 2, 34),
new Vector3(46, 2, 35),
new Vector3(46, 2, 36),
new Vector3(31, 1.5f, 28),
new Vector3(31, 1.5f, 29),
new Vector3(31, 1.5f, 30),
new Vector3(32, 1.5f, 28),
new Vector3(32, 1.5f, 29),
new Vector3(32, 1.5f, 30),
new Vector3(33, 1.5f, 28),
new Vector3(33, 1.5f, 29),
new Vector3(33, 1.5f, 30),
new Vector3(40, 1.5f, 37),
new Vector3(40, 1.5f, 38),
new Vector3(40, 1.5f, 39),
new Vector3(41, 1.5f, 37),
new Vector3(41, 1.5f, 38),
new Vector3(41, 1.5f, 39),
new Vector3(42, 1.5f, 37),
new Vector3(42, 1.5f, 38),
new Vector3(42, 1.5f, 39),
new Vector3(41, 1, 38),
new Vector3(41, 1, 39),
new Vector3(41, 1, 40),
new Vector3(41, 1, 41),
new Vector3(41, 1, 42),
new Vector3(42, 1, 38),
new Vector3(42, 1, 39),
new Vector3(42, 1, 40),
new Vector3(42, 1, 41),
new Vector3(42, 1, 42),
new Vector3(43, 1, 38),
new Vector3(43, 1, 39),
new Vector3(43, 1, 40),
new Vector3(43, 1, 41),
new Vector3(43, 1, 42),
new Vector3(44, 1, 38),
new Vector3(44, 1, 39),
new Vector3(44, 1, 40),
new Vector3(44, 1, 41),
new Vector3(44, 1, 42),
new Vector3(45, 1, 38),
new Vector3(45, 1, 39),
new Vector3(45, 1, 40),
new Vector3(45, 1, 41),
new Vector3(45, 1, 42),
new Vector3(47, 1, 37),
new Vector3(47, 1, 38),
new Vector3(47, 1, 39),
new Vector3(47, 1, 40),
new Vector3(47, 1, 41),
new Vector3(48, 1, 37),
new Vector3(48, 1, 38),
new Vector3(48, 1, 39),
new Vector3(48, 1, 40),
new Vector3(48, 1, 41),
new Vector3(40, 1, 18),
new Vector3(40, 1, 19),
new Vector3(40, 1, 20),
new Vector3(40, 1, 21),
new Vector3(40, 1, 22),
new Vector3(41, 1, 18),
new Vector3(41, 1, 19),
new Vector3(41, 1, 20),
new Vector3(41, 1, 21),
new Vector3(41, 1, 22),
new Vector3(42, 1, 18),
new Vector3(42, 1, 19),
new Vector3(42, 1, 20),
new Vector3(42, 1, 21),
new Vector3(42, 1, 22),
new Vector3(43, 1, 18),
new Vector3(43, 1, 19),
new Vector3(43, 1, 20),
new Vector3(43, 1, 21),
new Vector3(43, 1, 22),
new Vector3(44, 1, 18),
new Vector3(44, 1, 19),
new Vector3(44, 1, 20),
new Vector3(44, 1, 21),
new Vector3(44, 1, 22),
new Vector3(37, 1, 18),
new Vector3(37, 1, 19),
new Vector3(37, 1, 20),
new Vector3(37, 1, 21),
new Vector3(37, 1, 22),
new Vector3(38, 1, 18),
new Vector3(38, 1, 19),
new Vector3(38, 1, 20),
new Vector3(38, 1, 21),
new Vector3(38, 1, 22),
new Vector3(39, 1, 18),
new Vector3(39, 1, 19),
new Vector3(39, 1, 20),
new Vector3(39, 1, 21),
new Vector3(39, 1, 22),
new Vector3(40, 1, 18),
new Vector3(40, 1, 19),
new Vector3(40, 1, 20),
new Vector3(40, 1, 21),
new Vector3(40, 1, 22),
new Vector3(41, 1, 18),
new Vector3(41, 1, 19),
new Vector3(41, 1, 20),
new Vector3(41, 1, 21),
new Vector3(41, 1, 22),
new Vector3(9, 3, 44),
new Vector3(13, 2.5f, 44),
new Vector3(13, 2, 38),
new Vector3(13, 2, 39),
new Vector3(13, 2, 40),
new Vector3(14, 2, 38),
new Vector3(14, 2, 39),
new Vector3(14, 2, 40),
new Vector3(15, 2, 38),
new Vector3(15, 2, 39),
new Vector3(15, 2, 40),
new Vector3(2, 2, 41),
new Vector3(2, 2, 42),
new Vector3(2, 2, 43),
new Vector3(3, 2, 41),
new Vector3(3, 2, 42),
new Vector3(3, 2, 43),
new Vector3(4, 2, 41),
new Vector3(4, 2, 42),
new Vector3(4, 2, 43),
new Vector3(16, 1.5f, 40),
new Vector3(16, 1.5f, 41),
new Vector3(16, 1.5f, 42),
new Vector3(17, 1.5f, 40),
new Vector3(17, 1.5f, 41),
new Vector3(17, 1.5f, 42),
new Vector3(18, 1.5f, 40),
new Vector3(18, 1.5f, 41),
new Vector3(18, 1.5f, 42),
new Vector3(8, 1.5f, 35),
new Vector3(8, 1.5f, 36),
new Vector3(8, 1.5f, 37),
new Vector3(9, 1.5f, 35),
new Vector3(9, 1.5f, 36),
new Vector3(9, 1.5f, 37),
new Vector3(10, 1.5f, 35),
new Vector3(10, 1.5f, 36),
new Vector3(10, 1.5f, 37),
new Vector3(2, 1.5f, 45),
new Vector3(2, 1.5f, 46),
new Vector3(2, 1.5f, 47),
new Vector3(2, 1, 33),
new Vector3(2, 1, 34),
new Vector3(2, 1, 35),
new Vector3(2, 1, 36),
new Vector3(2, 1, 37),
new Vector3(2, 1, 33),
new Vector3(2, 1, 34),
new Vector3(2, 1, 35),
new Vector3(2, 1, 36),
new Vector3(2, 1, 37),
new Vector3(17, 1, 38),
new Vector3(17, 1, 39),
new Vector3(17, 1, 40),
new Vector3(17, 1, 41),
new Vector3(17, 1, 42),
new Vector3(18, 1, 38),
new Vector3(18, 1, 39),
new Vector3(18, 1, 40),
new Vector3(18, 1, 41),
new Vector3(18, 1, 42),
new Vector3(19, 1, 38),
new Vector3(19, 1, 39),
new Vector3(19, 1, 40),
new Vector3(19, 1, 41),
new Vector3(19, 1, 42),
new Vector3(20, 1, 38),
new Vector3(20, 1, 39),
new Vector3(20, 1, 40),
new Vector3(20, 1, 41),
new Vector3(20, 1, 42),
new Vector3(21, 1, 38),
new Vector3(21, 1, 39),
new Vector3(21, 1, 40),
new Vector3(21, 1, 41),
new Vector3(21, 1, 42),
new Vector3(9, 1, 32),
new Vector3(9, 1, 33),
new Vector3(9, 1, 34),
new Vector3(9, 1, 35),
new Vector3(9, 1, 36),
new Vector3(10, 1, 32),
new Vector3(10, 1, 33),
new Vector3(10, 1, 34),
new Vector3(10, 1, 35),
new Vector3(10, 1, 36),
new Vector3(11, 1, 32),
new Vector3(11, 1, 33),
new Vector3(11, 1, 34),
new Vector3(11, 1, 35),
new Vector3(11, 1, 36),
new Vector3(12, 1, 32),
new Vector3(12, 1, 33),
new Vector3(12, 1, 34),
new Vector3(12, 1, 35),
new Vector3(12, 1, 36),
new Vector3(13, 1, 32),
new Vector3(13, 1, 33),
new Vector3(13, 1, 34),
new Vector3(13, 1, 35),
new Vector3(13, 1, 36),
new Vector3(27, 4, 24),
new Vector3(26, 3.5f, 20),
new Vector3(24, 3.5f, 21),
new Vector3(22, 3, 29),
new Vector3(27, 3, 30),
new Vector3(22, 3, 29),
new Vector3(27, 3, 30),
new Vector3(20, 2.5f, 31),
new Vector3(24, 2, 33),
new Vector3(24, 2, 34),
new Vector3(24, 2, 35),
new Vector3(25, 2, 33),
new Vector3(25, 2, 34),
new Vector3(25, 2, 35),
new Vector3(26, 2, 33),
new Vector3(26, 2, 34),
new Vector3(26, 2, 35),
new Vector3(35, 2, 14),
new Vector3(35, 2, 15),
new Vector3(35, 2, 16),
new Vector3(36, 2, 14),
new Vector3(36, 2, 15),
new Vector3(36, 2, 16),
new Vector3(37, 2, 14),
new Vector3(37, 2, 15),
new Vector3(37, 2, 16),
new Vector3(36, 2, 21),
new Vector3(36, 2, 22),
new Vector3(36, 2, 23),
new Vector3(37, 2, 21),
new Vector3(37, 2, 22),
new Vector3(37, 2, 23),
new Vector3(38, 2, 21),
new Vector3(38, 2, 22),
new Vector3(38, 2, 23),
new Vector3(36, 2, 26),
new Vector3(36, 2, 27),
new Vector3(36, 2, 28),
new Vector3(37, 2, 26),
new Vector3(37, 2, 27),
new Vector3(37, 2, 28),
new Vector3(38, 2, 26),
new Vector3(38, 2, 27),
new Vector3(38, 2, 28),
new Vector3(16, 2, 24),
new Vector3(16, 2, 25),
new Vector3(16, 2, 26),
new Vector3(17, 2, 24),
new Vector3(17, 2, 25),
new Vector3(17, 2, 26),
new Vector3(18, 2, 24),
new Vector3(18, 2, 25),
new Vector3(18, 2, 26),
new Vector3(22, 2, 33),
new Vector3(22, 2, 34),
new Vector3(22, 2, 35),
new Vector3(23, 2, 33),
new Vector3(23, 2, 34),
new Vector3(23, 2, 35),
new Vector3(24, 2, 33),
new Vector3(24, 2, 34),
new Vector3(24, 2, 35),
new Vector3(17, 2, 32),
new Vector3(17, 2, 33),
new Vector3(17, 2, 34),
new Vector3(18, 2, 32),
new Vector3(18, 2, 33),
new Vector3(18, 2, 34),
new Vector3(19, 2, 32),
new Vector3(19, 2, 33),
new Vector3(19, 2, 34),
new Vector3(38, 1.5f, 18),
new Vector3(38, 1.5f, 19),
new Vector3(38, 1.5f, 20),
new Vector3(39, 1.5f, 18),
new Vector3(39, 1.5f, 19),
new Vector3(39, 1.5f, 20),
new Vector3(40, 1.5f, 18),
new Vector3(40, 1.5f, 19),
new Vector3(40, 1.5f, 20),
new Vector3(38, 1.5f, 26),
new Vector3(38, 1.5f, 27),
new Vector3(38, 1.5f, 28),
new Vector3(39, 1.5f, 26),
new Vector3(39, 1.5f, 27),
new Vector3(39, 1.5f, 28),
new Vector3(40, 1.5f, 26),
new Vector3(40, 1.5f, 27),
new Vector3(40, 1.5f, 28),
new Vector3(24, 1.5f, 35),
new Vector3(24, 1.5f, 36),
new Vector3(24, 1.5f, 37),
new Vector3(25, 1.5f, 35),
new Vector3(25, 1.5f, 36),
new Vector3(25, 1.5f, 37),
new Vector3(26, 1.5f, 35),
new Vector3(26, 1.5f, 36),
new Vector3(26, 1.5f, 37),
new Vector3(12, 1, 35),
new Vector3(12, 1, 36),
new Vector3(12, 1, 37),
new Vector3(12, 1, 38),
new Vector3(12, 1, 39),
new Vector3(13, 1, 35),
new Vector3(13, 1, 36),
new Vector3(13, 1, 37),
new Vector3(13, 1, 38),
new Vector3(13, 1, 39),
new Vector3(14, 1, 35),
new Vector3(14, 1, 36),
new Vector3(14, 1, 37),
new Vector3(14, 1, 38),
new Vector3(14, 1, 39),
new Vector3(15, 1, 35),
new Vector3(15, 1, 36),
new Vector3(15, 1, 37),
new Vector3(15, 1, 38),
new Vector3(15, 1, 39),
new Vector3(16, 1, 35),
new Vector3(16, 1, 36),
new Vector3(16, 1, 37),
new Vector3(16, 1, 38),
new Vector3(16, 1, 39),
new Vector3(22, 1, 36),
new Vector3(22, 1, 37),
new Vector3(22, 1, 38),
new Vector3(22, 1, 39),
new Vector3(22, 1, 40),
new Vector3(23, 1, 36),
new Vector3(23, 1, 37),
new Vector3(23, 1, 38),
new Vector3(23, 1, 39),
new Vector3(23, 1, 40),
new Vector3(24, 1, 36),
new Vector3(24, 1, 37),
new Vector3(24, 1, 38),
new Vector3(24, 1, 39),
new Vector3(24, 1, 40),
new Vector3(25, 1, 36),
new Vector3(25, 1, 37),
new Vector3(25, 1, 38),
new Vector3(25, 1, 39),
new Vector3(25, 1, 40),
new Vector3(26, 1, 36),
new Vector3(26, 1, 37),
new Vector3(26, 1, 38),
new Vector3(26, 1, 39),
new Vector3(26, 1, 40),
new Vector3(22, 1, 36),
new Vector3(22, 1, 37),
new Vector3(22, 1, 38),
new Vector3(22, 1, 39),
new Vector3(22, 1, 40),
new Vector3(23, 1, 36),
new Vector3(23, 1, 37),
new Vector3(23, 1, 38),
new Vector3(23, 1, 39),
new Vector3(23, 1, 40),
new Vector3(24, 1, 36),
new Vector3(24, 1, 37),
new Vector3(24, 1, 38),
new Vector3(24, 1, 39),
new Vector3(24, 1, 40),
new Vector3(25, 1, 36),
new Vector3(25, 1, 37),
new Vector3(25, 1, 38),
new Vector3(25, 1, 39),
new Vector3(25, 1, 40),
new Vector3(26, 1, 36),
new Vector3(26, 1, 37),
new Vector3(26, 1, 38),
new Vector3(26, 1, 39),
new Vector3(26, 1, 40),
new Vector3(11, 1, 21),
new Vector3(11, 1, 22),
new Vector3(11, 1, 23),
new Vector3(11, 1, 24),
new Vector3(11, 1, 25),
new Vector3(12, 1, 21),
new Vector3(12, 1, 22),
new Vector3(12, 1, 23),
new Vector3(12, 1, 24),
new Vector3(12, 1, 25),
new Vector3(13, 1, 21),
new Vector3(13, 1, 22),
new Vector3(13, 1, 23),
new Vector3(13, 1, 24),
new Vector3(13, 1, 25),
new Vector3(14, 1, 21),
new Vector3(14, 1, 22),
new Vector3(14, 1, 23),
new Vector3(14, 1, 24),
new Vector3(14, 1, 25),
new Vector3(15, 1, 21),
new Vector3(15, 1, 22),
new Vector3(15, 1, 23),
new Vector3(15, 1, 24),
new Vector3(15, 1, 25),
new Vector3(11, 1, 21),
new Vector3(11, 1, 22),
new Vector3(11, 1, 23),
new Vector3(11, 1, 24),
new Vector3(11, 1, 25),
new Vector3(12, 1, 21),
new Vector3(12, 1, 22),
new Vector3(12, 1, 23),
new Vector3(12, 1, 24),
new Vector3(12, 1, 25),
new Vector3(13, 1, 21),
new Vector3(13, 1, 22),
new Vector3(13, 1, 23),
new Vector3(13, 1, 24),
new Vector3(13, 1, 25),
new Vector3(14, 1, 21),
new Vector3(14, 1, 22),
new Vector3(14, 1, 23),
new Vector3(14, 1, 24),
new Vector3(14, 1, 25),
new Vector3(15, 1, 21),
new Vector3(15, 1, 22),
new Vector3(15, 1, 23),
new Vector3(15, 1, 24),
new Vector3(15, 1, 25),
new Vector3(30, 1, 36),
new Vector3(30, 1, 37),
new Vector3(30, 1, 38),
new Vector3(30, 1, 39),
new Vector3(30, 1, 40),
new Vector3(31, 1, 36),
new Vector3(31, 1, 37),
new Vector3(31, 1, 38),
new Vector3(31, 1, 39),
new Vector3(31, 1, 40),
new Vector3(32, 1, 36),
new Vector3(32, 1, 37),
new Vector3(32, 1, 38),
new Vector3(32, 1, 39),
new Vector3(32, 1, 40),
new Vector3(33, 1, 36),
new Vector3(33, 1, 37),
new Vector3(33, 1, 38),
new Vector3(33, 1, 39),
new Vector3(33, 1, 40),
new Vector3(34, 1, 36),
new Vector3(34, 1, 37),
new Vector3(34, 1, 38),
new Vector3(34, 1, 39),
new Vector3(34, 1, 40),
new Vector3(43, 3, 39),
new Vector3(47, 2.5f, 38),
new Vector3(43, 2, 32),
new Vector3(43, 2, 33),
new Vector3(43, 2, 34),
new Vector3(44, 2, 32),
new Vector3(44, 2, 33),
new Vector3(44, 2, 34),
new Vector3(45, 2, 32),
new Vector3(45, 2, 33),
new Vector3(45, 2, 34),
new Vector3(42, 2, 44),
new Vector3(42, 2, 45),
new Vector3(42, 2, 46),
new Vector3(43, 2, 44),
new Vector3(43, 2, 45),
new Vector3(43, 2, 46),
new Vector3(44, 2, 44),
new Vector3(44, 2, 45),
new Vector3(44, 2, 46),
new Vector3(48, 2, 36),
new Vector3(48, 2, 37),
new Vector3(48, 2, 38),
new Vector3(36, 2, 36),
new Vector3(36, 2, 37),
new Vector3(36, 2, 38),
new Vector3(37, 2, 36),
new Vector3(37, 2, 37),
new Vector3(37, 2, 38),
new Vector3(38, 2, 36),
new Vector3(38, 2, 37),
new Vector3(38, 2, 38),
new Vector3(39, 1.5f, 46),
new Vector3(39, 1.5f, 47),
new Vector3(39, 1.5f, 48),
new Vector3(40, 1.5f, 46),
new Vector3(40, 1.5f, 47),
new Vector3(40, 1.5f, 48),
new Vector3(41, 1.5f, 46),
new Vector3(41, 1.5f, 47),
new Vector3(41, 1.5f, 48),
new Vector3(34, 1.5f, 39),
new Vector3(34, 1.5f, 40),
new Vector3(34, 1.5f, 41),
new Vector3(35, 1.5f, 39),
new Vector3(35, 1.5f, 40),
new Vector3(35, 1.5f, 41),
new Vector3(36, 1.5f, 39),
new Vector3(36, 1.5f, 40),
new Vector3(36, 1.5f, 41),
new Vector3(34, 1.5f, 38),
new Vector3(34, 1.5f, 39),
new Vector3(34, 1.5f, 40),
new Vector3(35, 1.5f, 38),
new Vector3(35, 1.5f, 39),
new Vector3(35, 1.5f, 40),
new Vector3(36, 1.5f, 38),
new Vector3(36, 1.5f, 39),
new Vector3(36, 1.5f, 40),
new Vector3(44, 1.5f, 30),
new Vector3(44, 1.5f, 31),
new Vector3(44, 1.5f, 32),
new Vector3(45, 1.5f, 30),
new Vector3(45, 1.5f, 31),
new Vector3(45, 1.5f, 32),
new Vector3(46, 1.5f, 30),
new Vector3(46, 1.5f, 31),
new Vector3(46, 1.5f, 32),
new Vector3(41, 1, 27),
new Vector3(41, 1, 28),
new Vector3(41, 1, 29),
new Vector3(41, 1, 30),
new Vector3(41, 1, 31),
new Vector3(42, 1, 27),
new Vector3(42, 1, 28),
new Vector3(42, 1, 29),
new Vector3(42, 1, 30),
new Vector3(42, 1, 31),
new Vector3(43, 1, 27),
new Vector3(43, 1, 28),
new Vector3(43, 1, 29),
new Vector3(43, 1, 30),
new Vector3(43, 1, 31),
new Vector3(44, 1, 27),
new Vector3(44, 1, 28),
new Vector3(44, 1, 29),
new Vector3(44, 1, 30),
new Vector3(44, 1, 31),
new Vector3(45, 1, 27),
new Vector3(45, 1, 28),
new Vector3(45, 1, 29),
new Vector3(45, 1, 30),
new Vector3(45, 1, 31),
new Vector3(31, 1, 34),
new Vector3(31, 1, 35),
new Vector3(31, 1, 36),
new Vector3(31, 1, 37),
new Vector3(31, 1, 38),
new Vector3(32, 1, 34),
new Vector3(32, 1, 35),
new Vector3(32, 1, 36),
new Vector3(32, 1, 37),
new Vector3(32, 1, 38),
new Vector3(33, 1, 34),
new Vector3(33, 1, 35),
new Vector3(33, 1, 36),
new Vector3(33, 1, 37),
new Vector3(33, 1, 38),
new Vector3(34, 1, 34),
new Vector3(34, 1, 35),
new Vector3(34, 1, 36),
new Vector3(34, 1, 37),
new Vector3(34, 1, 38),
new Vector3(35, 1, 34),
new Vector3(35, 1, 35),
new Vector3(35, 1, 36),
new Vector3(35, 1, 37),
new Vector3(35, 1, 38),
new Vector3(33, 3, 43),
new Vector3(33, 2.5f, 39),
new Vector3(37, 2.5f, 42),
new Vector3(37, 2.5f, 43),
new Vector3(33, 2.5f, 47),
new Vector3(30, 2.5f, 40),
new Vector3(27, 2, 47),
new Vector3(27, 2, 48),
new Vector3(28, 2, 47),
new Vector3(28, 2, 48),
new Vector3(29, 2, 47),
new Vector3(29, 2, 48),
new Vector3(30, 2, 48),
new Vector3(31, 2, 48),
new Vector3(32, 2, 48),
new Vector3(26, 2, 43),
new Vector3(26, 2, 44),
new Vector3(26, 2, 45),
new Vector3(27, 2, 43),
new Vector3(27, 2, 44),
new Vector3(27, 2, 45),
new Vector3(28, 2, 43),
new Vector3(28, 2, 44),
new Vector3(28, 2, 45),
new Vector3(38, 2, 42),
new Vector3(38, 2, 43),
new Vector3(38, 2, 44),
new Vector3(39, 2, 42),
new Vector3(39, 2, 43),
new Vector3(39, 2, 44),
new Vector3(40, 2, 42),
new Vector3(40, 2, 43),
new Vector3(40, 2, 44),
new Vector3(37, 2, 47),
new Vector3(37, 2, 48),
new Vector3(38, 2, 47),
new Vector3(38, 2, 48),
new Vector3(39, 2, 47),
new Vector3(39, 2, 48),
new Vector3(26, 2, 43),
new Vector3(26, 2, 44),
new Vector3(26, 2, 45),
new Vector3(27, 2, 43),
new Vector3(27, 2, 44),
new Vector3(27, 2, 45),
new Vector3(28, 2, 43),
new Vector3(28, 2, 44),
new Vector3(28, 2, 45),
new Vector3(24, 1.5f, 44),
new Vector3(24, 1.5f, 45),
new Vector3(24, 1.5f, 46),
new Vector3(25, 1.5f, 44),
new Vector3(25, 1.5f, 45),
new Vector3(25, 1.5f, 46),
new Vector3(26, 1.5f, 44),
new Vector3(26, 1.5f, 45),
new Vector3(26, 1.5f, 46),
new Vector3(24, 1.5f, 43),
new Vector3(24, 1.5f, 44),
new Vector3(24, 1.5f, 45),
new Vector3(25, 1.5f, 43),
new Vector3(25, 1.5f, 44),
new Vector3(25, 1.5f, 45),
new Vector3(26, 1.5f, 43),
new Vector3(26, 1.5f, 44),
new Vector3(26, 1.5f, 45),
new Vector3(21, 1, 37),
new Vector3(21, 1, 38),
new Vector3(21, 1, 39),
new Vector3(21, 1, 40),
new Vector3(21, 1, 41),
new Vector3(22, 1, 37),
new Vector3(22, 1, 38),
new Vector3(22, 1, 39),
new Vector3(22, 1, 40),
new Vector3(22, 1, 41),
new Vector3(23, 1, 37),
new Vector3(23, 1, 38),
new Vector3(23, 1, 39),
new Vector3(23, 1, 40),
new Vector3(23, 1, 41),
new Vector3(24, 1, 37),
new Vector3(24, 1, 38),
new Vector3(24, 1, 39),
new Vector3(24, 1, 40),
new Vector3(24, 1, 41),
new Vector3(25, 1, 37),
new Vector3(25, 1, 38),
new Vector3(25, 1, 39),
new Vector3(25, 1, 40),
new Vector3(25, 1, 41),
new Vector3(20, 4, 43),
new Vector3(16, 3.5f, 42),
new Vector3(19, 3.5f, 39),
new Vector3(25, 3, 48),
new Vector3(25, 3, 38),
new Vector3(25, 3, 38),
new Vector3(28, 2.5f, 44),
new Vector3(17, 2.5f, 35),
new Vector3(12, 2.5f, 40),
new Vector3(28, 2.5f, 41),
new Vector3(20, 2, 32),
new Vector3(20, 2, 33),
new Vector3(20, 2, 34),
new Vector3(21, 2, 32),
new Vector3(21, 2, 33),
new Vector3(21, 2, 34),
new Vector3(22, 2, 32),
new Vector3(22, 2, 33),
new Vector3(22, 2, 34),
new Vector3(29, 2, 43),
new Vector3(29, 2, 44),
new Vector3(29, 2, 45),
new Vector3(30, 2, 43),
new Vector3(30, 2, 44),
new Vector3(30, 2, 45),
new Vector3(31, 2, 43),
new Vector3(31, 2, 44),
new Vector3(31, 2, 45),
new Vector3(21, 2, 32),
new Vector3(21, 2, 33),
new Vector3(21, 2, 34),
new Vector3(22, 2, 32),
new Vector3(22, 2, 33),
new Vector3(22, 2, 34),
new Vector3(23, 2, 32),
new Vector3(23, 2, 33),
new Vector3(23, 2, 34),
new Vector3(18, 2, 32),
new Vector3(18, 2, 33),
new Vector3(18, 2, 34),
new Vector3(19, 2, 32),
new Vector3(19, 2, 33),
new Vector3(19, 2, 34),
new Vector3(20, 2, 32),
new Vector3(20, 2, 33),
new Vector3(20, 2, 34),
new Vector3(7, 1.5f, 40),
new Vector3(7, 1.5f, 41),
new Vector3(7, 1.5f, 42),
new Vector3(8, 1.5f, 40),
new Vector3(8, 1.5f, 41),
new Vector3(8, 1.5f, 42),
new Vector3(9, 1.5f, 40),
new Vector3(9, 1.5f, 41),
new Vector3(9, 1.5f, 42),
new Vector3(8, 1.5f, 31),
new Vector3(8, 1.5f, 32),
new Vector3(8, 1.5f, 33),
new Vector3(9, 1.5f, 31),
new Vector3(9, 1.5f, 32),
new Vector3(9, 1.5f, 33),
new Vector3(10, 1.5f, 31),
new Vector3(10, 1.5f, 32),
new Vector3(10, 1.5f, 33),
new Vector3(31, 1.5f, 39),
new Vector3(31, 1.5f, 40),
new Vector3(31, 1.5f, 41),
new Vector3(32, 1.5f, 39),
new Vector3(32, 1.5f, 40),
new Vector3(32, 1.5f, 41),
new Vector3(33, 1.5f, 39),
new Vector3(33, 1.5f, 40),
new Vector3(33, 1.5f, 41),
new Vector3(15, 1, 27),
new Vector3(15, 1, 28),
new Vector3(15, 1, 29),
new Vector3(15, 1, 30),
new Vector3(15, 1, 31),
new Vector3(16, 1, 27),
new Vector3(16, 1, 28),
new Vector3(16, 1, 29),
new Vector3(16, 1, 30),
new Vector3(16, 1, 31),
new Vector3(17, 1, 27),
new Vector3(17, 1, 28),
new Vector3(17, 1, 29),
new Vector3(17, 1, 30),
new Vector3(17, 1, 31),
new Vector3(18, 1, 27),
new Vector3(18, 1, 28),
new Vector3(18, 1, 29),
new Vector3(18, 1, 30),
new Vector3(18, 1, 31),
new Vector3(19, 1, 27),
new Vector3(19, 1, 28),
new Vector3(19, 1, 29),
new Vector3(19, 1, 30),
new Vector3(19, 1, 31),
new Vector3(32, 1, 37),
new Vector3(32, 1, 38),
new Vector3(32, 1, 39),
new Vector3(32, 1, 40),
new Vector3(32, 1, 41),
new Vector3(33, 1, 37),
new Vector3(33, 1, 38),
new Vector3(33, 1, 39),
new Vector3(33, 1, 40),
new Vector3(33, 1, 41),
new Vector3(34, 1, 37),
new Vector3(34, 1, 38),
new Vector3(34, 1, 39),
new Vector3(34, 1, 40),
new Vector3(34, 1, 41),
new Vector3(35, 1, 37),
new Vector3(35, 1, 38),
new Vector3(35, 1, 39),
new Vector3(35, 1, 40),
new Vector3(35, 1, 41),
new Vector3(36, 1, 37),
new Vector3(36, 1, 38),
new Vector3(36, 1, 39),
new Vector3(36, 1, 40),
new Vector3(36, 1, 41),
new Vector3(31, 1, 28),
new Vector3(31, 1, 29),
new Vector3(31, 1, 30),
new Vector3(31, 1, 31),
new Vector3(31, 1, 32),
new Vector3(32, 1, 28),
new Vector3(32, 1, 29),
new Vector3(32, 1, 30),
new Vector3(32, 1, 31),
new Vector3(32, 1, 32),
new Vector3(33, 1, 28),
new Vector3(33, 1, 29),
new Vector3(33, 1, 30),
new Vector3(33, 1, 31),
new Vector3(33, 1, 32),
new Vector3(34, 1, 28),
new Vector3(34, 1, 29),
new Vector3(34, 1, 30),
new Vector3(34, 1, 31),
new Vector3(34, 1, 32),
new Vector3(35, 1, 28),
new Vector3(35, 1, 29),
new Vector3(35, 1, 30),
new Vector3(35, 1, 31),
new Vector3(35, 1, 32),
new Vector3(14, 1, 27),
new Vector3(14, 1, 28),
new Vector3(14, 1, 29),
new Vector3(14, 1, 30),
new Vector3(14, 1, 31),
new Vector3(15, 1, 27),
new Vector3(15, 1, 28),
new Vector3(15, 1, 29),
new Vector3(15, 1, 30),
new Vector3(15, 1, 31),
new Vector3(16, 1, 27),
new Vector3(16, 1, 28),
new Vector3(16, 1, 29),
new Vector3(16, 1, 30),
new Vector3(16, 1, 31),
new Vector3(17, 1, 27),
new Vector3(17, 1, 28),
new Vector3(17, 1, 29),
new Vector3(17, 1, 30),
new Vector3(17, 1, 31),
new Vector3(18, 1, 27),
new Vector3(18, 1, 28),
new Vector3(18, 1, 29),
new Vector3(18, 1, 30),
new Vector3(18, 1, 31),
new Vector3(39, 4, 14),
new Vector3(38, 3.5f, 10),
new Vector3(39, 3.5f, 18),
new Vector3(40, 3, 20),
new Vector3(40, 3, 8),
new Vector3(45, 3, 12),
new Vector3(38, 3, 20),
new Vector3(36, 2.5f, 22),
new Vector3(47, 2.5f, 16),
new Vector3(41, 2.5f, 22),
new Vector3(48, 2, 13),
new Vector3(48, 2, 14),
new Vector3(48, 2, 15),
new Vector3(26, 1.5f, 14),
new Vector3(26, 1.5f, 15),
new Vector3(26, 1.5f, 16),
new Vector3(27, 1.5f, 14),
new Vector3(27, 1.5f, 15),
new Vector3(27, 1.5f, 16),
new Vector3(28, 1.5f, 14),
new Vector3(28, 1.5f, 15),
new Vector3(28, 1.5f, 16),
new Vector3(26, 1.5f, 17),
new Vector3(26, 1.5f, 18),
new Vector3(26, 1.5f, 19),
new Vector3(27, 1.5f, 17),
new Vector3(27, 1.5f, 18),
new Vector3(27, 1.5f, 19),
new Vector3(28, 1.5f, 17),
new Vector3(28, 1.5f, 18),
new Vector3(28, 1.5f, 19),
new Vector3(33, 1.5f, 25),
new Vector3(33, 1.5f, 26),
new Vector3(33, 1.5f, 27),
new Vector3(34, 1.5f, 25),
new Vector3(34, 1.5f, 26),
new Vector3(34, 1.5f, 27),
new Vector3(35, 1.5f, 25),
new Vector3(35, 1.5f, 26),
new Vector3(35, 1.5f, 27),
new Vector3(26, 1.5f, 10),
new Vector3(26, 1.5f, 11),
new Vector3(26, 1.5f, 12),
new Vector3(27, 1.5f, 10),
new Vector3(27, 1.5f, 11),
new Vector3(27, 1.5f, 12),
new Vector3(28, 1.5f, 10),
new Vector3(28, 1.5f, 11),
new Vector3(28, 1.5f, 12),
new Vector3(24, 1, 2),
new Vector3(24, 1, 3),
new Vector3(25, 1, 2),
new Vector3(25, 1, 3),
new Vector3(26, 1, 2),
new Vector3(26, 1, 3),
new Vector3(27, 1, 2),
new Vector3(27, 1, 3),
new Vector3(28, 1, 2),
new Vector3(28, 1, 3),
new Vector3(14, 4, 12),
new Vector3(18, 3.5f, 11),
new Vector3(14, 3, 18),
new Vector3(9, 3, 17),
new Vector3(19, 3, 17),
new Vector3(6, 2.5f, 12),
new Vector3(22, 2.5f, 9),
new Vector3(9, 2, 21),
new Vector3(9, 2, 22),
new Vector3(9, 2, 23),
new Vector3(10, 2, 21),
new Vector3(10, 2, 22),
new Vector3(10, 2, 23),
new Vector3(11, 2, 21),
new Vector3(11, 2, 22),
new Vector3(11, 2, 23),
new Vector3(23, 2, 14),
new Vector3(23, 2, 15),
new Vector3(23, 2, 16),
new Vector3(24, 2, 14),
new Vector3(24, 2, 15),
new Vector3(24, 2, 16),
new Vector3(25, 2, 14),
new Vector3(25, 2, 15),
new Vector3(25, 2, 16),
new Vector3(3, 2, 9),
new Vector3(3, 2, 10),
new Vector3(3, 2, 11),
new Vector3(4, 2, 9),
new Vector3(4, 2, 10),
new Vector3(4, 2, 11),
new Vector3(5, 2, 9),
new Vector3(5, 2, 10),
new Vector3(5, 2, 11),
new Vector3(23, 2, 13),
new Vector3(23, 2, 14),
new Vector3(23, 2, 15),
new Vector3(24, 2, 13),
new Vector3(24, 2, 14),
new Vector3(24, 2, 15),
new Vector3(25, 2, 13),
new Vector3(25, 2, 14),
new Vector3(25, 2, 15),
new Vector3(4, 2, 20),
new Vector3(4, 2, 21),
new Vector3(4, 2, 22),
new Vector3(5, 2, 20),
new Vector3(5, 2, 21),
new Vector3(5, 2, 22),
new Vector3(6, 2, 20),
new Vector3(6, 2, 21),
new Vector3(6, 2, 22),
new Vector3(22, 2, 2),
new Vector3(22, 2, 3),
new Vector3(22, 2, 4),
new Vector3(23, 2, 2),
new Vector3(23, 2, 3),
new Vector3(23, 2, 4),
new Vector3(24, 2, 2),
new Vector3(24, 2, 3),
new Vector3(24, 2, 4),
new Vector3(25, 1.5f, 13),
new Vector3(25, 1.5f, 14),
new Vector3(25, 1.5f, 15),
new Vector3(26, 1.5f, 13),
new Vector3(26, 1.5f, 14),
new Vector3(26, 1.5f, 15),
new Vector3(27, 1.5f, 13),
new Vector3(27, 1.5f, 14),
new Vector3(27, 1.5f, 15),
new Vector3(24, 1.5f, 22),
new Vector3(24, 1.5f, 23),
new Vector3(24, 1.5f, 24),
new Vector3(25, 1.5f, 22),
new Vector3(25, 1.5f, 23),
new Vector3(25, 1.5f, 24),
new Vector3(26, 1.5f, 22),
new Vector3(26, 1.5f, 23),
new Vector3(26, 1.5f, 24),
new Vector3(25, 1.5f, 14),
new Vector3(25, 1.5f, 15),
new Vector3(25, 1.5f, 16),
new Vector3(26, 1.5f, 14),
new Vector3(26, 1.5f, 15),
new Vector3(26, 1.5f, 16),
new Vector3(27, 1.5f, 14),
new Vector3(27, 1.5f, 15),
new Vector3(27, 1.5f, 16),
new Vector3(2, 1.5f, 2),
new Vector3(3, 1.5f, 2),
new Vector3(4, 1.5f, 2),
new Vector3(13, 1.5f, 23),
new Vector3(13, 1.5f, 24),
new Vector3(13, 1.5f, 25),
new Vector3(14, 1.5f, 23),
new Vector3(14, 1.5f, 24),
new Vector3(14, 1.5f, 25),
new Vector3(15, 1.5f, 23),
new Vector3(15, 1.5f, 24),
new Vector3(15, 1.5f, 25),
new Vector3(2, 1.5f, 22),
new Vector3(2, 1.5f, 23),
new Vector3(2, 1.5f, 24),
new Vector3(3, 1.5f, 22),
new Vector3(3, 1.5f, 23),
new Vector3(3, 1.5f, 24),
new Vector3(4, 1.5f, 22),
new Vector3(4, 1.5f, 23),
new Vector3(4, 1.5f, 24),
new Vector3(9, 1.5f, 23),
new Vector3(9, 1.5f, 24),
new Vector3(9, 1.5f, 25),
new Vector3(10, 1.5f, 23),
new Vector3(10, 1.5f, 24),
new Vector3(10, 1.5f, 25),
new Vector3(11, 1.5f, 23),
new Vector3(11, 1.5f, 24),
new Vector3(11, 1.5f, 25),
new Vector3(25, 1, 23),
new Vector3(25, 1, 24),
new Vector3(25, 1, 25),
new Vector3(25, 1, 26),
new Vector3(25, 1, 27),
new Vector3(26, 1, 23),
new Vector3(26, 1, 24),
new Vector3(26, 1, 25),
new Vector3(26, 1, 26),
new Vector3(26, 1, 27),
new Vector3(27, 1, 23),
new Vector3(27, 1, 24),
new Vector3(27, 1, 25),
new Vector3(27, 1, 26),
new Vector3(27, 1, 27),
new Vector3(28, 1, 23),
new Vector3(28, 1, 24),
new Vector3(28, 1, 25),
new Vector3(28, 1, 26),
new Vector3(28, 1, 27),
new Vector3(29, 1, 23),
new Vector3(29, 1, 24),
new Vector3(29, 1, 25),
new Vector3(29, 1, 26),
new Vector3(29, 1, 27),
new Vector3(26, 1, 4),
new Vector3(26, 1, 5),
new Vector3(26, 1, 6),
new Vector3(26, 1, 7),
new Vector3(26, 1, 8),
new Vector3(27, 1, 4),
new Vector3(27, 1, 5),
new Vector3(27, 1, 6),
new Vector3(27, 1, 7),
new Vector3(27, 1, 8),
new Vector3(28, 1, 4),
new Vector3(28, 1, 5),
new Vector3(28, 1, 6),
new Vector3(28, 1, 7),
new Vector3(28, 1, 8),
new Vector3(29, 1, 4),
new Vector3(29, 1, 5),
new Vector3(29, 1, 6),
new Vector3(29, 1, 7),
new Vector3(29, 1, 8),
new Vector3(30, 1, 4),
new Vector3(30, 1, 5),
new Vector3(30, 1, 6),
new Vector3(30, 1, 7),
new Vector3(30, 1, 8),
new Vector3(2, 1, 23),
new Vector3(2, 1, 24),
new Vector3(2, 1, 25),
new Vector3(2, 1, 26),
new Vector3(2, 1, 27),
new Vector3(3, 1, 23),
new Vector3(3, 1, 24),
new Vector3(3, 1, 25),
new Vector3(3, 1, 26),
new Vector3(3, 1, 27),
new Vector3(26, 1, 10),
new Vector3(26, 1, 11),
new Vector3(26, 1, 12),
new Vector3(26, 1, 13),
new Vector3(26, 1, 14),
new Vector3(27, 1, 10),
new Vector3(27, 1, 11),
new Vector3(27, 1, 12),
new Vector3(27, 1, 13),
new Vector3(27, 1, 14),
new Vector3(28, 1, 10),
new Vector3(28, 1, 11),
new Vector3(28, 1, 12),
new Vector3(28, 1, 13),
new Vector3(28, 1, 14),
new Vector3(29, 1, 10),
new Vector3(29, 1, 11),
new Vector3(29, 1, 12),
new Vector3(29, 1, 13),
new Vector3(29, 1, 14),
new Vector3(30, 1, 10),
new Vector3(30, 1, 11),
new Vector3(30, 1, 12),
new Vector3(30, 1, 13),
new Vector3(30, 1, 14),
new Vector3(2, 1, 15),
new Vector3(2, 1, 16),
new Vector3(2, 1, 17),
new Vector3(2, 1, 18),
new Vector3(2, 1, 19),
new Vector3(26, 1, 6),
new Vector3(26, 1, 7),
new Vector3(26, 1, 8),
new Vector3(26, 1, 9),
new Vector3(26, 1, 10),
new Vector3(27, 1, 6),
new Vector3(27, 1, 7),
new Vector3(27, 1, 8),
new Vector3(27, 1, 9),
new Vector3(27, 1, 10),
new Vector3(28, 1, 6),
new Vector3(28, 1, 7),
new Vector3(28, 1, 8),
new Vector3(28, 1, 9),
new Vector3(28, 1, 10),
new Vector3(29, 1, 6),
new Vector3(29, 1, 7),
new Vector3(29, 1, 8),
new Vector3(29, 1, 9),
new Vector3(29, 1, 10),
new Vector3(30, 1, 6),
new Vector3(30, 1, 7),
new Vector3(30, 1, 8),
new Vector3(30, 1, 9),
new Vector3(30, 1, 10),
new Vector3(45, 3, 34),
new Vector3(41, 2.5f, 34),
new Vector3(44, 2.5f, 30),
new Vector3(42, 2.5f, 37),
new Vector3(42, 2.5f, 31),
new Vector3(39, 2, 38),
new Vector3(39, 2, 39),
new Vector3(39, 2, 40),
new Vector3(40, 2, 38),
new Vector3(40, 2, 39),
new Vector3(40, 2, 40),
new Vector3(41, 2, 38),
new Vector3(41, 2, 39),
new Vector3(41, 2, 40),
new Vector3(44, 2, 39),
new Vector3(44, 2, 40),
new Vector3(44, 2, 41),
new Vector3(45, 2, 39),
new Vector3(45, 2, 40),
new Vector3(45, 2, 41),
new Vector3(46, 2, 39),
new Vector3(46, 2, 40),
new Vector3(46, 2, 41),
new Vector3(44, 2, 39),
new Vector3(44, 2, 40),
new Vector3(44, 2, 41),
new Vector3(45, 2, 39),
new Vector3(45, 2, 40),
new Vector3(45, 2, 41),
new Vector3(46, 2, 39),
new Vector3(46, 2, 40),
new Vector3(46, 2, 41),
new Vector3(44, 1.5f, 25),
new Vector3(44, 1.5f, 26),
new Vector3(44, 1.5f, 27),
new Vector3(45, 1.5f, 25),
new Vector3(45, 1.5f, 26),
new Vector3(45, 1.5f, 27),
new Vector3(46, 1.5f, 25),
new Vector3(46, 1.5f, 26),
new Vector3(46, 1.5f, 27),
new Vector3(34, 1, 23),
new Vector3(34, 1, 24),
new Vector3(34, 1, 25),
new Vector3(34, 1, 26),
new Vector3(34, 1, 27),
new Vector3(35, 1, 23),
new Vector3(35, 1, 24),
new Vector3(35, 1, 25),
new Vector3(35, 1, 26),
new Vector3(35, 1, 27),
new Vector3(36, 1, 23),
new Vector3(36, 1, 24),
new Vector3(36, 1, 25),
new Vector3(36, 1, 26),
new Vector3(36, 1, 27),
new Vector3(37, 1, 23),
new Vector3(37, 1, 24),
new Vector3(37, 1, 25),
new Vector3(37, 1, 26),
new Vector3(37, 1, 27),
new Vector3(38, 1, 23),
new Vector3(38, 1, 24),
new Vector3(38, 1, 25),
new Vector3(38, 1, 26),
new Vector3(38, 1, 27),
new Vector3(33, 1, 33),
new Vector3(33, 1, 34),
new Vector3(33, 1, 35),
new Vector3(33, 1, 36),
new Vector3(33, 1, 37),
new Vector3(34, 1, 33),
new Vector3(34, 1, 34),
new Vector3(34, 1, 35),
new Vector3(34, 1, 36),
new Vector3(34, 1, 37),
new Vector3(35, 1, 33),
new Vector3(35, 1, 34),
new Vector3(35, 1, 35),
new Vector3(35, 1, 36),
new Vector3(35, 1, 37),
new Vector3(36, 1, 33),
new Vector3(36, 1, 34),
new Vector3(36, 1, 35),
new Vector3(36, 1, 36),
new Vector3(36, 1, 37),
new Vector3(37, 1, 33),
new Vector3(37, 1, 34),
new Vector3(37, 1, 35),
new Vector3(37, 1, 36),
new Vector3(37, 1, 37),
new Vector3(33, 1, 32),
new Vector3(33, 1, 33),
new Vector3(33, 1, 34),
new Vector3(33, 1, 35),
new Vector3(33, 1, 36),
new Vector3(34, 1, 32),
new Vector3(34, 1, 33),
new Vector3(34, 1, 34),
new Vector3(34, 1, 35),
new Vector3(34, 1, 36),
new Vector3(35, 1, 32),
new Vector3(35, 1, 33),
new Vector3(35, 1, 34),
new Vector3(35, 1, 35),
new Vector3(35, 1, 36),
new Vector3(36, 1, 32),
new Vector3(36, 1, 33),
new Vector3(36, 1, 34),
new Vector3(36, 1, 35),
new Vector3(36, 1, 36),
new Vector3(37, 1, 32),
new Vector3(37, 1, 33),
new Vector3(37, 1, 34),
new Vector3(37, 1, 35),
new Vector3(37, 1, 36),
new Vector3(46, 3, 6),
new Vector3(45, 2.5f, 10),
new Vector3(39, 2, 6),
new Vector3(39, 2, 7),
new Vector3(39, 2, 8),
new Vector3(40, 2, 6),
new Vector3(40, 2, 7),
new Vector3(40, 2, 8),
new Vector3(41, 2, 6),
new Vector3(41, 2, 7),
new Vector3(41, 2, 8),
new Vector3(39, 2, 4),
new Vector3(39, 2, 5),
new Vector3(39, 2, 6),
new Vector3(40, 2, 4),
new Vector3(40, 2, 5),
new Vector3(40, 2, 6),
new Vector3(41, 2, 4),
new Vector3(41, 2, 5),
new Vector3(41, 2, 6),
new Vector3(39, 2, 6),
new Vector3(39, 2, 7),
new Vector3(39, 2, 8),
new Vector3(40, 2, 6),
new Vector3(40, 2, 7),
new Vector3(40, 2, 8),
new Vector3(41, 2, 6),
new Vector3(41, 2, 7),
new Vector3(41, 2, 8),
new Vector3(37, 1.5f, 2),
new Vector3(37, 1.5f, 3),
new Vector3(37, 1.5f, 4),
new Vector3(38, 1.5f, 2),
new Vector3(38, 1.5f, 3),
new Vector3(38, 1.5f, 4),
new Vector3(39, 1.5f, 2),
new Vector3(39, 1.5f, 3),
new Vector3(39, 1.5f, 4),
new Vector3(5, 4, 19),
new Vector3(2, 3.5f, 22),
new Vector3(3, 3, 25),
new Vector3(5, 2.5f, 11),
new Vector3(13, 2.5f, 21),
new Vector3(7, 2.5f, 27),
new Vector3(12, 2.5f, 26),
new Vector3(6, 2, 28),
new Vector3(6, 2, 29),
new Vector3(6, 2, 30),
new Vector3(7, 2, 28),
new Vector3(7, 2, 29),
new Vector3(7, 2, 30),
new Vector3(8, 2, 28),
new Vector3(8, 2, 29),
new Vector3(8, 2, 30),
new Vector3(14, 2, 19),
new Vector3(14, 2, 20),
new Vector3(14, 2, 21),
new Vector3(15, 2, 19),
new Vector3(15, 2, 20),
new Vector3(15, 2, 21),
new Vector3(16, 2, 19),
new Vector3(16, 2, 20),
new Vector3(16, 2, 21),
new Vector3(2, 2, 28),
new Vector3(2, 2, 29),
new Vector3(2, 2, 30),
new Vector3(6, 2, 8),
new Vector3(6, 2, 9),
new Vector3(6, 2, 10),
new Vector3(7, 2, 8),
new Vector3(7, 2, 9),
new Vector3(7, 2, 10),
new Vector3(8, 2, 8),
new Vector3(8, 2, 9),
new Vector3(8, 2, 10),
new Vector3(7, 2, 8),
new Vector3(7, 2, 9),
new Vector3(7, 2, 10),
new Vector3(8, 2, 8),
new Vector3(8, 2, 9),
new Vector3(8, 2, 10),
new Vector3(9, 2, 8),
new Vector3(9, 2, 9),
new Vector3(9, 2, 10),
new Vector3(16, 1.5f, 16),
new Vector3(16, 1.5f, 17),
new Vector3(16, 1.5f, 18),
new Vector3(17, 1.5f, 16),
new Vector3(17, 1.5f, 17),
new Vector3(17, 1.5f, 18),
new Vector3(18, 1.5f, 16),
new Vector3(18, 1.5f, 17),
new Vector3(18, 1.5f, 18),
new Vector3(16, 1.5f, 16),
new Vector3(16, 1.5f, 17),
new Vector3(16, 1.5f, 18),
new Vector3(17, 1.5f, 16),
new Vector3(17, 1.5f, 17),
new Vector3(17, 1.5f, 18),
new Vector3(18, 1.5f, 16),
new Vector3(18, 1.5f, 17),
new Vector3(18, 1.5f, 18),
new Vector3(2, 1.5f, 6),
new Vector3(2, 1.5f, 7),
new Vector3(2, 1.5f, 8),
new Vector3(3, 1.5f, 6),
new Vector3(3, 1.5f, 7),
new Vector3(3, 1.5f, 8),
new Vector3(4, 1.5f, 6),
new Vector3(4, 1.5f, 7),
new Vector3(4, 1.5f, 8),
new Vector3(15, 1.5f, 29),
new Vector3(15, 1.5f, 30),
new Vector3(15, 1.5f, 31),
new Vector3(16, 1.5f, 29),
new Vector3(16, 1.5f, 30),
new Vector3(16, 1.5f, 31),
new Vector3(17, 1.5f, 29),
new Vector3(17, 1.5f, 30),
new Vector3(17, 1.5f, 31),
new Vector3(17, 1, 18),
new Vector3(17, 1, 19),
new Vector3(17, 1, 20),
new Vector3(17, 1, 21),
new Vector3(17, 1, 22),
new Vector3(18, 1, 18),
new Vector3(18, 1, 19),
new Vector3(18, 1, 20),
new Vector3(18, 1, 21),
new Vector3(18, 1, 22),
new Vector3(19, 1, 18),
new Vector3(19, 1, 19),
new Vector3(19, 1, 20),
new Vector3(19, 1, 21),
new Vector3(19, 1, 22),
new Vector3(20, 1, 18),
new Vector3(20, 1, 19),
new Vector3(20, 1, 20),
new Vector3(20, 1, 21),
new Vector3(20, 1, 22),
new Vector3(21, 1, 18),
new Vector3(21, 1, 19),
new Vector3(21, 1, 20),
new Vector3(21, 1, 21),
new Vector3(21, 1, 22),
new Vector3(7, 4, 25),
new Vector3(4, 3.5f, 22),
new Vector3(10, 3.5f, 28),
new Vector3(13, 3, 24),
new Vector3(5, 3, 31),
new Vector3(6, 3, 31),
new Vector3(2, 3, 20),
new Vector3(12, 3, 20),
new Vector3(18, 1.5f, 22),
new Vector3(18, 1.5f, 23),
new Vector3(18, 1.5f, 24),
new Vector3(19, 1.5f, 22),
new Vector3(19, 1.5f, 23),
new Vector3(19, 1.5f, 24),
new Vector3(20, 1.5f, 22),
new Vector3(20, 1.5f, 23),
new Vector3(20, 1.5f, 24),
new Vector3(17, 1.5f, 35),
new Vector3(17, 1.5f, 36),
new Vector3(17, 1.5f, 37),
new Vector3(18, 1.5f, 35),
new Vector3(18, 1.5f, 36),
new Vector3(18, 1.5f, 37),
new Vector3(19, 1.5f, 35),
new Vector3(19, 1.5f, 36),
new Vector3(19, 1.5f, 37),
new Vector3(18, 1, 36),
new Vector3(18, 1, 37),
new Vector3(18, 1, 38),
new Vector3(18, 1, 39),
new Vector3(18, 1, 40),
new Vector3(19, 1, 36),
new Vector3(19, 1, 37),
new Vector3(19, 1, 38),
new Vector3(19, 1, 39),
new Vector3(19, 1, 40),
new Vector3(20, 1, 36),
new Vector3(20, 1, 37),
new Vector3(20, 1, 38),
new Vector3(20, 1, 39),
new Vector3(20, 1, 40),
new Vector3(21, 1, 36),
new Vector3(21, 1, 37),
new Vector3(21, 1, 38),
new Vector3(21, 1, 39),
new Vector3(21, 1, 40),
new Vector3(22, 1, 36),
new Vector3(22, 1, 37),
new Vector3(22, 1, 38),
new Vector3(22, 1, 39),
new Vector3(22, 1, 40),
new Vector3(18, 1, 36),
new Vector3(18, 1, 37),
new Vector3(18, 1, 38),
new Vector3(18, 1, 39),
new Vector3(18, 1, 40),
new Vector3(19, 1, 36),
new Vector3(19, 1, 37),
new Vector3(19, 1, 38),
new Vector3(19, 1, 39),
new Vector3(19, 1, 40),
new Vector3(20, 1, 36),
new Vector3(20, 1, 37),
new Vector3(20, 1, 38),
new Vector3(20, 1, 39),
new Vector3(20, 1, 40),
new Vector3(21, 1, 36),
new Vector3(21, 1, 37),
new Vector3(21, 1, 38),
new Vector3(21, 1, 39),
new Vector3(21, 1, 40),
new Vector3(22, 1, 36),
new Vector3(22, 1, 37),
new Vector3(22, 1, 38),
new Vector3(22, 1, 39),
new Vector3(22, 1, 40),
new Vector3(18, 1, 10),
new Vector3(18, 1, 11),
new Vector3(18, 1, 12),
new Vector3(18, 1, 13),
new Vector3(18, 1, 14),
new Vector3(19, 1, 10),
new Vector3(19, 1, 11),
new Vector3(19, 1, 12),
new Vector3(19, 1, 13),
new Vector3(19, 1, 14),
new Vector3(20, 1, 10),
new Vector3(20, 1, 11),
new Vector3(20, 1, 12),
new Vector3(20, 1, 13),
new Vector3(20, 1, 14),
new Vector3(21, 1, 10),
new Vector3(21, 1, 11),
new Vector3(21, 1, 12),
new Vector3(21, 1, 13),
new Vector3(21, 1, 14),
new Vector3(22, 1, 10),
new Vector3(22, 1, 11),
new Vector3(22, 1, 12),
new Vector3(22, 1, 13),
new Vector3(22, 1, 14),
new Vector3(6, 1, 37),
new Vector3(6, 1, 38),
new Vector3(6, 1, 39),
new Vector3(6, 1, 40),
new Vector3(6, 1, 41),
new Vector3(7, 1, 37),
new Vector3(7, 1, 38),
new Vector3(7, 1, 39),
new Vector3(7, 1, 40),
new Vector3(7, 1, 41),
new Vector3(8, 1, 37),
new Vector3(8, 1, 38),
new Vector3(8, 1, 39),
new Vector3(8, 1, 40),
new Vector3(8, 1, 41),
new Vector3(9, 1, 37),
new Vector3(9, 1, 38),
new Vector3(9, 1, 39),
new Vector3(9, 1, 40),
new Vector3(9, 1, 41),
new Vector3(10, 1, 37),
new Vector3(10, 1, 38),
new Vector3(10, 1, 39),
new Vector3(10, 1, 40),
new Vector3(10, 1, 41),
new Vector3(2, 1, 9),
new Vector3(2, 1, 10),
new Vector3(2, 1, 11),
new Vector3(2, 1, 12),
new Vector3(2, 1, 13),
new Vector3(3, 1, 9),
new Vector3(3, 1, 10),
new Vector3(3, 1, 11),
new Vector3(3, 1, 12),
new Vector3(3, 1, 13),
new Vector3(8, 3, 11),
new Vector3(8, 2.5f, 15),
new Vector3(8, 2, 4),
new Vector3(8, 2, 5),
new Vector3(8, 2, 6),
new Vector3(9, 2, 4),
new Vector3(9, 2, 5),
new Vector3(9, 2, 6),
new Vector3(10, 2, 4),
new Vector3(10, 2, 5),
new Vector3(10, 2, 6),
new Vector3(5, 2, 16),
new Vector3(5, 2, 17),
new Vector3(5, 2, 18),
new Vector3(6, 2, 16),
new Vector3(6, 2, 17),
new Vector3(6, 2, 18),
new Vector3(7, 2, 16),
new Vector3(7, 2, 17),
new Vector3(7, 2, 18),
new Vector3(13, 2, 8),
new Vector3(13, 2, 9),
new Vector3(13, 2, 10),
new Vector3(14, 2, 8),
new Vector3(14, 2, 9),
new Vector3(14, 2, 10),
new Vector3(15, 2, 8),
new Vector3(15, 2, 9),
new Vector3(15, 2, 10),
new Vector3(5, 1.5f, 18),
new Vector3(5, 1.5f, 19),
new Vector3(5, 1.5f, 20),
new Vector3(6, 1.5f, 18),
new Vector3(6, 1.5f, 19),
new Vector3(6, 1.5f, 20),
new Vector3(7, 1.5f, 18),
new Vector3(7, 1.5f, 19),
new Vector3(7, 1.5f, 20),
new Vector3(15, 1.5f, 8),
new Vector3(15, 1.5f, 9),
new Vector3(15, 1.5f, 10),
new Vector3(16, 1.5f, 8),
new Vector3(16, 1.5f, 9),
new Vector3(16, 1.5f, 10),
new Vector3(17, 1.5f, 8),
new Vector3(17, 1.5f, 9),
new Vector3(17, 1.5f, 10),
new Vector3(2, 1.5f, 3),
new Vector3(2, 1.5f, 4),
new Vector3(2, 1.5f, 5),
new Vector3(2, 1.5f, 17),
new Vector3(2, 1.5f, 18),
new Vector3(2, 1.5f, 19),
new Vector3(15, 1, 18),
new Vector3(15, 1, 19),
new Vector3(15, 1, 20),
new Vector3(15, 1, 21),
new Vector3(15, 1, 22),
new Vector3(16, 1, 18),
new Vector3(16, 1, 19),
new Vector3(16, 1, 20),
new Vector3(16, 1, 21),
new Vector3(16, 1, 22),
new Vector3(17, 1, 18),
new Vector3(17, 1, 19),
new Vector3(17, 1, 20),
new Vector3(17, 1, 21),
new Vector3(17, 1, 22),
new Vector3(18, 1, 18),
new Vector3(18, 1, 19),
new Vector3(18, 1, 20),
new Vector3(18, 1, 21),
new Vector3(18, 1, 22),
new Vector3(19, 1, 18),
new Vector3(19, 1, 19),
new Vector3(19, 1, 20),
new Vector3(19, 1, 21),
new Vector3(19, 1, 22),
new Vector3(15, 1, 2),
new Vector3(15, 1, 3),
new Vector3(15, 1, 4),
new Vector3(16, 1, 2),
new Vector3(16, 1, 3),
new Vector3(16, 1, 4),
new Vector3(17, 1, 2),
new Vector3(17, 1, 3),
new Vector3(17, 1, 4),
new Vector3(18, 1, 2),
new Vector3(18, 1, 3),
new Vector3(18, 1, 4),
new Vector3(19, 1, 2),
new Vector3(19, 1, 3),
new Vector3(19, 1, 4),
new Vector3(15, 1, 2),
new Vector3(15, 1, 3),
new Vector3(15, 1, 4),
new Vector3(16, 1, 2),
new Vector3(16, 1, 3),
new Vector3(16, 1, 4),
new Vector3(17, 1, 2),
new Vector3(17, 1, 3),
new Vector3(17, 1, 4),
new Vector3(18, 1, 2),
new Vector3(18, 1, 3),
new Vector3(18, 1, 4),
new Vector3(19, 1, 2),
new Vector3(19, 1, 3),
new Vector3(19, 1, 4),
new Vector3(15, 1, 18),
new Vector3(15, 1, 19),
new Vector3(15, 1, 20),
new Vector3(15, 1, 21),
new Vector3(15, 1, 22),
new Vector3(16, 1, 18),
new Vector3(16, 1, 19),
new Vector3(16, 1, 20),
new Vector3(16, 1, 21),
new Vector3(16, 1, 22),
new Vector3(17, 1, 18),
new Vector3(17, 1, 19),
new Vector3(17, 1, 20),
new Vector3(17, 1, 21),
new Vector3(17, 1, 22),
new Vector3(18, 1, 18),
new Vector3(18, 1, 19),
new Vector3(18, 1, 20),
new Vector3(18, 1, 21),
new Vector3(18, 1, 22),
new Vector3(19, 1, 18),
new Vector3(19, 1, 19),
new Vector3(19, 1, 20),
new Vector3(19, 1, 21),
new Vector3(19, 1, 22),
new Vector3(9, 1, 19),
new Vector3(9, 1, 20),
new Vector3(9, 1, 21),
new Vector3(9, 1, 22),
new Vector3(9, 1, 23),
new Vector3(10, 1, 19),
new Vector3(10, 1, 20),
new Vector3(10, 1, 21),
new Vector3(10, 1, 22),
new Vector3(10, 1, 23),
new Vector3(11, 1, 19),
new Vector3(11, 1, 20),
new Vector3(11, 1, 21),
new Vector3(11, 1, 22),
new Vector3(11, 1, 23),
new Vector3(12, 1, 19),
new Vector3(12, 1, 20),
new Vector3(12, 1, 21),
new Vector3(12, 1, 22),
new Vector3(12, 1, 23),
new Vector3(13, 1, 19),
new Vector3(13, 1, 20),
new Vector3(13, 1, 21),
new Vector3(13, 1, 22),
new Vector3(13, 1, 23),
new Vector3(15, 1, 18),
new Vector3(15, 1, 19),
new Vector3(15, 1, 20),
new Vector3(15, 1, 21),
new Vector3(15, 1, 22),
new Vector3(16, 1, 18),
new Vector3(16, 1, 19),
new Vector3(16, 1, 20),
new Vector3(16, 1, 21),
new Vector3(16, 1, 22),
new Vector3(17, 1, 18),
new Vector3(17, 1, 19),
new Vector3(17, 1, 20),
new Vector3(17, 1, 21),
new Vector3(17, 1, 22),
new Vector3(18, 1, 18),
new Vector3(18, 1, 19),
new Vector3(18, 1, 20),
new Vector3(18, 1, 21),
new Vector3(18, 1, 22),
new Vector3(19, 1, 18),
new Vector3(19, 1, 19),
new Vector3(19, 1, 20),
new Vector3(19, 1, 21),
new Vector3(19, 1, 22),
new Vector3(41, 3, 38),
new Vector3(41, 2.5f, 42),
new Vector3(45, 2.5f, 38),
new Vector3(40, 2, 43),
new Vector3(40, 2, 44),
new Vector3(40, 2, 45),
new Vector3(41, 2, 43),
new Vector3(41, 2, 44),
new Vector3(41, 2, 45),
new Vector3(42, 2, 43),
new Vector3(42, 2, 44),
new Vector3(42, 2, 45),
new Vector3(46, 2, 37),
new Vector3(46, 2, 38),
new Vector3(46, 2, 39),
new Vector3(47, 2, 37),
new Vector3(47, 2, 38),
new Vector3(47, 2, 39),
new Vector3(48, 2, 37),
new Vector3(48, 2, 38),
new Vector3(48, 2, 39),
new Vector3(41, 2, 31),
new Vector3(41, 2, 32),
new Vector3(41, 2, 33),
new Vector3(42, 2, 31),
new Vector3(42, 2, 32),
new Vector3(42, 2, 33),
new Vector3(43, 2, 31),
new Vector3(43, 2, 32),
new Vector3(43, 2, 33),
new Vector3(35, 2, 32),
new Vector3(35, 2, 33),
new Vector3(35, 2, 34),
new Vector3(36, 2, 32),
new Vector3(36, 2, 33),
new Vector3(36, 2, 34),
new Vector3(37, 2, 32),
new Vector3(37, 2, 33),
new Vector3(37, 2, 34),
new Vector3(35, 2, 32),
new Vector3(35, 2, 33),
new Vector3(35, 2, 34),
new Vector3(36, 2, 32),
new Vector3(36, 2, 33),
new Vector3(36, 2, 34),
new Vector3(37, 2, 32),
new Vector3(37, 2, 33),
new Vector3(37, 2, 34),
new Vector3(46, 2, 37),
new Vector3(46, 2, 38),
new Vector3(46, 2, 39),
new Vector3(47, 2, 37),
new Vector3(47, 2, 38),
new Vector3(47, 2, 39),
new Vector3(48, 2, 37),
new Vector3(48, 2, 38),
new Vector3(48, 2, 39),
new Vector3(41, 1.5f, 45),
new Vector3(41, 1.5f, 46),
new Vector3(41, 1.5f, 47),
new Vector3(42, 1.5f, 45),
new Vector3(42, 1.5f, 46),
new Vector3(42, 1.5f, 47),
new Vector3(43, 1.5f, 45),
new Vector3(43, 1.5f, 46),
new Vector3(43, 1.5f, 47),
new Vector3(37, 1.5f, 29),
new Vector3(37, 1.5f, 30),
new Vector3(37, 1.5f, 31),
new Vector3(38, 1.5f, 29),
new Vector3(38, 1.5f, 30),
new Vector3(38, 1.5f, 31),
new Vector3(39, 1.5f, 29),
new Vector3(39, 1.5f, 30),
new Vector3(39, 1.5f, 31),
new Vector3(42, 1.5f, 29),
new Vector3(42, 1.5f, 30),
new Vector3(42, 1.5f, 31),
new Vector3(43, 1.5f, 29),
new Vector3(43, 1.5f, 30),
new Vector3(43, 1.5f, 31),
new Vector3(44, 1.5f, 29),
new Vector3(44, 1.5f, 30),
new Vector3(44, 1.5f, 31),
new Vector3(39, 1.5f, 45),
new Vector3(39, 1.5f, 46),
new Vector3(39, 1.5f, 47),
new Vector3(40, 1.5f, 45),
new Vector3(40, 1.5f, 46),
new Vector3(40, 1.5f, 47),
new Vector3(41, 1.5f, 45),
new Vector3(41, 1.5f, 46),
new Vector3(41, 1.5f, 47),
new Vector3(33, 1.5f, 30),
new Vector3(33, 1.5f, 31),
new Vector3(33, 1.5f, 32),
new Vector3(34, 1.5f, 30),
new Vector3(34, 1.5f, 31),
new Vector3(34, 1.5f, 32),
new Vector3(35, 1.5f, 30),
new Vector3(35, 1.5f, 31),
new Vector3(35, 1.5f, 32),
new Vector3(39, 1.5f, 45),
new Vector3(39, 1.5f, 46),
new Vector3(39, 1.5f, 47),
new Vector3(40, 1.5f, 45),
new Vector3(40, 1.5f, 46),
new Vector3(40, 1.5f, 47),
new Vector3(41, 1.5f, 45),
new Vector3(41, 1.5f, 46),
new Vector3(41, 1.5f, 47),
new Vector3(40, 1, 46),
new Vector3(40, 1, 47),
new Vector3(40, 1, 48),
new Vector3(41, 1, 46),
new Vector3(41, 1, 47),
new Vector3(41, 1, 48),
new Vector3(42, 1, 46),
new Vector3(42, 1, 47),
new Vector3(42, 1, 48),
new Vector3(43, 1, 46),
new Vector3(43, 1, 47),
new Vector3(43, 1, 48),
new Vector3(44, 1, 46),
new Vector3(44, 1, 47),
new Vector3(44, 1, 48),
new Vector3(39, 1, 26),
new Vector3(39, 1, 27),
new Vector3(39, 1, 28),
new Vector3(39, 1, 29),
new Vector3(39, 1, 30),
new Vector3(40, 1, 26),
new Vector3(40, 1, 27),
new Vector3(40, 1, 28),
new Vector3(40, 1, 29),
new Vector3(40, 1, 30),
new Vector3(41, 1, 26),
new Vector3(41, 1, 27),
new Vector3(41, 1, 28),
new Vector3(41, 1, 29),
new Vector3(41, 1, 30),
new Vector3(42, 1, 26),
new Vector3(42, 1, 27),
new Vector3(42, 1, 28),
new Vector3(42, 1, 29),
new Vector3(42, 1, 30),
new Vector3(43, 1, 26),
new Vector3(43, 1, 27),
new Vector3(43, 1, 28),
new Vector3(43, 1, 29),
new Vector3(43, 1, 30),
new Vector3(48, 1, 27),
new Vector3(48, 1, 28),
new Vector3(48, 1, 29),
new Vector3(48, 1, 30),
new Vector3(48, 1, 31),
new Vector3(29, 1, 36),
new Vector3(29, 1, 37),
new Vector3(29, 1, 38),
new Vector3(29, 1, 39),
new Vector3(29, 1, 40),
new Vector3(30, 1, 36),
new Vector3(30, 1, 37),
new Vector3(30, 1, 38),
new Vector3(30, 1, 39),
new Vector3(30, 1, 40),
new Vector3(31, 1, 36),
new Vector3(31, 1, 37),
new Vector3(31, 1, 38),
new Vector3(31, 1, 39),
new Vector3(31, 1, 40),
new Vector3(32, 1, 36),
new Vector3(32, 1, 37),
new Vector3(32, 1, 38),
new Vector3(32, 1, 39),
new Vector3(32, 1, 40),
new Vector3(33, 1, 36),
new Vector3(33, 1, 37),
new Vector3(33, 1, 38),
new Vector3(33, 1, 39),
new Vector3(33, 1, 40),
new Vector3(44, 4, 45),
new Vector3(43, 3.5f, 41),
new Vector3(48, 3.5f, 44),
new Vector3(40, 3.5f, 44),
new Vector3(36, 2.5f, 46),
new Vector3(43, 2.5f, 37),
new Vector3(36, 2.5f, 47),
new Vector3(33, 2, 40),
new Vector3(33, 2, 41),
new Vector3(33, 2, 42),
new Vector3(34, 2, 40),
new Vector3(34, 2, 41),
new Vector3(34, 2, 42),
new Vector3(35, 2, 40),
new Vector3(35, 2, 41),
new Vector3(35, 2, 42),
new Vector3(32, 1.5f, 33),
new Vector3(32, 1.5f, 34),
new Vector3(32, 1.5f, 35),
new Vector3(33, 1.5f, 33),
new Vector3(33, 1.5f, 34),
new Vector3(33, 1.5f, 35),
new Vector3(34, 1.5f, 33),
new Vector3(34, 1.5f, 34),
new Vector3(34, 1.5f, 35),
new Vector3(32, 1.5f, 33),
new Vector3(32, 1.5f, 34),
new Vector3(32, 1.5f, 35),
new Vector3(33, 1.5f, 33),
new Vector3(33, 1.5f, 34),
new Vector3(33, 1.5f, 35),
new Vector3(34, 1.5f, 33),
new Vector3(34, 1.5f, 34),
new Vector3(34, 1.5f, 35),
new Vector3(46, 1.5f, 32),
new Vector3(46, 1.5f, 33),
new Vector3(46, 1.5f, 34),
new Vector3(47, 1.5f, 32),
new Vector3(47, 1.5f, 33),
new Vector3(47, 1.5f, 34),
new Vector3(48, 1.5f, 32),
new Vector3(48, 1.5f, 33),
new Vector3(48, 1.5f, 34),
new Vector3(32, 1.5f, 33),
new Vector3(32, 1.5f, 34),
new Vector3(32, 1.5f, 35),
new Vector3(33, 1.5f, 33),
new Vector3(33, 1.5f, 34),
new Vector3(33, 1.5f, 35),
new Vector3(34, 1.5f, 33),
new Vector3(34, 1.5f, 34),
new Vector3(34, 1.5f, 35),
new Vector3(19, 4, 16),
new Vector3(18, 3.5f, 12),
new Vector3(23, 3.5f, 15),
new Vector3(25, 3, 15),
new Vector3(24, 3, 11),
new Vector3(24, 3, 11),
new Vector3(17, 3, 22),
new Vector3(13, 3, 17),
new Vector3(27, 2.5f, 17),
new Vector3(8, 2, 14),
new Vector3(8, 2, 15),
new Vector3(8, 2, 16),
new Vector3(9, 2, 14),
new Vector3(9, 2, 15),
new Vector3(9, 2, 16),
new Vector3(10, 2, 14),
new Vector3(10, 2, 15),
new Vector3(10, 2, 16),
new Vector3(18, 2, 25),
new Vector3(18, 2, 26),
new Vector3(18, 2, 27),
new Vector3(19, 2, 25),
new Vector3(19, 2, 26),
new Vector3(19, 2, 27),
new Vector3(20, 2, 25),
new Vector3(20, 2, 26),
new Vector3(20, 2, 27),
new Vector3(28, 2, 13),
new Vector3(28, 2, 14),
new Vector3(28, 2, 15),
new Vector3(29, 2, 13),
new Vector3(29, 2, 14),
new Vector3(29, 2, 15),
new Vector3(30, 2, 13),
new Vector3(30, 2, 14),
new Vector3(30, 2, 15),
new Vector3(27, 2, 6),
new Vector3(27, 2, 7),
new Vector3(27, 2, 8),
new Vector3(28, 2, 6),
new Vector3(28, 2, 7),
new Vector3(28, 2, 8),
new Vector3(29, 2, 6),
new Vector3(29, 2, 7),
new Vector3(29, 2, 8),
new Vector3(28, 2, 17),
new Vector3(28, 2, 18),
new Vector3(28, 2, 19),
new Vector3(29, 2, 17),
new Vector3(29, 2, 18),
new Vector3(29, 2, 19),
new Vector3(30, 2, 17),
new Vector3(30, 2, 18),
new Vector3(30, 2, 19),
new Vector3(9, 2, 6),
new Vector3(9, 2, 7),
new Vector3(9, 2, 8),
new Vector3(10, 2, 6),
new Vector3(10, 2, 7),
new Vector3(10, 2, 8),
new Vector3(11, 2, 6),
new Vector3(11, 2, 7),
new Vector3(11, 2, 8),
new Vector3(20, 2, 5),
new Vector3(20, 2, 6),
new Vector3(20, 2, 7),
new Vector3(21, 2, 5),
new Vector3(21, 2, 6),
new Vector3(21, 2, 7),
new Vector3(22, 2, 5),
new Vector3(22, 2, 6),
new Vector3(22, 2, 7),
new Vector3(22, 1.5f, 27),
new Vector3(22, 1.5f, 28),
new Vector3(22, 1.5f, 29),
new Vector3(23, 1.5f, 27),
new Vector3(23, 1.5f, 28),
new Vector3(23, 1.5f, 29),
new Vector3(24, 1.5f, 27),
new Vector3(24, 1.5f, 28),
new Vector3(24, 1.5f, 29),
new Vector3(3, 1, 15),
new Vector3(3, 1, 16),
new Vector3(3, 1, 17),
new Vector3(3, 1, 18),
new Vector3(3, 1, 19),
new Vector3(4, 1, 15),
new Vector3(4, 1, 16),
new Vector3(4, 1, 17),
new Vector3(4, 1, 18),
new Vector3(4, 1, 19),
new Vector3(5, 1, 15),
new Vector3(5, 1, 16),
new Vector3(5, 1, 17),
new Vector3(5, 1, 18),
new Vector3(5, 1, 19),
new Vector3(6, 1, 15),
new Vector3(6, 1, 16),
new Vector3(6, 1, 17),
new Vector3(6, 1, 18),
new Vector3(6, 1, 19),
new Vector3(7, 1, 15),
new Vector3(7, 1, 16),
new Vector3(7, 1, 17),
new Vector3(7, 1, 18),
new Vector3(7, 1, 19),
new Vector3(3, 1, 15),
new Vector3(3, 1, 16),
new Vector3(3, 1, 17),
new Vector3(3, 1, 18),
new Vector3(3, 1, 19),
new Vector3(4, 1, 15),
new Vector3(4, 1, 16),
new Vector3(4, 1, 17),
new Vector3(4, 1, 18),
new Vector3(4, 1, 19),
new Vector3(5, 1, 15),
new Vector3(5, 1, 16),
new Vector3(5, 1, 17),
new Vector3(5, 1, 18),
new Vector3(5, 1, 19),
new Vector3(6, 1, 15),
new Vector3(6, 1, 16),
new Vector3(6, 1, 17),
new Vector3(6, 1, 18),
new Vector3(6, 1, 19),
new Vector3(7, 1, 15),
new Vector3(7, 1, 16),
new Vector3(7, 1, 17),
new Vector3(7, 1, 18),
new Vector3(7, 1, 19),
new Vector3(31, 1, 8),
new Vector3(31, 1, 9),
new Vector3(31, 1, 10),
new Vector3(31, 1, 11),
new Vector3(31, 1, 12),
new Vector3(32, 1, 8),
new Vector3(32, 1, 9),
new Vector3(32, 1, 10),
new Vector3(32, 1, 11),
new Vector3(32, 1, 12),
new Vector3(33, 1, 8),
new Vector3(33, 1, 9),
new Vector3(33, 1, 10),
new Vector3(33, 1, 11),
new Vector3(33, 1, 12),
new Vector3(34, 1, 8),
new Vector3(34, 1, 9),
new Vector3(34, 1, 10),
new Vector3(34, 1, 11),
new Vector3(34, 1, 12),
new Vector3(35, 1, 8),
new Vector3(35, 1, 9),
new Vector3(35, 1, 10),
new Vector3(35, 1, 11),
new Vector3(35, 1, 12),
new Vector3(21, 1, 2),
new Vector3(21, 1, 3),
new Vector3(21, 1, 4),
new Vector3(22, 1, 2),
new Vector3(22, 1, 3),
new Vector3(22, 1, 4),
new Vector3(23, 1, 2),
new Vector3(23, 1, 3),
new Vector3(23, 1, 4),
new Vector3(24, 1, 2),
new Vector3(24, 1, 3),
new Vector3(24, 1, 4),
new Vector3(25, 1, 2),
new Vector3(25, 1, 3),
new Vector3(25, 1, 4),
new Vector3(17, 3, 32),
new Vector3(17, 2.5f, 28),
new Vector3(16, 2.5f, 36),
new Vector3(13, 2.5f, 31),
new Vector3(17, 2.5f, 28),
new Vector3(14, 2, 25),
new Vector3(14, 2, 26),
new Vector3(14, 2, 27),
new Vector3(15, 2, 25),
new Vector3(15, 2, 26),
new Vector3(15, 2, 27),
new Vector3(16, 2, 25),
new Vector3(16, 2, 26),
new Vector3(16, 2, 27),
new Vector3(14, 2, 37),
new Vector3(14, 2, 38),
new Vector3(14, 2, 39),
new Vector3(15, 2, 37),
new Vector3(15, 2, 38),
new Vector3(15, 2, 39),
new Vector3(16, 2, 37),
new Vector3(16, 2, 38),
new Vector3(16, 2, 39),
new Vector3(14, 2, 25),
new Vector3(14, 2, 26),
new Vector3(14, 2, 27),
new Vector3(15, 2, 25),
new Vector3(15, 2, 26),
new Vector3(15, 2, 27),
new Vector3(16, 2, 25),
new Vector3(16, 2, 26),
new Vector3(16, 2, 27),
new Vector3(10, 2, 29),
new Vector3(10, 2, 30),
new Vector3(10, 2, 31),
new Vector3(11, 2, 29),
new Vector3(11, 2, 30),
new Vector3(11, 2, 31),
new Vector3(12, 2, 29),
new Vector3(12, 2, 30),
new Vector3(12, 2, 31),
new Vector3(24, 1.5f, 28),
new Vector3(24, 1.5f, 29),
new Vector3(24, 1.5f, 30),
new Vector3(25, 1.5f, 28),
new Vector3(25, 1.5f, 29),
new Vector3(25, 1.5f, 30),
new Vector3(26, 1.5f, 28),
new Vector3(26, 1.5f, 29),
new Vector3(26, 1.5f, 30),
new Vector3(18, 1, 20),
new Vector3(18, 1, 21),
new Vector3(18, 1, 22),
new Vector3(18, 1, 23),
new Vector3(18, 1, 24),
new Vector3(19, 1, 20),
new Vector3(19, 1, 21),
new Vector3(19, 1, 22),
new Vector3(19, 1, 23),
new Vector3(19, 1, 24),
new Vector3(20, 1, 20),
new Vector3(20, 1, 21),
new Vector3(20, 1, 22),
new Vector3(20, 1, 23),
new Vector3(20, 1, 24),
new Vector3(21, 1, 20),
new Vector3(21, 1, 21),
new Vector3(21, 1, 22),
new Vector3(21, 1, 23),
new Vector3(21, 1, 24),
new Vector3(22, 1, 20),
new Vector3(22, 1, 21),
new Vector3(22, 1, 22),
new Vector3(22, 1, 23),
new Vector3(22, 1, 24),
new Vector3(25, 1, 30),
new Vector3(25, 1, 31),
new Vector3(25, 1, 32),
new Vector3(25, 1, 33),
new Vector3(25, 1, 34),
new Vector3(26, 1, 30),
new Vector3(26, 1, 31),
new Vector3(26, 1, 32),
new Vector3(26, 1, 33),
new Vector3(26, 1, 34),
new Vector3(27, 1, 30),
new Vector3(27, 1, 31),
new Vector3(27, 1, 32),
new Vector3(27, 1, 33),
new Vector3(27, 1, 34),
new Vector3(28, 1, 30),
new Vector3(28, 1, 31),
new Vector3(28, 1, 32),
new Vector3(28, 1, 33),
new Vector3(28, 1, 34),
new Vector3(29, 1, 30),
new Vector3(29, 1, 31),
new Vector3(29, 1, 32),
new Vector3(29, 1, 33),
new Vector3(29, 1, 34),
new Vector3(6, 1, 39),
new Vector3(6, 1, 40),
new Vector3(6, 1, 41),
new Vector3(6, 1, 42),
new Vector3(6, 1, 43),
new Vector3(7, 1, 39),
new Vector3(7, 1, 40),
new Vector3(7, 1, 41),
new Vector3(7, 1, 42),
new Vector3(7, 1, 43),
new Vector3(8, 1, 39),
new Vector3(8, 1, 40),
new Vector3(8, 1, 41),
new Vector3(8, 1, 42),
new Vector3(8, 1, 43),
new Vector3(9, 1, 39),
new Vector3(9, 1, 40),
new Vector3(9, 1, 41),
new Vector3(9, 1, 42),
new Vector3(9, 1, 43),
new Vector3(10, 1, 39),
new Vector3(10, 1, 40),
new Vector3(10, 1, 41),
new Vector3(10, 1, 42),
new Vector3(10, 1, 43),
new Vector3(5, 1, 32),
new Vector3(5, 1, 33),
new Vector3(5, 1, 34),
new Vector3(5, 1, 35),
new Vector3(5, 1, 36),
new Vector3(6, 1, 32),
new Vector3(6, 1, 33),
new Vector3(6, 1, 34),
new Vector3(6, 1, 35),
new Vector3(6, 1, 36),
new Vector3(7, 1, 32),
new Vector3(7, 1, 33),
new Vector3(7, 1, 34),
new Vector3(7, 1, 35),
new Vector3(7, 1, 36),
new Vector3(8, 1, 32),
new Vector3(8, 1, 33),
new Vector3(8, 1, 34),
new Vector3(8, 1, 35),
new Vector3(8, 1, 36),
new Vector3(9, 1, 32),
new Vector3(9, 1, 33),
new Vector3(9, 1, 34),
new Vector3(9, 1, 35),
new Vector3(9, 1, 36),
new Vector3(25, 1, 33),
new Vector3(25, 1, 34),
new Vector3(25, 1, 35),
new Vector3(25, 1, 36),
new Vector3(25, 1, 37),
new Vector3(26, 1, 33),
new Vector3(26, 1, 34),
new Vector3(26, 1, 35),
new Vector3(26, 1, 36),
new Vector3(26, 1, 37),
new Vector3(27, 1, 33),
new Vector3(27, 1, 34),
new Vector3(27, 1, 35),
new Vector3(27, 1, 36),
new Vector3(27, 1, 37),
new Vector3(28, 1, 33),
new Vector3(28, 1, 34),
new Vector3(28, 1, 35),
new Vector3(28, 1, 36),
new Vector3(28, 1, 37),
new Vector3(29, 1, 33),
new Vector3(29, 1, 34),
new Vector3(29, 1, 35),
new Vector3(29, 1, 36),
new Vector3(29, 1, 37),
new Vector3(14, 1, 40),
new Vector3(14, 1, 41),
new Vector3(14, 1, 42),
new Vector3(14, 1, 43),
new Vector3(14, 1, 44),
new Vector3(15, 1, 40),
new Vector3(15, 1, 41),
new Vector3(15, 1, 42),
new Vector3(15, 1, 43),
new Vector3(15, 1, 44),
new Vector3(16, 1, 40),
new Vector3(16, 1, 41),
new Vector3(16, 1, 42),
new Vector3(16, 1, 43),
new Vector3(16, 1, 44),
new Vector3(17, 1, 40),
new Vector3(17, 1, 41),
new Vector3(17, 1, 42),
new Vector3(17, 1, 43),
new Vector3(17, 1, 44),
new Vector3(18, 1, 40),
new Vector3(18, 1, 41),
new Vector3(18, 1, 42),
new Vector3(18, 1, 43),
new Vector3(18, 1, 44),
new Vector3(43, 3, 41),
new Vector3(46, 2.5f, 38),
new Vector3(42, 2.5f, 45),
new Vector3(42, 2.5f, 45),
new Vector3(37, 2, 35),
new Vector3(37, 2, 36),
new Vector3(37, 2, 37),
new Vector3(38, 2, 35),
new Vector3(38, 2, 36),
new Vector3(38, 2, 37),
new Vector3(39, 2, 35),
new Vector3(39, 2, 36),
new Vector3(39, 2, 37),
new Vector3(37, 2, 45),
new Vector3(37, 2, 46),
new Vector3(37, 2, 47),
new Vector3(38, 2, 45),
new Vector3(38, 2, 46),
new Vector3(38, 2, 47),
new Vector3(39, 2, 45),
new Vector3(39, 2, 46),
new Vector3(39, 2, 47),
new Vector3(40, 2, 46),
new Vector3(40, 2, 47),
new Vector3(40, 2, 48),
new Vector3(41, 2, 46),
new Vector3(41, 2, 47),
new Vector3(41, 2, 48),
new Vector3(42, 2, 46),
new Vector3(42, 2, 47),
new Vector3(42, 2, 48),
new Vector3(44, 1.5f, 32),
new Vector3(44, 1.5f, 33),
new Vector3(44, 1.5f, 34),
new Vector3(45, 1.5f, 32),
new Vector3(45, 1.5f, 33),
new Vector3(45, 1.5f, 34),
new Vector3(46, 1.5f, 32),
new Vector3(46, 1.5f, 33),
new Vector3(46, 1.5f, 34),
new Vector3(31, 1, 37),
new Vector3(31, 1, 38),
new Vector3(31, 1, 39),
new Vector3(31, 1, 40),
new Vector3(31, 1, 41),
new Vector3(32, 1, 37),
new Vector3(32, 1, 38),
new Vector3(32, 1, 39),
new Vector3(32, 1, 40),
new Vector3(32, 1, 41),
new Vector3(33, 1, 37),
new Vector3(33, 1, 38),
new Vector3(33, 1, 39),
new Vector3(33, 1, 40),
new Vector3(33, 1, 41),
new Vector3(34, 1, 37),
new Vector3(34, 1, 38),
new Vector3(34, 1, 39),
new Vector3(34, 1, 40),
new Vector3(34, 1, 41),
new Vector3(35, 1, 37),
new Vector3(35, 1, 38),
new Vector3(35, 1, 39),
new Vector3(35, 1, 40),
new Vector3(35, 1, 41),
new Vector3(31, 1, 40),
new Vector3(31, 1, 41),
new Vector3(31, 1, 42),
new Vector3(31, 1, 43),
new Vector3(31, 1, 44),
new Vector3(32, 1, 40),
new Vector3(32, 1, 41),
new Vector3(32, 1, 42),
new Vector3(32, 1, 43),
new Vector3(32, 1, 44),
new Vector3(33, 1, 40),
new Vector3(33, 1, 41),
new Vector3(33, 1, 42),
new Vector3(33, 1, 43),
new Vector3(33, 1, 44),
new Vector3(34, 1, 40),
new Vector3(34, 1, 41),
new Vector3(34, 1, 42),
new Vector3(34, 1, 43),
new Vector3(34, 1, 44),
new Vector3(35, 1, 40),
new Vector3(35, 1, 41),
new Vector3(35, 1, 42),
new Vector3(35, 1, 43),
new Vector3(35, 1, 44),
new Vector3(38, 3, 20),
new Vector3(34, 2.5f, 19),
new Vector3(41, 2.5f, 17),
new Vector3(37, 2.5f, 24),
new Vector3(37, 2.5f, 24),
new Vector3(42, 2, 24),
new Vector3(42, 2, 25),
new Vector3(42, 2, 26),
new Vector3(43, 2, 24),
new Vector3(43, 2, 25),
new Vector3(43, 2, 26),
new Vector3(44, 2, 24),
new Vector3(44, 2, 25),
new Vector3(44, 2, 26),
new Vector3(35, 2, 25),
new Vector3(35, 2, 26),
new Vector3(35, 2, 27),
new Vector3(36, 2, 25),
new Vector3(36, 2, 26),
new Vector3(36, 2, 27),
new Vector3(37, 2, 25),
new Vector3(37, 2, 26),
new Vector3(37, 2, 27),
new Vector3(43, 2, 19),
new Vector3(43, 2, 20),
new Vector3(43, 2, 21),
new Vector3(44, 2, 19),
new Vector3(44, 2, 20),
new Vector3(44, 2, 21),
new Vector3(45, 2, 19),
new Vector3(45, 2, 20),
new Vector3(45, 2, 21),
new Vector3(32, 2, 24),
new Vector3(32, 2, 25),
new Vector3(32, 2, 26),
new Vector3(33, 2, 24),
new Vector3(33, 2, 25),
new Vector3(33, 2, 26),
new Vector3(34, 2, 24),
new Vector3(34, 2, 25),
new Vector3(34, 2, 26),
new Vector3(37, 1, 8),
new Vector3(37, 1, 9),
new Vector3(37, 1, 10),
new Vector3(37, 1, 11),
new Vector3(37, 1, 12),
new Vector3(38, 1, 8),
new Vector3(38, 1, 9),
new Vector3(38, 1, 10),
new Vector3(38, 1, 11),
new Vector3(38, 1, 12),
new Vector3(39, 1, 8),
new Vector3(39, 1, 9),
new Vector3(39, 1, 10),
new Vector3(39, 1, 11),
new Vector3(39, 1, 12),
new Vector3(40, 1, 8),
new Vector3(40, 1, 9),
new Vector3(40, 1, 10),
new Vector3(40, 1, 11),
new Vector3(40, 1, 12),
new Vector3(41, 1, 8),
new Vector3(41, 1, 9),
new Vector3(41, 1, 10),
new Vector3(41, 1, 11),
new Vector3(41, 1, 12),
new Vector3(27, 1, 9),
new Vector3(27, 1, 10),
new Vector3(27, 1, 11),
new Vector3(27, 1, 12),
new Vector3(27, 1, 13),
new Vector3(28, 1, 9),
new Vector3(28, 1, 10),
new Vector3(28, 1, 11),
new Vector3(28, 1, 12),
new Vector3(28, 1, 13),
new Vector3(29, 1, 9),
new Vector3(29, 1, 10),
new Vector3(29, 1, 11),
new Vector3(29, 1, 12),
new Vector3(29, 1, 13),
new Vector3(30, 1, 9),
new Vector3(30, 1, 10),
new Vector3(30, 1, 11),
new Vector3(30, 1, 12),
new Vector3(30, 1, 13),
new Vector3(31, 1, 9),
new Vector3(31, 1, 10),
new Vector3(31, 1, 11),
new Vector3(31, 1, 12),
new Vector3(31, 1, 13),
new Vector3(34, 1, 8),
new Vector3(34, 1, 9),
new Vector3(34, 1, 10),
new Vector3(34, 1, 11),
new Vector3(34, 1, 12),
new Vector3(35, 1, 8),
new Vector3(35, 1, 9),
new Vector3(35, 1, 10),
new Vector3(35, 1, 11),
new Vector3(35, 1, 12),
new Vector3(36, 1, 8),
new Vector3(36, 1, 9),
new Vector3(36, 1, 10),
new Vector3(36, 1, 11),
new Vector3(36, 1, 12),
new Vector3(37, 1, 8),
new Vector3(37, 1, 9),
new Vector3(37, 1, 10),
new Vector3(37, 1, 11),
new Vector3(37, 1, 12),
new Vector3(38, 1, 8),
new Vector3(38, 1, 9),
new Vector3(38, 1, 10),
new Vector3(38, 1, 11),
new Vector3(38, 1, 12),
new Vector3(45, 1, 9),
new Vector3(45, 1, 10),
new Vector3(45, 1, 11),
new Vector3(45, 1, 12),
new Vector3(45, 1, 13),
new Vector3(46, 1, 9),
new Vector3(46, 1, 10),
new Vector3(46, 1, 11),
new Vector3(46, 1, 12),
new Vector3(46, 1, 13),
new Vector3(47, 1, 9),
new Vector3(47, 1, 10),
new Vector3(47, 1, 11),
new Vector3(47, 1, 12),
new Vector3(47, 1, 13),
new Vector3(48, 1, 9),
new Vector3(48, 1, 10),
new Vector3(48, 1, 11),
new Vector3(48, 1, 12),
new Vector3(48, 1, 13),
new Vector3(21, 4, 12),
new Vector3(17, 3.5f, 11),
new Vector3(24, 3.5f, 15),
new Vector3(26, 3, 7),
new Vector3(26, 3, 7),
new Vector3(14, 2.5f, 19),
new Vector3(14, 2.5f, 19),
new Vector3(29, 2, 2),
new Vector3(29, 2, 3),
new Vector3(29, 2, 4),
new Vector3(30, 2, 2),
new Vector3(30, 2, 3),
new Vector3(30, 2, 4),
new Vector3(31, 2, 2),
new Vector3(31, 2, 3),
new Vector3(31, 2, 4),
new Vector3(29, 2, 20),
new Vector3(29, 2, 21),
new Vector3(29, 2, 22),
new Vector3(30, 2, 20),
new Vector3(30, 2, 21),
new Vector3(30, 2, 22),
new Vector3(31, 2, 20),
new Vector3(31, 2, 21),
new Vector3(31, 2, 22),
new Vector3(10, 2, 8),
new Vector3(10, 2, 9),
new Vector3(10, 2, 10),
new Vector3(11, 2, 8),
new Vector3(11, 2, 9),
new Vector3(11, 2, 10),
new Vector3(12, 2, 8),
new Vector3(12, 2, 9),
new Vector3(12, 2, 10),
new Vector3(29, 2, 20),
new Vector3(29, 2, 21),
new Vector3(29, 2, 22),
new Vector3(30, 2, 20),
new Vector3(30, 2, 21),
new Vector3(30, 2, 22),
new Vector3(31, 2, 20),
new Vector3(31, 2, 21),
new Vector3(31, 2, 22),
new Vector3(30, 2, 7),
new Vector3(30, 2, 8),
new Vector3(30, 2, 9),
new Vector3(31, 2, 7),
new Vector3(31, 2, 8),
new Vector3(31, 2, 9),
new Vector3(32, 2, 7),
new Vector3(32, 2, 8),
new Vector3(32, 2, 9),
new Vector3(8, 1.5f, 11),
new Vector3(8, 1.5f, 12),
new Vector3(8, 1.5f, 13),
new Vector3(9, 1.5f, 11),
new Vector3(9, 1.5f, 12),
new Vector3(9, 1.5f, 13),
new Vector3(10, 1.5f, 11),
new Vector3(10, 1.5f, 12),
new Vector3(10, 1.5f, 13),
new Vector3(9, 1.5f, 2),
new Vector3(10, 1.5f, 2),
new Vector3(11, 1.5f, 2),
new Vector3(31, 1.5f, 2),
new Vector3(32, 1.5f, 2),
new Vector3(33, 1.5f, 2),
new Vector3(9, 1.5f, 2),
new Vector3(10, 1.5f, 2),
new Vector3(11, 1.5f, 2),
new Vector3(8, 1.5f, 8),
new Vector3(8, 1.5f, 9),
new Vector3(8, 1.5f, 10),
new Vector3(9, 1.5f, 8),
new Vector3(9, 1.5f, 9),
new Vector3(9, 1.5f, 10),
new Vector3(10, 1.5f, 8),
new Vector3(10, 1.5f, 9),
new Vector3(10, 1.5f, 10),
new Vector3(9, 1.5f, 22),
new Vector3(9, 1.5f, 23),
new Vector3(9, 1.5f, 24),
new Vector3(10, 1.5f, 22),
new Vector3(10, 1.5f, 23),
new Vector3(10, 1.5f, 24),
new Vector3(11, 1.5f, 22),
new Vector3(11, 1.5f, 23),
new Vector3(11, 1.5f, 24),
new Vector3(6, 1, 23),
new Vector3(6, 1, 24),
new Vector3(6, 1, 25),
new Vector3(6, 1, 26),
new Vector3(6, 1, 27),
new Vector3(7, 1, 23),
new Vector3(7, 1, 24),
new Vector3(7, 1, 25),
new Vector3(7, 1, 26),
new Vector3(7, 1, 27),
new Vector3(8, 1, 23),
new Vector3(8, 1, 24),
new Vector3(8, 1, 25),
new Vector3(8, 1, 26),
new Vector3(8, 1, 27),
new Vector3(9, 1, 23),
new Vector3(9, 1, 24),
new Vector3(9, 1, 25),
new Vector3(9, 1, 26),
new Vector3(9, 1, 27),
new Vector3(10, 1, 23),
new Vector3(10, 1, 24),
new Vector3(10, 1, 25),
new Vector3(10, 1, 26),
new Vector3(10, 1, 27),
new Vector3(33, 1, 6),
new Vector3(33, 1, 7),
new Vector3(33, 1, 8),
new Vector3(33, 1, 9),
new Vector3(33, 1, 10),
new Vector3(34, 1, 6),
new Vector3(34, 1, 7),
new Vector3(34, 1, 8),
new Vector3(34, 1, 9),
new Vector3(34, 1, 10),
new Vector3(35, 1, 6),
new Vector3(35, 1, 7),
new Vector3(35, 1, 8),
new Vector3(35, 1, 9),
new Vector3(35, 1, 10),
new Vector3(36, 1, 6),
new Vector3(36, 1, 7),
new Vector3(36, 1, 8),
new Vector3(36, 1, 9),
new Vector3(36, 1, 10),
new Vector3(37, 1, 6),
new Vector3(37, 1, 7),
new Vector3(37, 1, 8),
new Vector3(37, 1, 9),
new Vector3(37, 1, 10),
new Vector3(33, 1, 11),
new Vector3(33, 1, 12),
new Vector3(33, 1, 13),
new Vector3(33, 1, 14),
new Vector3(33, 1, 15),
new Vector3(34, 1, 11),
new Vector3(34, 1, 12),
new Vector3(34, 1, 13),
new Vector3(34, 1, 14),
new Vector3(34, 1, 15),
new Vector3(35, 1, 11),
new Vector3(35, 1, 12),
new Vector3(35, 1, 13),
new Vector3(35, 1, 14),
new Vector3(35, 1, 15),
new Vector3(36, 1, 11),
new Vector3(36, 1, 12),
new Vector3(36, 1, 13),
new Vector3(36, 1, 14),
new Vector3(36, 1, 15),
new Vector3(37, 1, 11),
new Vector3(37, 1, 12),
new Vector3(37, 1, 13),
new Vector3(37, 1, 14),
new Vector3(37, 1, 15),
new Vector3(5, 1, 11),
new Vector3(5, 1, 12),
new Vector3(5, 1, 13),
new Vector3(5, 1, 14),
new Vector3(5, 1, 15),
new Vector3(6, 1, 11),
new Vector3(6, 1, 12),
new Vector3(6, 1, 13),
new Vector3(6, 1, 14),
new Vector3(6, 1, 15),
new Vector3(7, 1, 11),
new Vector3(7, 1, 12),
new Vector3(7, 1, 13),
new Vector3(7, 1, 14),
new Vector3(7, 1, 15),
new Vector3(8, 1, 11),
new Vector3(8, 1, 12),
new Vector3(8, 1, 13),
new Vector3(8, 1, 14),
new Vector3(8, 1, 15),
new Vector3(9, 1, 11),
new Vector3(9, 1, 12),
new Vector3(9, 1, 13),
new Vector3(9, 1, 14),
new Vector3(9, 1, 15),
new Vector3(5, 1, 10),
new Vector3(5, 1, 11),
new Vector3(5, 1, 12),
new Vector3(5, 1, 13),
new Vector3(5, 1, 14),
new Vector3(6, 1, 10),
new Vector3(6, 1, 11),
new Vector3(6, 1, 12),
new Vector3(6, 1, 13),
new Vector3(6, 1, 14),
new Vector3(7, 1, 10),
new Vector3(7, 1, 11),
new Vector3(7, 1, 12),
new Vector3(7, 1, 13),
new Vector3(7, 1, 14),
new Vector3(8, 1, 10),
new Vector3(8, 1, 11),
new Vector3(8, 1, 12),
new Vector3(8, 1, 13),
new Vector3(8, 1, 14),
new Vector3(9, 1, 10),
new Vector3(9, 1, 11),
new Vector3(9, 1, 12),
new Vector3(9, 1, 13),
new Vector3(9, 1, 14),
new Vector3(6, 3, 18),
new Vector3(5, 2.5f, 22),
new Vector3(2, 2.5f, 17),
new Vector3(6, 2.5f, 22),
new Vector3(3, 2.5f, 21),
new Vector3(9, 2.5f, 21),
new Vector3(6, 2, 23),
new Vector3(6, 2, 24),
new Vector3(6, 2, 25),
new Vector3(7, 2, 23),
new Vector3(7, 2, 24),
new Vector3(7, 2, 25),
new Vector3(8, 2, 23),
new Vector3(8, 2, 24),
new Vector3(8, 2, 25),
new Vector3(6, 2, 11),
new Vector3(6, 2, 12),
new Vector3(6, 2, 13),
new Vector3(7, 2, 11),
new Vector3(7, 2, 12),
new Vector3(7, 2, 13),
new Vector3(8, 2, 11),
new Vector3(8, 2, 12),
new Vector3(8, 2, 13),
new Vector3(12, 1.5f, 10),
new Vector3(12, 1.5f, 11),
new Vector3(12, 1.5f, 12),
new Vector3(13, 1.5f, 10),
new Vector3(13, 1.5f, 11),
new Vector3(13, 1.5f, 12),
new Vector3(14, 1.5f, 10),
new Vector3(14, 1.5f, 11),
new Vector3(14, 1.5f, 12),
new Vector3(13, 1.5f, 17),
new Vector3(13, 1.5f, 18),
new Vector3(13, 1.5f, 19),
new Vector3(14, 1.5f, 17),
new Vector3(14, 1.5f, 18),
new Vector3(14, 1.5f, 19),
new Vector3(15, 1.5f, 17),
new Vector3(15, 1.5f, 18),
new Vector3(15, 1.5f, 19),
new Vector3(2, 1.5f, 25),
new Vector3(2, 1.5f, 26),
new Vector3(2, 1.5f, 27),
new Vector3(3, 1.5f, 25),
new Vector3(3, 1.5f, 26),
new Vector3(3, 1.5f, 27),
new Vector3(4, 1.5f, 25),
new Vector3(4, 1.5f, 26),
new Vector3(4, 1.5f, 27),
new Vector3(12, 1.5f, 24),
new Vector3(12, 1.5f, 25),
new Vector3(12, 1.5f, 26),
new Vector3(13, 1.5f, 24),
new Vector3(13, 1.5f, 25),
new Vector3(13, 1.5f, 26),
new Vector3(14, 1.5f, 24),
new Vector3(14, 1.5f, 25),
new Vector3(14, 1.5f, 26),
new Vector3(12, 1.5f, 10),
new Vector3(12, 1.5f, 11),
new Vector3(12, 1.5f, 12),
new Vector3(13, 1.5f, 10),
new Vector3(13, 1.5f, 11),
new Vector3(13, 1.5f, 12),
new Vector3(14, 1.5f, 10),
new Vector3(14, 1.5f, 11),
new Vector3(14, 1.5f, 12),
new Vector3(2, 1.5f, 25),
new Vector3(2, 1.5f, 26),
new Vector3(2, 1.5f, 27),
new Vector3(3, 1.5f, 25),
new Vector3(3, 1.5f, 26),
new Vector3(3, 1.5f, 27),
new Vector3(4, 1.5f, 25),
new Vector3(4, 1.5f, 26),
new Vector3(4, 1.5f, 27),
new Vector3(14, 1, 17),
new Vector3(14, 1, 18),
new Vector3(14, 1, 19),
new Vector3(14, 1, 20),
new Vector3(14, 1, 21),
new Vector3(15, 1, 17),
new Vector3(15, 1, 18),
new Vector3(15, 1, 19),
new Vector3(15, 1, 20),
new Vector3(15, 1, 21),
new Vector3(16, 1, 17),
new Vector3(16, 1, 18),
new Vector3(16, 1, 19),
new Vector3(16, 1, 20),
new Vector3(16, 1, 21),
new Vector3(17, 1, 17),
new Vector3(17, 1, 18),
new Vector3(17, 1, 19),
new Vector3(17, 1, 20),
new Vector3(17, 1, 21),
new Vector3(18, 1, 17),
new Vector3(18, 1, 18),
new Vector3(18, 1, 19),
new Vector3(18, 1, 20),
new Vector3(18, 1, 21),
new Vector3(27, 3, 8),
new Vector3(24, 2.5f, 5),
new Vector3(24, 2.5f, 11),
new Vector3(30, 2.5f, 5),
new Vector3(23, 2.5f, 7),
new Vector3(25, 2, 13),
new Vector3(25, 2, 14),
new Vector3(25, 2, 15),
new Vector3(26, 2, 13),
new Vector3(26, 2, 14),
new Vector3(26, 2, 15),
new Vector3(27, 2, 13),
new Vector3(27, 2, 14),
new Vector3(27, 2, 15),
new Vector3(21, 2, 12),
new Vector3(21, 2, 13),
new Vector3(21, 2, 14),
new Vector3(22, 2, 12),
new Vector3(22, 2, 13),
new Vector3(22, 2, 14),
new Vector3(23, 2, 12),
new Vector3(23, 2, 13),
new Vector3(23, 2, 14),
new Vector3(32, 2, 6),
new Vector3(32, 2, 7),
new Vector3(32, 2, 8),
new Vector3(33, 2, 6),
new Vector3(33, 2, 7),
new Vector3(33, 2, 8),
new Vector3(34, 2, 6),
new Vector3(34, 2, 7),
new Vector3(34, 2, 8),
new Vector3(18, 1.5f, 9),
new Vector3(18, 1.5f, 10),
new Vector3(18, 1.5f, 11),
new Vector3(19, 1.5f, 9),
new Vector3(19, 1.5f, 10),
new Vector3(19, 1.5f, 11),
new Vector3(20, 1.5f, 9),
new Vector3(20, 1.5f, 10),
new Vector3(20, 1.5f, 11),
new Vector3(15, 1, 8),
new Vector3(15, 1, 9),
new Vector3(15, 1, 10),
new Vector3(15, 1, 11),
new Vector3(15, 1, 12),
new Vector3(16, 1, 8),
new Vector3(16, 1, 9),
new Vector3(16, 1, 10),
new Vector3(16, 1, 11),
new Vector3(16, 1, 12),
new Vector3(17, 1, 8),
new Vector3(17, 1, 9),
new Vector3(17, 1, 10),
new Vector3(17, 1, 11),
new Vector3(17, 1, 12),
new Vector3(18, 1, 8),
new Vector3(18, 1, 9),
new Vector3(18, 1, 10),
new Vector3(18, 1, 11),
new Vector3(18, 1, 12),
new Vector3(19, 1, 8),
new Vector3(19, 1, 9),
new Vector3(19, 1, 10),
new Vector3(19, 1, 11),
new Vector3(19, 1, 12),
new Vector3(23, 1, 16),
new Vector3(23, 1, 17),
new Vector3(23, 1, 18),
new Vector3(23, 1, 19),
new Vector3(23, 1, 20),
new Vector3(24, 1, 16),
new Vector3(24, 1, 17),
new Vector3(24, 1, 18),
new Vector3(24, 1, 19),
new Vector3(24, 1, 20),
new Vector3(25, 1, 16),
new Vector3(25, 1, 17),
new Vector3(25, 1, 18),
new Vector3(25, 1, 19),
new Vector3(25, 1, 20),
new Vector3(26, 1, 16),
new Vector3(26, 1, 17),
new Vector3(26, 1, 18),
new Vector3(26, 1, 19),
new Vector3(26, 1, 20),
new Vector3(27, 1, 16),
new Vector3(27, 1, 17),
new Vector3(27, 1, 18),
new Vector3(27, 1, 19),
new Vector3(27, 1, 20),
new Vector3(16, 1, 15),
new Vector3(16, 1, 16),
new Vector3(16, 1, 17),
new Vector3(16, 1, 18),
new Vector3(16, 1, 19),
new Vector3(17, 1, 15),
new Vector3(17, 1, 16),
new Vector3(17, 1, 17),
new Vector3(17, 1, 18),
new Vector3(17, 1, 19),
new Vector3(18, 1, 15),
new Vector3(18, 1, 16),
new Vector3(18, 1, 17),
new Vector3(18, 1, 18),
new Vector3(18, 1, 19),
new Vector3(19, 1, 15),
new Vector3(19, 1, 16),
new Vector3(19, 1, 17),
new Vector3(19, 1, 18),
new Vector3(19, 1, 19),
new Vector3(20, 1, 15),
new Vector3(20, 1, 16),
new Vector3(20, 1, 17),
new Vector3(20, 1, 18),
new Vector3(20, 1, 19),
new Vector3(8, 4, 13),
new Vector3(11, 3.5f, 10),
new Vector3(12, 3.5f, 13),
new Vector3(7, 3.5f, 9),
new Vector3(3, 3, 18),
new Vector3(6, 2.5f, 5),
new Vector3(8, 2, 2),
new Vector3(8, 2, 3),
new Vector3(8, 2, 4),
new Vector3(9, 2, 2),
new Vector3(9, 2, 3),
new Vector3(9, 2, 4),
new Vector3(10, 2, 2),
new Vector3(10, 2, 3),
new Vector3(10, 2, 4),
new Vector3(11, 1.5f, 24),
new Vector3(11, 1.5f, 25),
new Vector3(11, 1.5f, 26),
new Vector3(12, 1.5f, 24),
new Vector3(12, 1.5f, 25),
new Vector3(12, 1.5f, 26),
new Vector3(13, 1.5f, 24),
new Vector3(13, 1.5f, 25),
new Vector3(13, 1.5f, 26),
new Vector3(18, 1.5f, 23),
new Vector3(18, 1.5f, 24),
new Vector3(18, 1.5f, 25),
new Vector3(19, 1.5f, 23),
new Vector3(19, 1.5f, 24),
new Vector3(19, 1.5f, 25),
new Vector3(20, 1.5f, 23),
new Vector3(20, 1.5f, 24),
new Vector3(20, 1.5f, 25),
new Vector3(8, 1.5f, 24),
new Vector3(8, 1.5f, 25),
new Vector3(8, 1.5f, 26),
new Vector3(9, 1.5f, 24),
new Vector3(9, 1.5f, 25),
new Vector3(9, 1.5f, 26),
new Vector3(10, 1.5f, 24),
new Vector3(10, 1.5f, 25),
new Vector3(10, 1.5f, 26),
new Vector3(18, 1.5f, 2),
new Vector3(18, 1.5f, 3),
new Vector3(19, 1.5f, 2),
new Vector3(19, 1.5f, 3),
new Vector3(20, 1.5f, 2),
new Vector3(20, 1.5f, 3),
new Vector3(4, 1, 25),
new Vector3(4, 1, 26),
new Vector3(4, 1, 27),
new Vector3(4, 1, 28),
new Vector3(4, 1, 29),
new Vector3(5, 1, 25),
new Vector3(5, 1, 26),
new Vector3(5, 1, 27),
new Vector3(5, 1, 28),
new Vector3(5, 1, 29),
new Vector3(6, 1, 25),
new Vector3(6, 1, 26),
new Vector3(6, 1, 27),
new Vector3(6, 1, 28),
new Vector3(6, 1, 29),
new Vector3(7, 1, 25),
new Vector3(7, 1, 26),
new Vector3(7, 1, 27),
new Vector3(7, 1, 28),
new Vector3(7, 1, 29),
new Vector3(8, 1, 25),
new Vector3(8, 1, 26),
new Vector3(8, 1, 27),
new Vector3(8, 1, 28),
new Vector3(8, 1, 29),
new Vector3(4, 4, 17),
new Vector3(3, 3.5f, 21),
new Vector3(7, 3.5f, 14),
new Vector3(2, 3, 11),
new Vector3(9, 3, 12),
new Vector3(9, 3, 22),
new Vector3(12, 2.5f, 19),
new Vector3(11, 2.5f, 24),
new Vector3(11, 2.5f, 10),
new Vector3(12, 2.5f, 19),
new Vector3(4, 2, 26),
new Vector3(4, 2, 27),
new Vector3(4, 2, 28),
new Vector3(5, 2, 26),
new Vector3(5, 2, 27),
new Vector3(5, 2, 28),
new Vector3(6, 2, 26),
new Vector3(6, 2, 27),
new Vector3(6, 2, 28),
new Vector3(5, 1.5f, 28),
new Vector3(5, 1.5f, 29),
new Vector3(5, 1.5f, 30),
new Vector3(6, 1.5f, 28),
new Vector3(6, 1.5f, 29),
new Vector3(6, 1.5f, 30),
new Vector3(7, 1.5f, 28),
new Vector3(7, 1.5f, 29),
new Vector3(7, 1.5f, 30),
new Vector3(2, 1, 29),
new Vector3(2, 1, 30),
new Vector3(2, 1, 31),
new Vector3(2, 1, 32),
new Vector3(2, 1, 33),
new Vector3(3, 1, 29),
new Vector3(3, 1, 30),
new Vector3(3, 1, 31),
new Vector3(3, 1, 32),
new Vector3(3, 1, 33),
new Vector3(4, 1, 29),
new Vector3(4, 1, 30),
new Vector3(4, 1, 31),
new Vector3(4, 1, 32),
new Vector3(4, 1, 33),
new Vector3(15, 1, 2),
new Vector3(15, 1, 3),
new Vector3(15, 1, 4),
new Vector3(15, 1, 5),
new Vector3(15, 1, 6),
new Vector3(16, 1, 2),
new Vector3(16, 1, 3),
new Vector3(16, 1, 4),
new Vector3(16, 1, 5),
new Vector3(16, 1, 6),
new Vector3(17, 1, 2),
new Vector3(17, 1, 3),
new Vector3(17, 1, 4),
new Vector3(17, 1, 5),
new Vector3(17, 1, 6),
new Vector3(18, 1, 2),
new Vector3(18, 1, 3),
new Vector3(18, 1, 4),
new Vector3(18, 1, 5),
new Vector3(18, 1, 6),
new Vector3(19, 1, 2),
new Vector3(19, 1, 3),
new Vector3(19, 1, 4),
new Vector3(19, 1, 5),
new Vector3(19, 1, 6),
new Vector3(2, 1, 29),
new Vector3(2, 1, 30),
new Vector3(2, 1, 31),
new Vector3(2, 1, 32),
new Vector3(2, 1, 33),
new Vector3(3, 1, 29),
new Vector3(3, 1, 30),
new Vector3(3, 1, 31),
new Vector3(3, 1, 32),
new Vector3(3, 1, 33),
new Vector3(4, 1, 29),
new Vector3(4, 1, 30),
new Vector3(4, 1, 31),
new Vector3(4, 1, 32),
new Vector3(4, 1, 33),
new Vector3(15, 1, 28),
new Vector3(15, 1, 29),
new Vector3(15, 1, 30),
new Vector3(15, 1, 31),
new Vector3(15, 1, 32),
new Vector3(16, 1, 28),
new Vector3(16, 1, 29),
new Vector3(16, 1, 30),
new Vector3(16, 1, 31),
new Vector3(16, 1, 32),
new Vector3(17, 1, 28),
new Vector3(17, 1, 29),
new Vector3(17, 1, 30),
new Vector3(17, 1, 31),
new Vector3(17, 1, 32),
new Vector3(18, 1, 28),
new Vector3(18, 1, 29),
new Vector3(18, 1, 30),
new Vector3(18, 1, 31),
new Vector3(18, 1, 32),
new Vector3(19, 1, 28),
new Vector3(19, 1, 29),
new Vector3(19, 1, 30),
new Vector3(19, 1, 31),
new Vector3(19, 1, 32),
new Vector3(16, 1, 19),
new Vector3(16, 1, 20),
new Vector3(16, 1, 21),
new Vector3(16, 1, 22),
new Vector3(16, 1, 23),
new Vector3(17, 1, 19),
new Vector3(17, 1, 20),
new Vector3(17, 1, 21),
new Vector3(17, 1, 22),
new Vector3(17, 1, 23),
new Vector3(18, 1, 19),
new Vector3(18, 1, 20),
new Vector3(18, 1, 21),
new Vector3(18, 1, 22),
new Vector3(18, 1, 23),
new Vector3(19, 1, 19),
new Vector3(19, 1, 20),
new Vector3(19, 1, 21),
new Vector3(19, 1, 22),
new Vector3(19, 1, 23),
new Vector3(20, 1, 19),
new Vector3(20, 1, 20),
new Vector3(20, 1, 21),
new Vector3(20, 1, 22),
new Vector3(20, 1, 23)
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
                    listadoAguaInicial = Vectores.instancia.GenerarAgua(casillas, tamañoEscenarioX, tamañoEscenarioZ, alturaMaxima, limitesMapa);
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
          
            if (colocarJugador == true)
            {
                ColocarJugador2();
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
                        if (casillas[(int)casillaInicial.x, (int)casillaInicial.z] == null)
                        {
                            PonerCasilla(new Assets.Casilla(0, 0, casillaInicial));
                            listadoTerrenoInicial.Remove(casillaInicial);
                        }
                    }
                }
            }

            foreach (Assets.Casilla subcasilla in casillas)
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
                        if (casillas[x - 1, z - 1] == null)
                        {
                            CalcularTerreno_Xmenos1_Zmenos1(x, y, z);
                        }

                        if (casillas[x - 1, z + 1] == null)
                        {
                            CalcularTerreno_Xmenos1_Zmas1(x, y, z);
                        }

                        if (casillas[x + 1, z - 1] == null)
                        {
                            CalcularTerreno_Xmas1_Zmenos1(x, y, z);
                        }

                        if (casillas[x + 1, z + 1] == null)
                        {
                            CalcularTerreno_Xmas1_Zmas1(x, y, z);
                        }

                        if (casillas[x, z - 1] == null)
                        {
                            CalcularTerreno_X0_Zmenos1(x, y, z);
                        }

                        if (casillas[x - 1, z] == null)
                        {
                            CalcularTerreno_Xmenos1_Z0(x, y, z);
                        }

                        if (casillas[x, z + 1] == null)
                        {
                            CalcularTerreno_X0_Zmas1(x, y, z);
                        }

                        if (casillas[x + 1, z] == null)
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
            Assets.Casilla rampas4rotacion90 = new Assets.Casilla(4, 90, new Vector3(x - 1, y, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarVacio(casillas[x, z - 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarVacio(casillas[x, z - 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarCasilla2(casillas[x, z - 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarVacio(casillas[x, z - 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(0, 0, new Vector3(x - 1, y + 0.5f, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(3, 90, new Vector3(x - 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 2], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(3, 270, new Vector3(x - 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(3, 180, new Vector3(x - 1, y, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true && ComprobarCasilla0(casillas[x, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(1, 90, new Vector3(x - 1, y, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(1, 180, new Vector3(x - 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x, z - 1], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z - 1], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion180 = new Assets.Casilla(2, 180, new Vector3(x - 1, y, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true)
            {
                PonerCasilla(esquina2rotacion180);
            }
        }

        //Gris - esquina2rotacion270
        private void CalcularTerreno_Xmenos1_Zmas1(int x, float y, int z)
        {
            Assets.Casilla rampas4rotacion0 = new Assets.Casilla(39, 0, new Vector3(x - 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z + 2], y, 90) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarVacio(casillas[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z + 2], y, 90) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarCasilla2(casillas[x, z + 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 2], y, 90) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarVacio(casillas[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarVacio(casillas[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarCasilla1(casillas[x, z + 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x - 2, z]) == true && ComprobarCasilla3(casillas[x, z + 2], y - 0.5f, 180) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(35, 0, new Vector3(x - 1, y + 0.5f, z + 1));

            if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 2, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(38, 180, new Vector3(x - 1, y, z + 1));

            if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(38, 0, new Vector3(x - 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(38, 270, new Vector3(x - 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(36, 270, new Vector3(x - 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(36, 180, new Vector3(x - 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 2], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion270 = new Assets.Casilla(37, 270, new Vector3(x - 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true)
            {
                PonerCasilla(esquina2rotacion270);
            }
        }

        //Marron Claro - esquina2rotacion90 
        private void CalcularTerreno_Xmas1_Zmenos1(int x, float y, int z)
        {
            Assets.Casilla rampas4rotacion0 = new Assets.Casilla(34, 0, new Vector3(x + 1, y, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla2(casillas[x, z - 2], y - 0.5f, 0) == true && ComprobarVacio(casillas[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarCasilla2(casillas[x + 2, z], y - 0.5f, 180) == true && ComprobarVacio(casillas[x, z - 2]) == true && ComprobarVacio(casillas[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z - 1]) == true && ComprobarCasilla1(casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla1(casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla1(casillas[x, z - 2], y - 0.5f, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla2(casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z - 1]) == true && ComprobarCasilla2(casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z - 1]) == true && ComprobarCasilla2(casillas[x, z - 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla1(casillas[x, z - 2], y - 0.5f, 270) == true && ComprobarVacio(casillas[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla3(casillas[x, z - 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla3(casillas[x, z - 2], y - 0.5f, 0) == true && ComprobarVacio(casillas[x + 1, z]) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z - 1]) == true && ComprobarCasilla1(casillas[x, z - 2], y - 0.5f, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(30, 0, new Vector3(x + 1, y + 0.5f, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z - 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(33, 180, new Vector3(x + 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarVacio(casillas[x + 1, z - 2]) == true && ComprobarVacio(casillas[x + 2, z]) == false)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(33, 0, new Vector3(x + 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(33, 90, new Vector3(x + 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 2], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true && ComprobarCasilla1(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 2], y, 270) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion0);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(31, 0, new Vector3(x + 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z - 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(31, 90, new Vector3(x + 1, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion90 = new Assets.Casilla(32, 90, new Vector3(x + 1, y, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true)
            {
                PonerCasilla(esquina2rotacion90);
            }
        }

        //Morado - esquina2rotacion0
        private void CalcularTerreno_Xmas1_Zmas1(int x, float y, int z)
        {
            Assets.Casilla rampas4rotacion90 = new Assets.Casilla(29, 90, new Vector3(x + 1, y, z + 1));

            if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y - 0.5f, 270) == true && ComprobarVacio(casillas[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z], y - 0.5f, 180) == true && ComprobarVacio(casillas[x, z + 2]) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla2(casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarCasilla2(casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla3(casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarCasilla1(casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla1(casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla2(casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarCasilla1(casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarCasilla2(casillas[x, z + 2], y - 0.5f, 90) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarCasilla0(casillas[x + 1, z], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarCasilla1(casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarCasilla2(casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarCasilla2(casillas[x, z + 2], y - 0.5f, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            Assets.Casilla plano = new Assets.Casilla(25, 0, new Vector3(x + 1, y + 0.5f, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla1(casillas[x, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla1(casillas[x, z + 2], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(28, 0, new Vector3(x + 1, y, z + 1));

            if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true && ComprobarVacio(casillas[x + 1, z]) == false)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true && ComprobarVacio(casillas[x + 1, z]) == false && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true && ComprobarVacio(casillas[x + 1, z]) == false)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true && ComprobarVacio(casillas[x + 1, z]) == false)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(28, 90, new Vector3(x + 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarVacio(casillas[x + 2, z]) == true && ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x, z + 2]) == false)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x + 2, z + 2]) == true && ComprobarVacio(casillas[x + 2, z]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x + 2, z + 1]) == true && ComprobarVacio(casillas[x, z + 1]) == false)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(28, 270, new Vector3(x + 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarVacio(casillas[x + 1, z + 2]) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarVacio(casillas[x + 1, z + 2]) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla3(casillas[x + 2, z + 2], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 2], y, 180) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 2], y, 0) == true)
            {
                PonerCasilla(rampas4rotacion90);
            }

            //---------------------------------------

            if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(26, 270, new Vector3(x + 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(26, 0, new Vector3(x + 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 1], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion0 = new Assets.Casilla(27, 0, new Vector3(x + 1, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(esquina2rotacion0);
            }
        }

        //Rojo - rampa1rotacion90
        private void CalcularTerreno_X0_Zmenos1(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(20, 0, new Vector3(x, y + 0.5f, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x, z - 2], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x, z - 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(23, 90, new Vector3(x, y, z - 1));

            if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(23, 180, new Vector3(x, y, z - 1));

            if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 2], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(21, 90, new Vector3(x, y, z - 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true)
            {
                PonerCasilla(rampa1rotacion90);
            }
        }

        //Marron Oscuro - rampa1rotacion180
        private void CalcularTerreno_Xmenos1_Z0(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(5, 0, new Vector3(x - 1, y + 0.5f, z));

            if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z], y, 90) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(8, 270, new Vector3(x - 1, y, z));

            if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(8, 180, new Vector3(x - 1, y, z));

            if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 2, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(6, 180, new Vector3(x - 1, y, z));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 180) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion180);
            }
        }

        //Blanco - rampa1rotacion270
        private void CalcularTerreno_X0_Zmas1(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(10, 0, new Vector3(x, y + 0.5f, z + 1));

            if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x, z + 2], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 2], y, 180) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(13, 0, new Vector3(x, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x - 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x - 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(13, 270, new Vector3(x, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 2], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(11, 270, new Vector3(x, y, z + 1));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 270) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion270);
            }
        }

        //Amarillo - rampa1rotacion0
        private void CalcularTerreno_Xmas1_Z0(int x, float y, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(15, 0, new Vector3(x + 1, y + 0.5f, z));

            if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 180) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z], y, 270) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z], y, 0) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(18, 0, new Vector3(x + 1, y, z));

            if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z - 1], y, 270) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z - 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }

            //---------------------------------------

            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(18, 90, new Vector3(x + 1, y, z));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla1(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 2, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 180) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 2, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 1], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla0(casillas[x, z], y, 0) == true && ComprobarCasilla0(casillas[x + 1, z + 1], y, 0) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true && ComprobarCasilla2(casillas[x, z + 1], y, 0) == true && ComprobarCasilla2(casillas[x + 1, z + 2], y, 90) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(16, 0, new Vector3(x + 1, y, z));

            if (ComprobarCasilla0(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla1(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 0) == true)
            {
                PonerCasilla(rampa1rotacion0);
            }
            else if (ComprobarCasilla2(casillas[x, z], y, 90) == true)
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
                    if (casillas[(int)casillaInicial.x, (int)casillaInicial.z] == null)
                    {
                        PonerCasilla(new Assets.Casilla(40, 0, casillaInicial));
                        listadoAguaInicial.Remove(casillaInicial);
                    }
                }
            }

            foreach (Assets.Casilla subcasilla in casillas)
            {
                if (subcasilla != null)
                {
                    if (subcasilla.id == 5)
                    {
                        int x = (int)subcasilla.posicion.x;
                        int z = (int)subcasilla.posicion.z;

                        if (Limites.Comprobar(x, 2, tamañoEscenarioX) == true && Limites.Comprobar(z, 2, tamañoEscenarioZ) == true)
                        {
                            if (casillas[x - 1, z - 1] == null)
                            {
                                CalcularAgua_Xmenos1_Zmenos1(x, z);
                            }

                            if (casillas[x + 1, z + 1] == null)
                            {
                                CalcularAgua_Xmas1_Zmas1(x, z);
                            }

                            if (casillas[x - 1, z + 1] == null)
                            {
                                CalcularAgua_Xmenos1_Zmas1(x, z);
                            }

                            if (casillas[x + 1, z - 1] == null)
                            {
                                CalcularAgua_Xmas1_Zmenos1(x, z);
                            }

                            if (casillas[x, z - 1] == null)
                            {
                                CalcularAgua_X0_Zmenos1(x, z);
                            }

                            if (casillas[x, z + 1] == null)
                            {
                                CalcularAgua_X0_Zmas1(x, z);
                            }

                            if (casillas[x - 1, z] == null)
                            {
                                CalcularAgua_Xmenos1_Z0(x, z);
                            }

                            if (casillas[x + 1, z] == null)
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
            Assets.Casilla esquina3rotacion0 = new Assets.Casilla(43, 0, new Vector3(x - 1, 0, z - 1));

            if (ComprobarVacio(casillas[x - 1, z]) == true && ComprobarVacio(casillas[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
            else if (ComprobarAgua2(x - 1, z, 0) == true && ComprobarVacio(casillas[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion0);
            }
        }

        private void CalcularAgua_Xmas1_Zmas1(int x, int z)
        {
            Assets.Casilla esquina3rotacion180 = new Assets.Casilla(43, 180, new Vector3(x + 1, 0, z + 1));

            if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarAgua2(x + 1, z, 180) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }
            else if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarAgua2(x, z + 1, 180) == true)
            {
                PonerCasilla(esquina3rotacion180);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion180 = new Assets.Casilla(42, 180, new Vector3(x + 1, 0, z + 1));

            if (ComprobarAgua0(x + 1, z) == true && ComprobarAgua0(x, z + 1) == true && ComprobarAgua0(x + 1, z + 2) == false)
            {
                PonerCasilla(esquina2rotacion180);
            }
        }

        private void CalcularAgua_Xmenos1_Zmas1(int x, int z)
        {
            Assets.Casilla esquina3rotacion90 = new Assets.Casilla(43, 90, new Vector3(x - 1, 0, z + 1));

            if (ComprobarVacio(casillas[x - 1, z]) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
            else if (ComprobarAgua2(x - 1, z, 90) == true && ComprobarVacio(casillas[x, z + 1]) == true)
            {
                PonerCasilla(esquina3rotacion90);
            }
        }

        private void CalcularAgua_Xmas1_Zmenos1(int x, int z)
        {
            Assets.Casilla esquina3rotacion270 = new Assets.Casilla(43, 270, new Vector3(x + 1, 0, z - 1));

            if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarVacio(casillas[x, z - 1]) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
            else if (ComprobarVacio(casillas[x + 1, z]) == true && ComprobarAgua2(x, z - 1, 270) == true)
            {
                PonerCasilla(esquina3rotacion270);
            }
        }

        private void CalcularAgua_X0_Zmenos1(int x, int z)
        {
            Assets.Casilla esquina2rotacion0 = new Assets.Casilla(42, 0, new Vector3(x, 0, z - 1));

            if (ComprobarAgua0(x + 1, z - 1) == true)
            {
                PonerCasilla(esquina2rotacion0);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion270 = new Assets.Casilla(41, 270, new Vector3(x, 0, z - 1));

            PonerCasilla(rampa1rotacion270);
        }

        private void CalcularAgua_X0_Zmas1(int x, int z)
        {
            Assets.Casilla esquina2rotacion90 = new Assets.Casilla(42, 90, new Vector3(x, 0, z + 1));

            if (ComprobarAgua0(x + 1, z + 1) == true && ComprobarVacio(casillas[x - 1, z + 2]) == true)
            {
                PonerCasilla(esquina2rotacion90);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion90 = new Assets.Casilla(41, 90, new Vector3(x, 0, z + 1));

            PonerCasilla(rampa1rotacion90);
        }

        private void CalcularAgua_Xmenos1_Z0(int x, int z)
        {
            Assets.Casilla rampa1rotacion0 = new Assets.Casilla(41, 0, new Vector3(x - 1, 0, z));

            PonerCasilla(rampa1rotacion0);
        }

        private void CalcularAgua_Xmas1_Z0(int x, int z)
        {
            Assets.Casilla plano = new Assets.Casilla(40, 0, new Vector3(x + 1, 0.25f, z));

            if (ComprobarAgua0(x + 1, z - 1) == true && ComprobarAgua0(x + 1, z + 1) == true)
            {
                PonerCasilla(plano);
            }

            //---------------------------------------

            Assets.Casilla esquina2rotacion270 = new Assets.Casilla(42, 270, new Vector3(x + 1, 0, z));

            if (ComprobarAgua0(x + 1, z + 1) == true && ComprobarVacio(casillas[x + 2, z - 1]) == true)
            {
                PonerCasilla(esquina2rotacion270);
            }

            //---------------------------------------

            Assets.Casilla rampa1rotacion180 = new Assets.Casilla(41, 180, new Vector3(x + 1, 0, z));

            PonerCasilla(rampa1rotacion180);
        }

        //------------------------------------------------------------------------------------------------------------------------------------

        private void PonerCasilla(Assets.Casilla casilla)
        {
            Assets.Casilla[] casillasFinal;
            int id = casilla.id;
            int idDebug = casilla.idDebug;

            if (coloresGeneracion == false)
            {
                if (casilla.isla != null)
                {
                    casillasFinal = casilla.isla.casillas;
                    id = casilla.id;
                }
                else
                {
                    casillasFinal = casillasDebug;
                    id = CalcularIDFinal(casilla.id);
                }
            }
            else
            {
                casillasFinal = casillasDebug;
                id = casilla.id;
                idDebug = casilla.id;
            }

            int x = (int)casilla.posicion.x;
            int z = (int)casilla.posicion.z;

            if (Limites.Comprobar(x, 3, tamañoEscenarioX) == true && Limites.Comprobar(z, 3, tamañoEscenarioZ) == true)
            {
                if (casillas[x, z] == null)
                {
                    Vector3 posicionFinal = casilla.posicion;

                    if (casillasEscala != 0.5f)
                    {
                        posicionFinal.x = (posicionFinal.x + posicionFinal.x * (casillasEscala * 1.5f)) - (tamañoEscenarioX / (casillasEscala + 0.5f));
                        posicionFinal.y = posicionFinal.y + posicionFinal.y * (casillasEscala * 1.5f);
                        posicionFinal.z = (posicionFinal.z + posicionFinal.z * (casillasEscala * 1.5f)) - (tamañoEscenarioZ / (casillasEscala + 0.5f));
                    }

                    GameObject casilla2 = Instantiate(casillasFinal[id].prefab, posicionFinal, Quaternion.identity);
                    casilla2.gameObject.transform.Rotate(Vector3.up, casilla.rotacion, Space.World);
                    casilla2.gameObject.transform.localScale = new Vector3(casillasEscala, casillasEscala, casillasEscala);

                    Assets.Casilla casilla3 = new Assets.Casilla(id, casilla.rotacion, casilla.posicion);
                    casilla3.id = id;
                    casilla3.idDebug = idDebug;
                    casilla3.prefab = casillasFinal[id].prefab;

                    casillas[x, z] = casilla3;
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

        private bool ComprobarCasilla0(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 0)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 0)
                                {
                                    return true;
                                }
                            }                            
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarCasilla1(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 1)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 1)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarCasilla2(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 2)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 2)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarCasilla3(Assets.Casilla casilla, float altura, int rotacion)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, limitesMapa) == true && ComprobarLimiteZ((int)casilla.posicion.z, limitesMapa) == true)
                {
                    if (casilla.posicion.y == (altura + 0.5f))
                    {
                        if (casilla.rotacion == rotacion)
                        {
                            if (coloresGeneracion == false)
                            {
                                if (casilla.id == 3)
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                if (CalcularIDFinal(casilla.idDebug) == 3)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private bool ComprobarVacio(Assets.Casilla casilla)
        {
            if (casilla != null)
            {
                if (ComprobarLimiteX((int)casilla.posicion.x, 3) == true && ComprobarLimiteZ((int)casilla.posicion.z, 3) == true)
                {
                    if (casillas[(int)casilla.posicion.x, (int)casilla.posicion.z] != null)
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
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 5)
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
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 6 && casillas[x, z].rotacion == rotacion)
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
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 7 && casillas[x, z].rotacion == rotacion)
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
                if (casillas[x, z] != null)
                {
                    if (casillas[x, z].id == 8 && casillas[x, z].rotacion == rotacion)
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
            foreach (Assets.Isla isla in islas)
            {
                for (int x = (int)isla.coordenadasMinimas.x; x < (int)isla.coordenadasMinimas.x + (int)isla.extensionMaxima.x; x++)
                {
                    for (int z = (int)isla.coordenadasMinimas.y; z < (int)isla.coordenadasMinimas.y + (int)isla.extensionMaxima.y; z++)
                    {
                        if (x >= limitesMapa && z >= limitesMapa && x <= tamañoEscenarioX - limitesMapa && z <= tamañoEscenarioZ - limitesMapa)
                        {
                            if (casillas[x, z] == null)
                            {
                                Assets.Casilla plano = new Assets.Casilla(isla.casillas[0].id, 0, new Vector3(x, altura, z));
                                plano.isla = isla;
                                PonerCasilla(plano);
                            }
                        }                     
                    }
                }
            }
        }

        private void ColocarJugador2()
        {
            int x = ((int)islas[0].coordenadasMinimas.x + (int)islas[0].extensionMaxima.x) / 2;
            int z = ((int)islas[0].coordenadasMinimas.y + (int)islas[0].extensionMaxima.y) / 2;

            if (casillas[x, z] != null)
            {
                Vector3 posicion = casillas[x, z].posicion;

                if (casillasEscala != 0.5f)
                {
                    posicion.y = 1.85f + posicion.y + posicion.y * (casillasEscala * 1.5f);
                }

                Jugador.Movimientos.instancia.transform.position = posicion;
            }         
        }
    }
}

