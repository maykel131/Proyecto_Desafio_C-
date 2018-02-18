using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Windows;

namespace ejercicio1proceso
{
    /// <summary>
    /// Descrição resumida de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        int cont = 0;
        int num1; int num2;int band; int eti;
        int[] px1;
        int[] px2;
        int i = 0;


        /**variables del metodo 3*/
        int candado = 0;  int nu1; int pot1; int nuF;
                        int fechar = 0; int posU;
        public object MessageBox { get; private set; }

        [WebMethod]
        public string HelloWorld()
        {
            return "Bemvindo";
        }
        [WebMethod]
        public string se_encuentram(string todo)
        {

            string aux = todo;
            char[] delimitador = { ' ' };
            string[] trozos = aux.Split(delimitador);
            int y = 0;
         

            if (trozos.Length == 4)
            {

                int x1 = Convert.ToInt32(trozos[0]);
                int v1 = Convert.ToInt32(trozos[1]);
                int x2 = Convert.ToInt32(trozos[2]);
                int v2 = Convert.ToInt32(trozos[3]);

                int p1 = x1;
                int p2 = x2;

                if (x1 < x2 && x1 <= 1000 && x2 <= 1000 && 1 <= v1 && v1 <= 10000 && 1 <= v2 && v2 <= 10000) {

                    if (x2 > x1)
                    {
                        if (v1 > v2)
                        {

                            do
                            {
                                p1 = p1 + v1;
                                p2 = p2 + v2;
                                if (p1 == p2)
                                {
                                    return "sim";
                                }


                            } while (p1 <= p2);

                            /*if (p1 >= 1000) { */
                            return "não";/* }*/
                        }
                        else { return "não"; }
                    }
                    //segundo caso
                    /* if (x1 > x2)
                     {
                         if (v2 > v1)
                         {

                             do
                             {
                                 p1 = p1 + v1;
                                 p2 = p2 + v2;
                                 if (p1 == p2)
                                 {
                                     return "sim se encontraran los canguros";
                                 }



                             } while (p1 >= p2);

                             return "nao se encontraran los canguros.**";
                         }
                         else { return "nao se encontraran los canguros"; }
                     }*/
                  

                    if (x1 == x2 && v1 == v2)
                {
                    return "sim";
                }
                if (x1 == x2 && v1 != v2)
                {
                    return "não";
                }

                else
                {
                    return "não";
                }


            } else return "deve atender: 0​ ​<=x1 < x2<=1000  1<=v1<=10000  1<=v2<=10000";



        }//final del if de divicion
            else
            {
                return "É necesario introduzir 4 numeros unicamente nesse orden x1 v1 x2 v2";
            }

        }


        [WebMethod]
        public string maximo_minimo(string todo)
        {
            int[] num = new int[5];
            int sum_mayor;
            int sum_menor;

            string aux = todo;
            char[] delimitador = { ' ' };
            string[] trozos = aux.Split(delimitador);
            int y = 0;

           

            if (trozos.Length == 5)
            {
                for (y = 0; y < num.Length; y++)
                {
                    num[y] = Convert.ToInt32(trozos[y]);
                }

                int teipe = 0;
                for (y = 0; y < num.Length; y++)
                {
                    if(1 > num[y] | num[y] > 10){
                        teipe = 2;
                    }
                }

                if (teipe == 2)
                {
                    return "Cada número inteiro tem que estar no intervalo de [1, 10]";
                }


                    int suma_total = 0;
                int num_mayor = 0, num_menor = num[0];
                for (y = 0; y < num.Length; y++)
                {
                    suma_total = suma_total + num[y];
                    if (num[y] > num_mayor)
                    {
                        num_mayor = num[y];
                    }

                    if (num[y] < num_menor)
                    {
                        num_menor = num[y];
                    }

                }
                sum_mayor = suma_total - num_menor;
                sum_menor = suma_total - num_mayor;

                string cadena;
                cadena = sum_menor.ToString() + " " + sum_mayor.ToString();
                return cadena;
            }
            else
            {
                return "deve colocar só 5 numeros com 1 espaço entre eles";
            }
           
            
        }//fin del metodo maximo

        [WebMethod]
        public string quase_ordenado(string tam, string dados)
        {
            string dado = dados;
            char[] delimitador = { ' ' };
            string[] trozos = dado.Split(delimitador);
            int y = 0;

            int tama = Convert.ToInt32(tam);
            int[] vector = new int[tama];
            int i = 0, tag = 1;
          
            if (tama == trozos.Length) {

                for (i = 0; i < vector.Length; i++)
                {
                    vector[i] = Convert.ToInt32(trozos[i]);
                }



                //otro arreglo para compara si hay un repetido
                int saber=0;
                for (i = 0; i < vector.Length; i++)
                {
                    int aux=  repeticiones(vector[i], vector);
                    if (aux >= 2)
                    {
                        saber = 1;
                    }
                }



                    if ( saber==0) { 
                    if (tama >= 2 && tama < 100000) {


                        /*  return k.ToString();*/


                        i = 0;
                        while (i < tama - 1 && tag == 1)
                        {
                            if (vector[i] > vector[i + 1])
                            {
                                tag = 0;
                            }
                            i++;
                        }

                        if (tag == 1)
                        { return "Os elementos ja estão ordenados"; }
                        else
                        {/* return "vvvvvvLos elementos del vector no estan ordenados de modo creciente";*/



                            int[] aux = new int[tama];
                            for (i = 0; i < tama; i++)
                            {
                                aux[i] = vector[i];
                            }
                            // ordeno para luego comparara
                            for (i = 0; i < tama; i++) {
                                for (int j = 0; j < tama - 1; j++) {
                                    if (aux[j] > aux[j + 1])
                                    {
                                        int auxit = aux[j];
                                        aux[j] = aux[j + 1];
                                        aux[j + 1] = auxit;
                                    }
                                }
                            }
                            //comparo
                            eti = 0; band = 0; int num3;
                            cont = 0; int band2 = 0;
                            for (i = 0; i < tama /*vector.Length*/; i++) {
                                if (aux[i] != vector[i])
                                {
                                    if (band2 != 7 && band == 7)
                                    {
                                        num3 = aux[i]; band2 = 7;
                                    }

                                    if (band != 7 && eti == 7)
                                    {
                                        num2 = aux[i]; band = 7;
                                        //tengo ganas de hacer un return aqui
                                    }

                                    if (eti != 7)
                                    {
                                        num1 = aux[i]; eti = 7;

                                    }

                                    /* cont++;*/

                                }

                            }
                            /* return cont.ToString();*/
                            if (eti == 7 && band == 7 && band2 == 0)
                            {
                                return "swap " + num1.ToString() + " " + num2.ToString() + " ";
                            }
                            else
                            {/*return "ultimo caso-----------------------------------------------------------------------";*/



                                int[] nuevo = new int[vector.Length];
                                int th = 0; int tamanho = 0; int suma = 0;
                                for (i = 0; i < (vector.Length - 1); i++)
                                {
                                    if (vector[i] > vector[i + 1] && fechar != 7)
                                    {   //llenar arreglo
                                        nuevo[th] = vector[i];

                                        if (candado != 7)
                                        {
                                            num1 = vector[i];
                                            pot1 = i; candado = 7;
                                        }

                                        nuF = vector[i + 1];
                                        posU = i + 1;

                                        th++;

                                        suma += vector[i];
                                    }

                                    if (vector[i] < vector[i + 1] && candado == 7)
                                    {
                                        fechar = 7;
                                    }
                                }

                                //ingreso numero dinal al arreglo nuevo
                                nuevo[th] = nuF;
                                suma = 0;
                                int dim = th + 1;

                                //como es arreglo es mas ancho hago uno a las medida 
                                int[] array = new int[dim];
                                for (int j = 0; j < dim; j++)
                                {
                                    array[j] = nuevo[j];

                                }
                                // le doy la vuelta al array
                                array = array.Reverse().ToArray();

                                //introduzco el subconjunto en el arreglo
                                /* int l =0; int act = 0;
                                 for (i = 0; i < (vector.Length - 1); i++)
                                 {
                                     if (act < 2)
                                     {
                                         if (vector[i] > vector[i + 1])
                                         {
                                             vector[i] = array[l];
                                             l++;
                                             act = 1;
                                         }

                                         if (vector[i] < vector[i + 1] && act==1)
                                         {
                                             vector[i] = num1;
                                             act =2;
                                         }
                                     }
                                 }
                                 suma = 0;*/



                                //otra forma

                                candado = 0;
                                for (i = 0; i < (vector.Length - 1); i++)
                                {
                                    if (vector[i] > vector[i + 1] && candado != 7)
                                    { int temp = array.Length + i;
                                        int l = 0;
                                        for (int oy = i; oy < temp; oy++)
                                        {
                                            vector[oy] = array[l];
                                            l++;
                                        }
                                        candado = 7;
                                    }
                                }

                              



                                //revisar si esta ordenado
                                i = 0;
                                tag = 1;
                                while (i < tama - 1 && tag == 1)
                                {
                                    if (vector[i] > vector[i + 1])
                                    {
                                        tag = 0;
                                    }
                                    i++;
                                }

                                if (tag == 1)
                                { return "reverse " + nuF + " " + num1 + " "; }
                                else {

                                    return "não"; }














                            }


                        }//final del primer else cuando la variable no esta lista todavia;


                    } else { return " tem que cumprir essas restrinções  2<=n <= 1000000 <= Di <= 1000000 ";
                    }
                }else { return " nao pode colocar numeros repetidos"; }
            } else { return "não coincide com a quantidade que voce disse que iria introduzir";
                   }


        }//fin del metodo 3


        public int repeticiones(int n, int[] array){

            int repi=0;
            for( i=0; i<array.Length; i++)
            {
                if (n == array[i])
                {
                    repi++;
                }
            }


            return repi;
        }//final del metodo 4
        




    }//fin de la clase

}//fin de todo




