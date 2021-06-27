using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Escenario.Generar
{
    public class Vectores : MonoBehaviour
    {
        public static Vectores instancia;

        public void Awake()
        {
            instancia = this;
        }

        public List<Vector3> GenerarTerreno(Casilla[,] terrenos, int tamañoEscenarioX, int tamañoEscenarioZ, float alturaMaxima, int limitesMapa)
        {
            List<Vector3> listado = new List<Vector3>();
            Portapapeles.instancia.Limpiar();
            Portapapeles.instancia.Texto("listadoTerrenoInicial = new List<Vector3> {");
      
            int montañasGenerar = tamañoEscenarioX / 100 * tamañoEscenarioZ / 100;
            int intentosGeneracion = montañasGenerar * 2;

            int i = 1;
            while (i <= intentosGeneracion)
            {
                float alturaCasilla = (int)Random.Range(3, alturaMaxima);

                int posicionX = (int)Random.Range(0 + limitesMapa, tamañoEscenarioX - limitesMapa);
                int posicionZ = (int)Random.Range(0 + limitesMapa, tamañoEscenarioZ - limitesMapa);

                bool añadir = true;

                foreach (Casilla casilla in terrenos)
                {
                    if (casilla != null)
                    {
                        if (Enumerable.Range((int)(casilla.posicion.x - alturaCasilla), (int)(casilla.posicion.x + alturaCasilla)).Contains(posicionX))
                        {
                            if (Enumerable.Range((int)(casilla.posicion.z - alturaCasilla), (int)(casilla.posicion.z + alturaCasilla)).Contains(posicionZ))
                            {
                                añadir = false;

                                if (intentosGeneracion >= 0)
                                {
                                    intentosGeneracion -= 1;
                                    i -= 1;
                                }
                            }
                        }
                    }
                }

                if (Limites.Comprobar(posicionX, 2, tamañoEscenarioX) == false || Limites.Comprobar(posicionZ, 2, tamañoEscenarioZ) == false)
                {
                    añadir = false;
                }

                if (añadir == true)
                {
                    listado.Add(new Vector3(posicionX, alturaCasilla, posicionZ));
                    Portapapeles.instancia.Vector3(new Vector3(posicionX, alturaCasilla, posicionZ));

                    int desplazamiento = 0;
                    while (alturaCasilla >= 1)
                    {
                        int planos = (int)Random.Range(0, 4 + desplazamiento);

                        if (desplazamiento > 0)
                        {
                            int j = 0;
                            while (j <= planos)
                            {
                                int x = 0;
                                int z = 0;

                                int azar = (int)Random.Range(0, 12);

                                if (azar == 1)
                                {
                                    x = 1 + (int)(desplazamiento * 2);
                                    z = 1 + (int)(desplazamiento * 2);
                                }
                                else if (azar == 2)
                                {
                                    x = 1 + (int)(desplazamiento * 2);
                                    z = -1 - (int)(desplazamiento * 2);
                                }
                                else if (azar == 3)
                                {
                                    x = -1 - (int)(desplazamiento * 2);
                                    z = 1 + (int)(desplazamiento * 2);
                                }
                                else if (azar == 4)
                                {
                                    x = -1 - (int)(desplazamiento * 2);
                                    z = -1 - (int)(desplazamiento * 2);
                                }
                                else if (azar == 5 || azar == 6)
                                {
                                    x = 2 + (int)(desplazamiento * 2);
                                    z = Random.Range(-desplazamiento, desplazamiento);
                                }
                                else if (azar == 7 || azar == 8)
                                {
                                    x = -2 - (int)(desplazamiento * 2);
                                    z = Random.Range(-desplazamiento, desplazamiento);
                                }
                                else if (azar == 9 || azar == 10)
                                {
                                    x = Random.Range(-desplazamiento, desplazamiento);
                                    z = 2 + (int)(desplazamiento * 2);
                                }
                                else if (azar == 11 || azar == 12)
                                {
                                    x = Random.Range(-desplazamiento, desplazamiento);
                                    z = -2 - (int)(desplazamiento * 2);
                                }

                                if (azar > 0)
                                {
                                    if (alturaCasilla == 1.5f || alturaCasilla == 2f)
                                    {
                                        for (int origenX = posicionX + x - 1; origenX < posicionX + x + 2; origenX++)
                                        {
                                            for (int origenZ = posicionZ + z - 1; origenZ < posicionZ + z + 2; origenZ++)
                                            {
                                                if (Limites.Comprobar(origenX, 2, tamañoEscenarioX) == true && Limites.Comprobar(origenZ, 2, tamañoEscenarioZ) == true)
                                                {
                                                    if (terrenos[origenX, origenZ] == null)
                                                    {
                                                        listado.Add(new Vector3(origenX, alturaCasilla, origenZ));
                                                        Portapapeles.instancia.Vector3(new Vector3(origenX, alturaCasilla, origenZ));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (alturaCasilla == 1f)
                                    {
                                        for (int origenX = posicionX + x - 2; origenX < posicionX + x + 3; origenX++)
                                        {
                                            for (int origenZ = posicionZ + z - 2; origenZ < posicionZ + z + 3; origenZ++)
                                            {
                                                if (Limites.Comprobar(origenX, 2, tamañoEscenarioX) == true && Limites.Comprobar(origenZ, 2, tamañoEscenarioZ) == true)
                                                {
                                                    if (terrenos[origenX, origenZ] == null)
                                                    {
                                                        listado.Add(new Vector3(origenX, alturaCasilla, origenZ));
                                                        Portapapeles.instancia.Vector3(new Vector3(origenX, alturaCasilla, origenZ));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (Limites.Comprobar(posicionX + x, 2, tamañoEscenarioX) == true && Limites.Comprobar(posicionZ + z, 2, tamañoEscenarioZ) == true)
                                        {
                                            listado.Add(new Vector3(posicionX + x, alturaCasilla, posicionZ + z));
                                            Portapapeles.instancia.Vector3(new Vector3(posicionX + x, alturaCasilla, posicionZ + z));
                                        }
                                    }
                                }

                                j += 1;
                            }
                        }

                        alturaCasilla -= 0.5f;
                        desplazamiento += 1;
                    }
                }

                i += 1;
            }

            Portapapeles.instancia.Texto("};");

            return listado;
        }

        public List<Vector3> GenerarAgua(Casilla[,] terrenos, int tamañoEscenarioX, int tamañoEscenarioZ, float alturaMaxima, int limitesMapa)
        {
            List<Vector3> listado = null;
            Portapapeles.instancia.Texto("listadoAguaInicial = new List<Vector3> {");

            List<int> curvas = new List<int>();
            int cantidadCurvas = tamañoEscenarioZ / 33;

            int h = 1;
            while (h <= cantidadCurvas)
            {
                curvas.Add((int)Random.Range(tamañoEscenarioZ / cantidadCurvas * (h - 1), tamañoEscenarioZ / cantidadCurvas * h));
                h += 1;
            }

            int intentosInicio = tamañoEscenarioX / 100 * tamañoEscenarioZ / 100;
            int intentosMaximo = intentosInicio * 10;

            int i = 0;
            int j = 0;
            while (i < intentosInicio)
            {
                if (j > intentosMaximo)
                {
                    break;
                }

                int posicionX = (int)Random.Range(0 + limitesMapa + alturaMaxima, tamañoEscenarioX - limitesMapa - alturaMaxima);

                bool añadir = true;

                if (Limites.Comprobar(posicionX, 4, tamañoEscenarioX) == false)
                {
                    añadir = false;
                }

                for (int inicioX = posicionX - limitesMapa; inicioX <= posicionX + limitesMapa; inicioX++)
                {
                    for (int inicioZ = 0; inicioZ <= (int)alturaMaxima; inicioZ++)
                    {
                        if (terrenos[inicioX, inicioZ] != null)
                        {
                            añadir = false;
                        }
                    }
                }

                if (añadir == false)
                {
                    if (intentosInicio >= 0)
                    {
                        posicionX = (int)Random.Range(0 + limitesMapa + alturaMaxima, tamañoEscenarioX - limitesMapa - alturaMaxima);
                        i -= 1;
                        j += 1;
                    }
                }

                if (añadir == true)
                {
                    listado = new List<Vector3>();

                    listado.Add(new Vector3(posicionX, 0.25f, limitesMapa));
                    Portapapeles.instancia.Vector3(new Vector3(posicionX, 0.25f, limitesMapa));

                    listado.Add(new Vector3(posicionX - 1, 0.25f, limitesMapa));
                    Portapapeles.instancia.Vector3(new Vector3(posicionX - 1, 0.25f, limitesMapa));

                    listado.Add(new Vector3(posicionX + 1, 0.25f, limitesMapa));
                    Portapapeles.instancia.Vector3(new Vector3(posicionX + 1, 0.25f, limitesMapa));

                    int contadorMoverXIzquierda = 0;
                    int contadorMoverXDerecha = 0;

                    for (int origenZ = limitesMapa; origenZ <= tamañoEscenarioZ - limitesMapa; origenZ++)
                    {
                        if (listado.Count == 0)
                        {
                            break;
                        }

                        if (Limites.Comprobar(posicionX, 2, tamañoEscenarioX) == true && Limites.Comprobar(origenZ, 2, tamañoEscenarioZ) == true)
                        {
                            int casillaX1 = posicionX;
                            int casillaX2 = posicionX;
                            int casillaX3 = posicionX;

                            if (Limites.Comprobar(casillaX2 - 1, 2, tamañoEscenarioX) == true)
                            {
                                casillaX2 -= 1;
                            }

                            if (Limites.Comprobar(casillaX3 + 1, 2, tamañoEscenarioX) == true)
                            {
                                casillaX3 += 1;
                            }

                            int casillaZ1 = origenZ;
                            int casillaZ2 = origenZ;
                            int casillaZ3 = origenZ;

                            if (Limites.Comprobar(casillaZ1 + (int)alturaMaxima, (int)alturaMaxima, tamañoEscenarioZ) == true)
                            {
                                bool moverXDerecha = false;

                                for (int margenRio = casillaX1 - limitesMapa; margenRio <= casillaX3 + limitesMapa; margenRio++)
                                {
                                    if (listado.Count == 0)
                                    {
                                        break;
                                    }

                                    if (Limites.Comprobar(margenRio, limitesMapa, tamañoEscenarioX) == true && Limites.Comprobar(casillaZ1 + ((int)alturaMaxima * 2), limitesMapa, tamañoEscenarioZ) == true)
                                    {
                                        if (terrenos[margenRio, casillaZ1 + ((int)alturaMaxima * 2)] != null)
                                        {
                                            if (contadorMoverXIzquierda == 0)
                                            {
                                                for (int margenRio2 = casillaZ1 - limitesMapa; margenRio2 <= casillaZ3 + limitesMapa; margenRio2++)
                                                {
                                                    if (Limites.Comprobar(casillaX1 - ((int)alturaMaxima * 2), limitesMapa, tamañoEscenarioX) == true && Limites.Comprobar(margenRio2, limitesMapa, tamañoEscenarioZ) == true)
                                                    {
                                                        if (terrenos[casillaX1 - ((int)alturaMaxima * 2), margenRio2] != null)
                                                        {
                                                            i -= 1;
                                                            j += 1;
                                                            listado.Clear();
                                                            contadorMoverXDerecha = 0;
                                                            contadorMoverXIzquierda = 0;
                                                            break;
                                                        }
                                                    }

                                                    if (Limites.Comprobar(casillaX1 + ((int)alturaMaxima * 2), limitesMapa * 2, tamañoEscenarioX) == true && Limites.Comprobar(margenRio2, limitesMapa * 2, tamañoEscenarioZ) == true)
                                                    {
                                                        if (terrenos[casillaX1 + ((int)alturaMaxima * 2), margenRio2] != null)
                                                        {
                                                            contadorMoverXIzquierda += 1;
                                                        }
                                                    }
                                                }

                                                moverXDerecha = true;
                                            }
                                        }
                                    }
                                }

                                if (contadorMoverXIzquierda == 0 && moverXDerecha == false)
                                {
                                    foreach (int curva in curvas)
                                    {
                                        if (casillaZ1 == curva)
                                        {
                                            bool moverDerecha = true;

                                            if (Limites.Comprobar(casillaX1 + ((int)alturaMaxima * 2), limitesMapa * 2, tamañoEscenarioX) == true)
                                            {
                                                if (terrenos[casillaX1 + ((int)alturaMaxima * 2), casillaZ1] != null)
                                                {
                                                    moverDerecha = false;
                                                }
                                            }

                                            if (moverDerecha == true)
                                            {
                                                contadorMoverXDerecha += 1;
                                                moverXDerecha = true;
                                            }
                                        }
                                    }
                                }

                                if (contadorMoverXDerecha > limitesMapa)
                                {
                                    contadorMoverXDerecha = 0;
                                    moverXDerecha = false;
                                }

                                bool moverZ = false;

                                if (contadorMoverXIzquierda > 0 && contadorMoverXIzquierda <= alturaMaxima)
                                {
                                    contadorMoverXIzquierda += 1;
                                    posicionX -= 1;
                                    moverZ = true;
                                }
                                else
                                {
                                    contadorMoverXIzquierda = 0;

                                    if (moverXDerecha == true)
                                    {
                                        posicionX += 1;
                                        moverZ = true;
                                    }
                                }

                                if (moverZ == true)
                                {
                                    origenZ -= 1;

                                    if (Limites.Comprobar(casillaZ2 - 1, 3, tamañoEscenarioZ) == true)
                                    {
                                        casillaZ2 -= 1;
                                    }

                                    if (Limites.Comprobar(casillaZ3 + 1, 3, tamañoEscenarioZ) == true)
                                    {
                                        casillaZ3 += 1;
                                    }
                                }
                            }

                            if (terrenos[casillaX1, casillaZ1] == null)
                            {
                                listado.Add(new Vector3(casillaX1, 0.25f, casillaZ1));
                                Portapapeles.instancia.Vector3(new Vector3(casillaX1, 0.25f, casillaZ1));
                            }

                            if (terrenos[casillaX2, casillaZ2] == null)
                            {
                                listado.Add(new Vector3(casillaX2, 0.25f, casillaZ2));
                                Portapapeles.instancia.Vector3(new Vector3(casillaX2, 0.25f, casillaZ2));
                            }

                            if (terrenos[casillaX3, casillaZ3] == null)
                            {
                                listado.Add(new Vector3(casillaX3, 0.25f, casillaZ3));
                                Portapapeles.instancia.Vector3(new Vector3(casillaX3, 0.25f, casillaZ3));
                            }
                        }
                    }
                }

                i += 1;
            }

            Portapapeles.instancia.Texto("};");

            if (listado != null)
            {
                if (listado.Count > 0)
                {
                    return listado;
                }
            }

            return null;
        }
    }
}

