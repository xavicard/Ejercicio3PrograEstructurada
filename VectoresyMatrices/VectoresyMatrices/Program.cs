using System;

namespace VectoresyMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA 1: Generar los primeros n pares, guardarlos en un vector y mostrarlos
            /* int[] vector = new int[100];
             int i,n,par=2;
             Console.WriteLine("Ingrese N");
             n = int.Parse(Console.ReadLine());
             for(i=0;i<n;i++)
             {
                 vector[i] = par;
                 par += 2;
             }
             for(i=0;i<n;i++)
             {
                 Console.WriteLine(vector[i]);
             }
             //FIN PROBLEMA

             //PROBLEMA 2: Almacenar los n sueldos del personal y determinar cuanto es el total a pagar
             double[] vector = new double[100];
             double total=0.0,mayor=0.0;
             int i,n;
             Console.WriteLine("Ingrese N");
             n = int.Parse(Console.ReadLine());
             for(i=0;i<n;i++)
             {
                 Console.WriteLine("Ingrese el sueldo del trabajador:");
                 vector[i] = double.Parse(Console.ReadLine());
             }
             for (i = 0; i < n; i++)
             {
                 if (mayor < vector[i])
                 {
                     mayor = vector[i];
                 }
                 total += vector[i];
             }
             Console.WriteLine("El total de sueldos a pagar es " + total);
             Console.WriteLine("El mayor de los sueldos es " + mayor);
             //FIN PROBLEMA

             //PROBLEMA 3: Generar la matriz unitaria
             int[,] m_unitaria = new int[100, 100];
             int fila,columna,n;
             Console.WriteLine("Ingrese la dimensión de la matriz unitaria a utilizar:");
             n = int.Parse(Console.ReadLine());
             for (fila = 0; fila < n; fila++)
             {
                 for (columna = 0; columna < n; columna++)
                 {
                     if(fila==columna)
                     {
                         m_unitaria[fila, columna] = 1;
                     }
                     else
                     {
                         m_unitaria[fila, columna] = 0;
                     }
                 }
             }
             Console.WriteLine("Matriz Unitaria:");
             for (fila=0;fila<n;fila++)
             {
                 for (columna = 0; columna < n; columna++)
                     Console.WriteLine("matriz[" + fila + "," + columna + "]:" + m_unitaria[fila, columna]);
             }
            //FIN PROBEMA

            //PROBLEMA 4: Leer una matriz A de orden MxN y un numero K. Multiplicar todos los elementos de la matriz por el número K. Mostrar la matriz resultante
            int[,] a = new int[100, 100];
            int i,j,m,n,k;
                //ENTRADA DE DATOS
            Console.WriteLine("Ingrese el tamaño de la fila (M):");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño de la columna (N):");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < m; i++)
            {
                for(j=0;j<n;j++)
                {
                    Console.WriteLine("Ingrese la celda "+i+","+j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingrese el número K:");
            k = int.Parse(Console.ReadLine());
                //PROCESO (MULTIPLICAR K * CADA CELDA)
            for(i=0;i<m;i++)
            {
                for (j = 0; j < n; j++)
                {
                    a[i, j] = k * a[i, j];
                }
            }
                //SALIDA
            for (i = 0; i < m; i++)
            {
                for(j=0;j<n;j++)
                {
                    Console.WriteLine("A["+i+","+j+"]: "+a[i,j]);
                }
            }*/
            //FIN PROBLEMA

            //PROBLEMA 5:Leer una matriz C de orden P (matriz cuadrada). Mostrar los elementos de la diagonal principal, secundaria, de la matriz triangular superior y de la matriz triangular inferior.
            int[,] c = new int[100, 100];
            int p,fila,columna;
            //ENTRADA
            Console.WriteLine("Ingrese el tamaño de la matriz");
            p = int.Parse(Console.ReadLine());
            for(fila=0;fila<p;fila++)
            {
                for(columna=0;columna<p;columna++)
                {
                    Console.WriteLine("Ingrese la celda " + fila + "," + columna);
                    c[fila, columna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La diagonal principal es:");
            for (fila = 0; fila < p; fila++)
            {
                for (columna = 0; columna < p; columna++)
                {
                    if (fila == columna)
                        Console.WriteLine(c[fila, columna]+",");
                }
            }
            Console.WriteLine("La diagonal secundaria es:");
            for(fila=0;fila<p;fila++)
            {
                Console.WriteLine(c[fila, p - 1 - fila] + ",");
            }
            Console.WriteLine("La matriz triangular superior es:");
            for (fila=0;fila<p;fila++)
            {
                for(columna=0;columna<p;columna++)
                {
                    if(fila<columna)
                    {
                        Console.WriteLine(c[fila, columna] + ",");
                    }
                }
            }
            Console.WriteLine("La matriz triangular inferior es:");
            for (fila = 0; fila < p; fila++)
            {
                for (columna = 0; columna < p; columna++)
                {
                    if (fila > columna)
                    {
                        Console.WriteLine(c[fila, columna] + ",");
                    }
                }
            }
            //FIN PROBLEMA
        }
    }
}
