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
        public bool portapapeles;
        public bool colocarJugador;

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
                listadoTerrenoInicial = new List<Vector3>{new Vector3(17, 2, 6),
new Vector3(17, 2, 7),
new Vector3(17, 2, 8),
new Vector3(22, 1.5f, 13),
new Vector3(22, 1.5f, 14),
new Vector3(22, 1.5f, 15),
new Vector3(23, 1.5f, 13),
new Vector3(23, 1.5f, 14),
new Vector3(23, 1.5f, 15),
new Vector3(24, 1.5f, 13),
new Vector3(24, 1.5f, 14),
new Vector3(24, 1.5f, 15),
new Vector3(7, 1.5f, 5),
new Vector3(7, 1.5f, 6),
new Vector3(7, 1.5f, 7),
new Vector3(8, 1.5f, 5),
new Vector3(8, 1.5f, 6),
new Vector3(8, 1.5f, 7),
new Vector3(9, 1.5f, 5),
new Vector3(9, 1.5f, 6),
new Vector3(9, 1.5f, 7),
new Vector3(6, 1.5f, 12),
new Vector3(6, 1.5f, 13),
new Vector3(6, 1.5f, 14),
new Vector3(7, 1.5f, 12),
new Vector3(7, 1.5f, 13),
new Vector3(7, 1.5f, 14),
new Vector3(8, 1.5f, 12),
new Vector3(8, 1.5f, 13),
new Vector3(8, 1.5f, 14),
new Vector3(6, 1.5f, 10),
new Vector3(6, 1.5f, 11),
new Vector3(6, 1.5f, 12),
new Vector3(7, 1.5f, 10),
new Vector3(7, 1.5f, 11),
new Vector3(7, 1.5f, 12),
new Vector3(8, 1.5f, 10),
new Vector3(8, 1.5f, 11),
new Vector3(8, 1.5f, 12),
new Vector3(3, 1, 9),
new Vector3(3, 1, 10),
new Vector3(3, 1, 11),
new Vector3(3, 1, 12),
new Vector3(3, 1, 13),
new Vector3(4, 1, 9),
new Vector3(4, 1, 10),
new Vector3(4, 1, 11),
new Vector3(4, 1, 12),
new Vector3(4, 1, 13),
new Vector3(5, 1, 9),
new Vector3(5, 1, 10),
new Vector3(5, 1, 11),
new Vector3(5, 1, 12),
new Vector3(5, 1, 13),
new Vector3(6, 1, 9),
new Vector3(6, 1, 10),
new Vector3(6, 1, 11),
new Vector3(6, 1, 12),
new Vector3(6, 1, 13),
new Vector3(7, 1, 9),
new Vector3(7, 1, 10),
new Vector3(7, 1, 11),
new Vector3(7, 1, 12),
new Vector3(7, 1, 13),
new Vector3(22, 1, 20),
new Vector3(22, 1, 21),
new Vector3(22, 1, 22),
new Vector3(22, 1, 23),
new Vector3(22, 1, 24),
new Vector3(23, 1, 20),
new Vector3(23, 1, 21),
new Vector3(23, 1, 22),
new Vector3(23, 1, 23),
new Vector3(23, 1, 24),
new Vector3(24, 1, 20),
new Vector3(24, 1, 21),
new Vector3(24, 1, 22),
new Vector3(24, 1, 23),
new Vector3(24, 1, 24),
new Vector3(25, 1, 20),
new Vector3(25, 1, 21),
new Vector3(25, 1, 22),
new Vector3(25, 1, 23),
new Vector3(25, 1, 24),
new Vector3(26, 1, 20),
new Vector3(26, 1, 21),
new Vector3(26, 1, 22),
new Vector3(26, 1, 23),
new Vector3(26, 1, 24),
new Vector3(28, 3, 21),
new Vector3(32, 2.5f, 20),
new Vector3(32, 2.5f, 20),
new Vector3(24, 2.5f, 21),
new Vector3(24, 2.5f, 21),
new Vector3(31, 2.5f, 24),
new Vector3(21, 2, 19),
new Vector3(21, 2, 20),
new Vector3(21, 2, 21),
new Vector3(22, 2, 19),
new Vector3(22, 2, 20),
new Vector3(22, 2, 21),
new Vector3(23, 2, 19),
new Vector3(23, 2, 20),
new Vector3(23, 2, 21),
new Vector3(32, 2, 15),
new Vector3(32, 2, 16),
new Vector3(32, 2, 17),
new Vector3(33, 2, 15),
new Vector3(33, 2, 16),
new Vector3(33, 2, 17),
new Vector3(34, 2, 15),
new Vector3(34, 2, 16),
new Vector3(34, 2, 17),
new Vector3(25, 2, 14),
new Vector3(25, 2, 15),
new Vector3(25, 2, 16),
new Vector3(26, 2, 14),
new Vector3(26, 2, 15),
new Vector3(26, 2, 16),
new Vector3(27, 2, 14),
new Vector3(27, 2, 15),
new Vector3(27, 2, 16),
new Vector3(21, 2, 20),
new Vector3(21, 2, 21),
new Vector3(21, 2, 22),
new Vector3(22, 2, 20),
new Vector3(22, 2, 21),
new Vector3(22, 2, 22),
new Vector3(23, 2, 20),
new Vector3(23, 2, 21),
new Vector3(23, 2, 22),
new Vector3(20, 1.5f, 27),
new Vector3(20, 1.5f, 28),
new Vector3(20, 1.5f, 29),
new Vector3(21, 1.5f, 27),
new Vector3(21, 1.5f, 28),
new Vector3(21, 1.5f, 29),
new Vector3(22, 1.5f, 27),
new Vector3(22, 1.5f, 28),
new Vector3(22, 1.5f, 29),
new Vector3(19, 1.5f, 18),
new Vector3(19, 1.5f, 19),
new Vector3(19, 1.5f, 20),
new Vector3(20, 1.5f, 18),
new Vector3(20, 1.5f, 19),
new Vector3(20, 1.5f, 20),
new Vector3(21, 1.5f, 18),
new Vector3(21, 1.5f, 19),
new Vector3(21, 1.5f, 20),
new Vector3(29, 1.5f, 28),
new Vector3(29, 1.5f, 29),
new Vector3(29, 1.5f, 30),
new Vector3(30, 1.5f, 28),
new Vector3(30, 1.5f, 29),
new Vector3(30, 1.5f, 30),
new Vector3(31, 1.5f, 28),
new Vector3(31, 1.5f, 29),
new Vector3(31, 1.5f, 30),
new Vector3(29, 1.5f, 28),
new Vector3(29, 1.5f, 29),
new Vector3(29, 1.5f, 30),
new Vector3(30, 1.5f, 28),
new Vector3(30, 1.5f, 29),
new Vector3(30, 1.5f, 30),
new Vector3(31, 1.5f, 28),
new Vector3(31, 1.5f, 29),
new Vector3(31, 1.5f, 30),
new Vector3(19, 1.5f, 18),
new Vector3(19, 1.5f, 19),
new Vector3(19, 1.5f, 20),
new Vector3(20, 1.5f, 18),
new Vector3(20, 1.5f, 19),
new Vector3(20, 1.5f, 20),
new Vector3(21, 1.5f, 18),
new Vector3(21, 1.5f, 19),
new Vector3(21, 1.5f, 20),
new Vector3(20, 1.5f, 13),
new Vector3(20, 1.5f, 14),
new Vector3(20, 1.5f, 15),
new Vector3(21, 1.5f, 13),
new Vector3(21, 1.5f, 14),
new Vector3(21, 1.5f, 15),
new Vector3(22, 1.5f, 13),
new Vector3(22, 1.5f, 14),
new Vector3(22, 1.5f, 15),
new Vector3(34, 1.5f, 13),
new Vector3(34, 1.5f, 14),
new Vector3(34, 1.5f, 15),
new Vector3(35, 1.5f, 13),
new Vector3(35, 1.5f, 14),
new Vector3(35, 1.5f, 15),
new Vector3(36, 1.5f, 13),
new Vector3(36, 1.5f, 14),
new Vector3(36, 1.5f, 15),
new Vector3(28, 1, 29),
new Vector3(28, 1, 30),
new Vector3(28, 1, 31),
new Vector3(28, 1, 32),
new Vector3(28, 1, 33),
new Vector3(29, 1, 29),
new Vector3(29, 1, 30),
new Vector3(29, 1, 31),
new Vector3(29, 1, 32),
new Vector3(29, 1, 33),
new Vector3(30, 1, 29),
new Vector3(30, 1, 30),
new Vector3(30, 1, 31),
new Vector3(30, 1, 32),
new Vector3(30, 1, 33),
new Vector3(31, 1, 29),
new Vector3(31, 1, 30),
new Vector3(31, 1, 31),
new Vector3(31, 1, 32),
new Vector3(31, 1, 33),
new Vector3(32, 1, 29),
new Vector3(32, 1, 30),
new Vector3(32, 1, 31),
new Vector3(32, 1, 32),
new Vector3(32, 1, 33),
new Vector3(27, 1, 29),
new Vector3(27, 1, 30),
new Vector3(27, 1, 31),
new Vector3(27, 1, 32),
new Vector3(27, 1, 33),
new Vector3(28, 1, 29),
new Vector3(28, 1, 30),
new Vector3(28, 1, 31),
new Vector3(28, 1, 32),
new Vector3(28, 1, 33),
new Vector3(29, 1, 29),
new Vector3(29, 1, 30),
new Vector3(29, 1, 31),
new Vector3(29, 1, 32),
new Vector3(29, 1, 33),
new Vector3(30, 1, 29),
new Vector3(30, 1, 30),
new Vector3(30, 1, 31),
new Vector3(30, 1, 32),
new Vector3(30, 1, 33),
new Vector3(31, 1, 29),
new Vector3(31, 1, 30),
new Vector3(31, 1, 31),
new Vector3(31, 1, 32),
new Vector3(31, 1, 33),
new Vector3(16, 1, 22),
new Vector3(16, 1, 23),
new Vector3(16, 1, 25),
new Vector3(16, 1, 26),
new Vector3(17, 1, 22),
new Vector3(17, 1, 23),
new Vector3(17, 1, 24),
new Vector3(17, 1, 25),
new Vector3(17, 1, 26),
new Vector3(18, 1, 22),
new Vector3(18, 1, 23),
new Vector3(18, 1, 24),
new Vector3(18, 1, 25),
new Vector3(18, 1, 26),
new Vector3(19, 1, 22),
new Vector3(19, 1, 23),
new Vector3(19, 1, 24),
new Vector3(19, 1, 25),
new Vector3(19, 1, 26),
new Vector3(20, 1, 22),
new Vector3(20, 1, 23),
new Vector3(20, 1, 24),
new Vector3(20, 1, 25),
new Vector3(20, 1, 26),
new Vector3(35, 1, 28),
new Vector3(35, 1, 29),
new Vector3(35, 1, 30),
new Vector3(35, 1, 31),
new Vector3(35, 1, 32),
new Vector3(36, 1, 28),
new Vector3(36, 1, 29),
new Vector3(36, 1, 30),
new Vector3(36, 1, 31),
new Vector3(36, 1, 32),
new Vector3(37, 1, 28),
new Vector3(37, 1, 29),
new Vector3(37, 1, 30),
new Vector3(37, 1, 31),
new Vector3(37, 1, 32),
new Vector3(38, 1, 28),
new Vector3(38, 1, 29),
new Vector3(38, 1, 30),
new Vector3(38, 1, 31),
new Vector3(38, 1, 32),
new Vector3(39, 1, 28),
new Vector3(39, 1, 29),
new Vector3(39, 1, 30),
new Vector3(39, 1, 31),
new Vector3(39, 1, 32),
new Vector3(28, 1, 29),
new Vector3(28, 1, 30),
new Vector3(28, 1, 31),
new Vector3(28, 1, 32),
new Vector3(28, 1, 33),
new Vector3(29, 1, 29),
new Vector3(29, 1, 30),
new Vector3(29, 1, 31),
new Vector3(29, 1, 32),
new Vector3(29, 1, 33),
new Vector3(30, 1, 29),
new Vector3(30, 1, 30),
new Vector3(30, 1, 31),
new Vector3(30, 1, 32),
new Vector3(30, 1, 33),
new Vector3(31, 1, 29),
new Vector3(31, 1, 30),
new Vector3(31, 1, 31),
new Vector3(31, 1, 32),
new Vector3(31, 1, 33),
new Vector3(32, 1, 29),
new Vector3(32, 1, 30),
new Vector3(32, 1, 31),
new Vector3(32, 1, 32),
new Vector3(32, 1, 33),
new Vector3(16, 1, 22),
new Vector3(16, 1, 23),
new Vector3(16, 1, 24),
new Vector3(16, 1, 25),
new Vector3(16, 1, 26),
new Vector3(17, 1, 22),
new Vector3(17, 1, 23),
new Vector3(17, 1, 24),
new Vector3(17, 1, 25),
new Vector3(17, 1, 26),
new Vector3(18, 1, 22),
new Vector3(18, 1, 23),
new Vector3(18, 1, 24),
new Vector3(18, 1, 25),
new Vector3(18, 1, 26),
new Vector3(19, 1, 22),
new Vector3(19, 1, 23),
new Vector3(19, 1, 24),
new Vector3(19, 1, 25),
new Vector3(19, 1, 26),
new Vector3(20, 1, 22),
new Vector3(20, 1, 23),
new Vector3(20, 1, 24),
new Vector3(20, 1, 25),
new Vector3(20, 1, 26),
new Vector3(39, 3, 38),
new Vector3(35, 2.5f, 38),
new Vector3(37, 2, 31),
new Vector3(37, 2, 32),
new Vector3(37, 2, 33),
new Vector3(38, 2, 31),
new Vector3(38, 2, 32),
new Vector3(38, 2, 33),
new Vector3(39, 2, 31),
new Vector3(39, 2, 32),
new Vector3(39, 2, 33),
new Vector3(33, 2, 32),
new Vector3(33, 2, 33),
new Vector3(33, 2, 34),
new Vector3(34, 2, 32),
new Vector3(34, 2, 33),
new Vector3(34, 2, 34),
new Vector3(35, 2, 32),
new Vector3(35, 2, 33),
new Vector3(35, 2, 34),
new Vector3(43, 2, 42),
new Vector3(43, 2, 43),
new Vector3(43, 2, 44),
new Vector3(44, 2, 42),
new Vector3(44, 2, 43),
new Vector3(44, 2, 44),
new Vector3(45, 2, 42),
new Vector3(45, 2, 43),
new Vector3(45, 2, 44),
new Vector3(35, 1.5f, 45),
new Vector3(35, 1.5f, 46),
new Vector3(35, 1.5f, 47),
new Vector3(36, 1.5f, 45),
new Vector3(36, 1.5f, 46),
new Vector3(36, 1.5f, 47),
new Vector3(37, 1.5f, 45),
new Vector3(37, 1.5f, 46),
new Vector3(37, 1.5f, 47),
new Vector3(40, 1.5f, 45),
new Vector3(40, 1.5f, 46),
new Vector3(40, 1.5f, 47),
new Vector3(41, 1.5f, 45),
new Vector3(41, 1.5f, 46),
new Vector3(41, 1.5f, 47),
new Vector3(42, 1.5f, 45),
new Vector3(42, 1.5f, 46),
new Vector3(42, 1.5f, 47),
new Vector3(46, 1.5f, 36),
new Vector3(46, 1.5f, 37),
new Vector3(46, 1.5f, 38),
new Vector3(47, 1.5f, 36),
new Vector3(47, 1.5f, 37),
new Vector3(47, 1.5f, 38),
new Vector3(48, 1.5f, 36),
new Vector3(48, 1.5f, 37),
new Vector3(48, 1.5f, 38),
new Vector3(31, 1.5f, 44),
new Vector3(31, 1.5f, 45),
new Vector3(31, 1.5f, 46),
new Vector3(32, 1.5f, 44),
new Vector3(32, 1.5f, 45),
new Vector3(32, 1.5f, 46),
new Vector3(33, 1.5f, 44),
new Vector3(33, 1.5f, 45),
new Vector3(33, 1.5f, 46),
new Vector3(30, 1.5f, 35),
new Vector3(30, 1.5f, 36),
new Vector3(30, 1.5f, 37),
new Vector3(31, 1.5f, 35),
new Vector3(31, 1.5f, 36),
new Vector3(31, 1.5f, 37),
new Vector3(32, 1.5f, 35),
new Vector3(32, 1.5f, 36),
new Vector3(32, 1.5f, 37),
new Vector3(30, 1.5f, 37),
new Vector3(30, 1.5f, 38),
new Vector3(30, 1.5f, 39),
new Vector3(31, 1.5f, 37),
new Vector3(31, 1.5f, 38),
new Vector3(31, 1.5f, 39),
new Vector3(32, 1.5f, 37),
new Vector3(32, 1.5f, 38),
new Vector3(32, 1.5f, 39),
new Vector3(28, 1, 27),
new Vector3(28, 1, 28),
new Vector3(28, 1, 29),
new Vector3(28, 1, 30),
new Vector3(28, 1, 31),
new Vector3(29, 1, 27),
new Vector3(29, 1, 28),
new Vector3(29, 1, 29),
new Vector3(29, 1, 30),
new Vector3(29, 1, 31),
new Vector3(30, 1, 27),
new Vector3(30, 1, 28),
new Vector3(30, 1, 29),
new Vector3(30, 1, 30),
new Vector3(30, 1, 31),
new Vector3(31, 1, 27),
new Vector3(31, 1, 28),
new Vector3(31, 1, 29),
new Vector3(31, 1, 30),
new Vector3(31, 1, 31),
new Vector3(32, 1, 27),
new Vector3(32, 1, 28),
new Vector3(32, 1, 29),
new Vector3(32, 1, 30),
new Vector3(32, 1, 31),
new Vector3(35, 1, 46),
new Vector3(35, 1, 47),
new Vector3(35, 1, 48),
new Vector3(36, 1, 46),
new Vector3(36, 1, 47),
new Vector3(36, 1, 48),
new Vector3(37, 1, 46),
new Vector3(37, 1, 47),
new Vector3(37, 1, 48),
new Vector3(38, 1, 46),
new Vector3(38, 1, 47),
new Vector3(38, 1, 48),
new Vector3(39, 1, 46),
new Vector3(39, 1, 47),
new Vector3(39, 1, 48),
new Vector3(28, 1, 45),
new Vector3(28, 1, 46),
new Vector3(28, 1, 47),
new Vector3(28, 1, 48),
new Vector3(29, 1, 45),
new Vector3(29, 1, 46),
new Vector3(29, 1, 47),
new Vector3(29, 1, 48),
new Vector3(30, 1, 45),
new Vector3(30, 1, 46),
new Vector3(30, 1, 47),
new Vector3(30, 1, 48),
new Vector3(31, 1, 45),
new Vector3(31, 1, 46),
new Vector3(31, 1, 47),
new Vector3(31, 1, 48),
new Vector3(32, 1, 45),
new Vector3(32, 1, 46),
new Vector3(32, 1, 47),
new Vector3(32, 1, 48),
new Vector3(45, 3, 9),
new Vector3(45, 2.5f, 5),
new Vector3(43, 2, 14),
new Vector3(43, 2, 15),
new Vector3(43, 2, 16),
new Vector3(44, 2, 14),
new Vector3(44, 2, 15),
new Vector3(44, 2, 16),
new Vector3(45, 2, 14),
new Vector3(45, 2, 15),
new Vector3(45, 2, 16),
new Vector3(38, 2, 6),
new Vector3(38, 2, 7),
new Vector3(38, 2, 8),
new Vector3(39, 2, 6),
new Vector3(39, 2, 7),
new Vector3(39, 2, 8),
new Vector3(40, 2, 6),
new Vector3(40, 2, 7),
new Vector3(40, 2, 8),
new Vector3(38, 2, 9),
new Vector3(38, 2, 10),
new Vector3(38, 2, 11),
new Vector3(39, 2, 9),
new Vector3(39, 2, 10),
new Vector3(39, 2, 11),
new Vector3(40, 2, 9),
new Vector3(40, 2, 10),
new Vector3(40, 2, 11),
new Vector3(36, 1.5f, 10),
new Vector3(36, 1.5f, 11),
new Vector3(36, 1.5f, 12),
new Vector3(37, 1.5f, 10),
new Vector3(37, 1.5f, 11),
new Vector3(37, 1.5f, 12),
new Vector3(38, 1.5f, 10),
new Vector3(38, 1.5f, 11),
new Vector3(38, 1.5f, 12),
new Vector3(43, 1.5f, 16),
new Vector3(43, 1.5f, 17),
new Vector3(43, 1.5f, 18),
new Vector3(44, 1.5f, 16),
new Vector3(44, 1.5f, 17),
new Vector3(44, 1.5f, 18),
new Vector3(45, 1.5f, 16),
new Vector3(45, 1.5f, 17),
new Vector3(45, 1.5f, 18),
new Vector3(37, 1.5f, 2),
new Vector3(37, 1.5f, 3),
new Vector3(38, 1.5f, 2),
new Vector3(38, 1.5f, 3),
new Vector3(39, 1.5f, 2),
new Vector3(39, 1.5f, 3),
new Vector3(41, 1.5f, 16),
new Vector3(41, 1.5f, 17),
new Vector3(41, 1.5f, 18),
new Vector3(42, 1.5f, 16),
new Vector3(42, 1.5f, 17),
new Vector3(42, 1.5f, 18),
new Vector3(43, 1.5f, 16),
new Vector3(43, 1.5f, 17),
new Vector3(43, 1.5f, 18),
new Vector3(43, 1.5f, 16),
new Vector3(43, 1.5f, 17),
new Vector3(43, 1.5f, 18),
new Vector3(44, 1.5f, 16),
new Vector3(44, 1.5f, 17),
new Vector3(44, 1.5f, 18),
new Vector3(45, 1.5f, 16),
new Vector3(45, 1.5f, 17),
new Vector3(45, 1.5f, 18),
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

