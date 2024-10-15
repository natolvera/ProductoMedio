using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoMedio.algoritmos
{
    public class GeneradorProductoMedio
    {
        public int seed1;
        public int seed2;
        public int puntosTotales;
        public int valor1;
        public int valor2;
        
        //public List<Aleatorio> Listaaleatorios = new List<Aleatorio>();
        public List<List<int>> listaDeListas = new List<List<int>>();
        public List<int> listaSeed1 = new List<int>();
        public List<int> listaSeed2 = new List<int>();
        public List<int> listaProducto = new List<int>();
        public List<int> listaNumMedios = new List<int>();
        public List<int> listaValor1 = new List<int>();
        public List<int> listaValor2 = new List<int>();

        public List<List<int>> crearListas(int seed1,
            int seed2, int puntosTotales)
        {

            for (int i = 0; i < puntosTotales; i++)
            {
                listaSeed1.Add(seed1);
                listaSeed2.Add(seed2);


                int producto = 0;
                producto = seed1 * seed2;
                listaProducto.Add(producto);

                string mediaStr = producto.ToString();
                if (mediaStr.Length <= 2)
                {
                    listaNumMedios.Add(0);
                }
                else
                {
                    
                    mediaStr = mediaStr.Substring(1, mediaStr.Length - 2);
                    int media = int.Parse(mediaStr);
                    listaNumMedios.Add(media);
                }

                if (mediaStr.Length <= 3)
                {
                    valor1 = int.Parse(mediaStr);
                    listaValor1.Add(valor1);

                    valor2 = 0;
                    listaValor2.Add(valor2);

                    seed1 = seed2;
                    seed2 = valor1;
                }
           
                else
                {
                    valor1 = int.Parse(mediaStr.Substring(0, 3));
                    valor2 = int.Parse(mediaStr.Substring(1));
                    listaValor1.Add(valor1);
                    listaValor2.Add(valor2);

                    seed1 = seed2;
                    seed2 = valor1;
             
                }
                       
            }

            listaDeListas.Add(listaSeed1);
            listaDeListas.Add(listaSeed2);
            listaDeListas.Add(listaProducto);
            listaDeListas.Add(listaNumMedios);
            listaDeListas.Add(listaValor1);
            listaDeListas.Add(listaValor2);

            return listaDeListas;

        }
    }
}
