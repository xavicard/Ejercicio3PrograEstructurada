using System;
using System.Runtime.InteropServices;

namespace EjerciciosPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA 1: Suponga que un individuo desea invertir su capital en un banco y desea saber cuánto dinero ganará después de un mes si el banco paga a razón de 2% mensual
            /*
            float capital,interes;
            Console.WriteLine("Ingrese el monto del capital en Bs. a invertir");
            capital = float.Parse(Console.ReadLine());
            interes = capital * 2 / 100;
            Console.WriteLine("El interés que va a ganar después de un mes será Bs. " + interes);
            //FIN PROBLEMA 1*/

            //PROBLEMA 2:Un vendedor recibe su sueldo base mas un 10% extra de comisión por sus ventas, el vendedor desea saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones.
            /*float sueldo_base, venta1, venta2, venta3, ventas, comision;
            Console.WriteLine("Ingrese el sueldo base");
            sueldo_base = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto de la venta 1");
            venta1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto de la venta 2");
            venta2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto de la venta 3");
            venta3 = float.Parse(Console.ReadLine());
            ventas = venta1 + venta2 + venta3;
            comision = ventas * 10 / 100;
            Console.WriteLine("El monto a obtener por comisiones es " + comision);
            Console.WriteLine("El monto total a recibir es " + (comision + sueldo_base));*/
            //FIN PROBLEMA 2

            //PROBLEMA 3:Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuánto deberá pagar finalmente por su compra
            /*float total,monto_a_pagar;
            Console.WriteLine("Ingrese el monto total de la compra");
            total = float.Parse(Console.ReadLine());
            //monto_a_pagar = total - (total * 15 / 100);
            monto_a_pagar = total * 85 / 100;
            Console.WriteLine("El monto a pagar después del descuento es " + monto_a_pagar);*/
            //FIN PROBLEMA 3

            //PROBLEMA 4:Un maestro desea saber qué porcentaje de hombres y mujeres hay en un grupo de estudiantes.
            /*int hombres, mujeres,total;
            float porc_hombres, porc_mujeres;
            Console.WriteLine("Ingrese la cantidad de hombres");
            hombres = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de mujeres");
            mujeres = int.Parse(Console.ReadLine());
            total = hombres + mujeres;
            porc_hombres = 100*hombres / total;
            porc_mujeres = 100*mujeres / total;
            Console.WriteLine("El porcentaje de hombres es " + porc_hombres + "%");
            Console.WriteLine("El porcentaje de hombres es " + porc_mujeres + "%");*/
            //FIN PROBLEMA 4

            //PROBLEMA 5: Un hombre desea saber cuánto dinero se genera por concepto de intereses sobre la cantidad que se tiene en inversión en el banco. El decidirá reinvertir los intereses siempre y cuando estos excedan los Bs. 7000, y en ese caso desea saber cuánto dinero tendrá finalmente en su cuenta.
            /*float inversion, interes,monto_generado;
            Console.WriteLine("Ingrese el monto de inversión");
            inversion = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tasa de interés");
            interes = float.Parse(Console.ReadLine());
            monto_generado = inversion * interes / 100;
            if (monto_generado > 7000)
            {
                Console.WriteLine("Debe reinvertir el monto generado");
                Console.WriteLine("El monto total en la cuenta es " + (inversion + monto_generado));
            }*/
            //FIN PROBLEMA 5

            //PROBLEMA 6:En un almacén se hace un descuento de 20% a los clientes cuya compra supere los Bs. 1000 ¿Cuál será la cantidad que pagará una persona por su compra?
            /*float monto;
            Console.WriteLine("Ingrese el monto de compra");
            monto = float.Parse(Console.ReadLine());
            if(monto>1000)
            {
                monto = monto - (monto * 20 / 100);
                Console.WriteLine("Finalmente pagará Bs. " + monto);
            }
            else
                Console.WriteLine("Finalmente pagará Bs. " + monto);*/
            //FIN PROBLEMA 6

            //PROBLEMA 7: Un obrero necesita calcular su salario semanal, el cual se obtiene la siguiente manera: a.Si trabaja 40 horas o menos se le paga Bs. 16 la hora b.Si trabaja más de 40 horas se le paga Bs. 16 por cada una de las primeras 40 horas y Bs. 20 por cada hora extra
            /*int horas,salario;
            Console.WriteLine("Ingrese el numero de horas trabajadas");
            horas = int.Parse(Console.ReadLine());
            if(horas<=40)
            {
                salario = horas * 16;
            }
            else
            {
                salario = (40 * 16) + ((horas - 40) * 20);
            }
            Console.WriteLine("El salario semanal es " + salario);*/
            //FIN PROBLEMA 7

            //PROBLEMA 8: Una persona enferma, que pesa 70kg, se encuentra en reposo y desea saber cuántas calorías consume su cuerpo durante todo el tiempo que realice una misma actividad. Las actividades que tiene permitido realizar son únicamente dormir o estar sentado en reposo. Los datos que tiene son que estando dormido consume 1.08 calorías por minuto y estando en reposo consume 1.66 calorías por minuto
            /*int minutos_dormido, minutos_reposo;
            double calorias;
            Console.WriteLine("Ingrese el tiempo en minutos que estuvo dormido");
            minutos_dormido = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tiempo en minutos que estuvo en reposo");
            minutos_reposo = int.Parse(Console.ReadLine());
            calorias = (minutos_dormido * 1.08) + (minutos_reposo * 1.66);
            Console.WriteLine("Las calorías consumidas son " + calorias);*/
            //FIN PROBLEMA 8

            //PROBLEMA 9:Leer 2 números; si son iguales que los multiplique, si el primero es mayor que el segundo los reste y sino que los sume.
            /*int n1, n2, resultado;
            Console.WriteLine("Ingrese el primer número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            n2 = int.Parse(Console.ReadLine());
            if(n1==n2)
            {
                resultado = n1 * n2;
            }
            else
            {
                if(n1>n2)
                {
                    resultado = n1 - n2;
                }
                else
                {
                    resultado = n1 + n2;
                }
            }
            Console.WriteLine("El resultado es " + resultado);*/
            //FIN PROBLEMA 9

            //PROBLEMA 10: La AFP requiere clasificar a las personas que se jubilarán en el año de 1997. Existen tres tipos de jubilaciones: por edad, por antigüedad joven y por antigüedad adulta. Las personas adscritas a la jubilación por antigüedad adulta deben tener 60 años o mas y una antigüedad en su empleo de 25 años o mas. Determinar en qué tipo de jubilación quedará adscrita una persona.
            int edad, antiguedad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su antiguedad");
            antiguedad = int.Parse(Console.ReadLine());
            if(edad>=60 && antiguedad>=25)
            {
                Console.WriteLine("Jubilación por antiguedad adulta");
            }
            else
            {
                if (edad >= 60) 
                {
                    Console.WriteLine("Jubilación por edad");
                }
                else
                {
                    if(antiguedad>=25)
                    {
                        Console.WriteLine("Jubilación por antiguedad");
                    }
                    else
                    {
                        Console.WriteLine("Todavía no califica para jubilación");
                    }
                }
            }
            //FIN PROBLEMA 10
        }
    }
}
