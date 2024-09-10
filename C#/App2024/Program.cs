using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App2024
{
    class Program
    {
        public static string nombreAPP = "";
        static void Main(string[] args)
        {

            // PROGRAMA ESTRUCTURADO

            #region TIPOS DE VARIABLES

            //VARIABLES DE TIPO PRIMITIVO//

            // Números enteros
            int numeroEntero = 42;
            long numeroGrande = 12345678901234L;
            byte numeroPequeno = 255;

            // Números de punto flotante
            float numeroDecimal = 3.14f;
            double numeroDouble = 2.718281828459;
            decimal numeroFinanciero = 1000.50m;

            // Tipo de carácter
            char letra = 'A';
            // Tipo booleano
            bool esVerdadero = true;
            // Tipo de cadena
            string saludo = "Hola, Mundo!";


            // TIPO DE DATO NO PRIMITIVO VARIABLES

            int[] numeros = { 1, 2, 3, 4, 5 };

            string[] animales = { "Gato","Perro","Jirafa" };

            object[] cajaSorpersa = { "Animales", 45.12, 147 };

            // Tipo de Dato no primirivo Listas

           /* List<Persona> ltsEstudiantes = new List<Persona> {
            
            new Persona () { Edad = 25, Nombre = "Luis" },
            new Persona () { Edad = 26, Nombre = "Alejandro" },
            new Persona () { Edad = 31, Nombre = "Carlos" },
            new Persona () { Edad = 56, Nombre = "Maria" }           
            
            };*/

            Dictionary<int, string> diccionarioDepartamentos = new Dictionary<int, string>
            {
                  { 1, "Usulutan" },
                  { 3, "San Miguel" },
                  { 4, "La Paz" }
            };



            //Tipo de Dato no Primitivo Variable multiple

            var tupla = Tuple.Create(1, "Hola", true);

            var tuplaPersona = new Tuple<string, string, int>("Alejandro","GerardoBarrios",2024);



            // Tipo de Dato no primirivo Variables Dinamicas
            var nombre = "Alejandro";
            var precioProducto = 15.45;

            dynamic stock = 45;


            /*CONTENEDORES DE DATOS*/

            //DATATABLES y DATASETS

            #endregion

            //COMENTARIO DE UNA LINEA

            /* COMENTARIOS
             DE
            VARIAS LINEAS */

            #region ESTRUCTURAS DE CONTROL

            //CONDICION TERNARIO PENDIENTE

            /* var dia = 1; //Asignacion de valores
             var edad = 18; //Asignacion de valores

             int a = 5;
             int b = 10;
             Console.WriteLine(a == b);  
             Console.WriteLine(a != b); 
             Console.WriteLine(a > b);   
             Console.WriteLine(a < b);  
             Console.WriteLine(a >= b);  
             Console.WriteLine(a <= b);  


             bool x = true;
             bool y = false;

             Console.WriteLine(x && y);  
             Console.WriteLine(x || y);  
             Console.WriteLine(!x);      

             if (edad == 18) // Comparacion
             {
                 Console.WriteLine("ES MAYOR DE EDAD");
             }
             else if (edad < 18) {
                 Console.WriteLine("ES MENOR DE EDAD");
             }

              else if (edad < 0) {
                 Console.WriteLine("ERROR VALOR FUERA DE RANGO");
             }

             else if (edad > 180)
             {
                 Console.WriteLine("ERROR VALOR FUERA DE RANGO");
             }

             switch (dia)
             {
                 case 1:
                     Console.WriteLine("LUNES");
                     break; 

                 case 2: 
                     Console.WriteLine("MARTES");
                     break;

                 case 3: 
                     Console.WriteLine("MIERCOLES");
                     break;

                 default:
                     Console.WriteLine("DIA ERRONEO");
                     break;
             }


             var nombreBD = "";
             if (!string.IsNullOrEmpty(nombreBD))
             {
                 nombreBD.ToUpper();

             }
            */

            //Console.ReadKey();


            #endregion

            var nombreVal = "manuel";
            var edadVal = 13;
            //var resultadoFuncion = crearCodigo(nombreVal);

            #region TIPOS DE IMPRESION

            //INTERPOLACION PENDIENTE
            var nombreCompleto = $"Mi nombre es {nombreVal}";
            var nombreCompleto2 = string.Format("Mi nombre es {0} , y mi edad es {1}" , nombreVal, edadVal);

            #endregion

            #region ESTRUCTURAS DE CONTROL ITERATIVAS

            // INICIALIZADOR , CONDICION , ASIGNACION COMPUESTA

            var num = 5;
            var counter = 0;

            /* for (int i = 1; i <= 10; i++)
             {
                 // 5 * 2 = 10 

                 var resultado = num + " X " + i + " = " + (num * i);

                 Console.WriteLine(resultado);

             }

             Console.ReadKey();
            */

            /* while (counter <= 10) {

                 counter ++ ;

                 var resultado = num + " X " + counter + " = " + (num * counter);

                 Console.WriteLine(resultado);


             }*/

            /*INTERACTUANDO CON VARIABLES COMPUESTAS*/


            /* string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

             for (int i = 0; i < cars.Length; i++)
             { 

             Console.Write($"EL VALOR DE LA POSICION : [ {i} ] =  {cars[i].ToString().ToUpper()} \n");

             }*/


            //TUPLAS
            //LISTAS
            //DICCIONARIOS


            /*  
               
               var tupla = Tuple.Create(1, "Hola", true);
               var tuplaPersona = new Tuple<string, string, int>("Alejandro", "GerardoBarrios", 2024);
         
               List<Persona> ltsEstudiantes = new List<Persona> {

               new Persona () { Edad = 25, Nombre = "Luis" },
               new Persona () { Edad = 26, Nombre = "Alejandro" },
               new Persona () { Edad = 31, Nombre = "Carlos" },
               new Persona () { Edad = 56, Nombre = "Maria" }

               };

               Dictionary<int, string> diccionarioDepartamentos = new Dictionary<int, string>
               {
                     { 1, "Usulutan" },
                     { 3, "San Miguel" },
                     { 4, "La Paz" }
               };


               */


            /*  List<Tuple<string, int>> ltsDiasSemana = new List<Tuple<string, int>>()
              {
                  new Tuple<string, int>("Lunes", 1),
                  new Tuple<string, int>("Martes", 2),
                  new Tuple<string, int>("Miercoles", 3),
                  new Tuple<string, int>("Jueves", 4),
                  new Tuple<string, int>("Viernes", 5),
                  new Tuple<string, int>("Sabado", 6),
                  new Tuple<string, int>("Domingo", 7),

              };


              foreach (var chuchito in ltsDiasSemana)
              {
                  Console.Write($"Dia de semana {chuchito.Item1} su numero es : {chuchito.Item2} \n  ");
              }*/


            // POO
            //CLASES 

            /*INSTANCIA DE CLASES*/


            List<Persona> persons = new List<Persona>()
            {

                 new Persona { Nombre = "Luis", FechaNacimient = new DateTime(1990, 5, 15),Direccion = "Jucuapa"},
                 new Persona { Nombre = "Alejandro", FechaNacimient = new DateTime(1995, 5, 15),Direccion = "San Miguel"},
                 new Persona { Nombre = "Carlos", FechaNacimient = new DateTime(1992, 5, 15),Direccion = "San Miguel"},
                 new Persona { Nombre = "Arturo", FechaNacimient = new DateTime(1998, 5, 15),Direccion = "Anamoros"}

            };


            /*   foreach (Persona person in persons)
           {

               if (person.Nombre == "Carlos") {

                   Console.WriteLine($" Nombre : {person.Nombre.ToUpper()} Direccion : {person.Direccion} ");

               }

           }*/

            //LAMDA
            var result = persons.AsEnumerable().Where(x => x.Nombre == "Carlos").FirstOrDefault();
            Console.WriteLine($" Nombre : {result.Nombre.ToUpper()} Direccion : {result.Direccion} ");




            /*
                Persona persona = new Persona
            {
                Nombre = "John Doe",
                FechaNacimient = new DateTime(1990, 5, 15)
            };

            // Print Persona details
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Fecha de Nacimiento: {persona.FechaNacimient.ToShortDateString()}");

            // Create an instance of TarjetaDebito
            Persona.TarjetaDebito tarjeta = new Persona.TarjetaDebito("1234-5678-9876-5432")
            {
                FechaVencimiento = "12/2025",
                Codigo = "123",
                Status = true
            };

            // Print TarjetaDebito details
            Console.WriteLine($"Numero de Tarjeta: {tarjeta.NumeroTarjeta}");
            Console.WriteLine($"Fecha de Vencimiento: {tarjeta.FechaVencimiento}");
            Console.WriteLine($"Codigo: {tarjeta.Codigo}");
            Console.WriteLine($"Status: {(tarjeta.Status ? "Activo" : "Inactivo")}");*/


        Console.ReadKey();

            #endregion


            /*  Console.WriteLine("PRIMERA IMPRESION DE NOMBRE :" + nombreAPP);
              modificarNombre();
              Console.WriteLine("PRIMERA IMPRESION DE NOMBRE :" + nombreAPP);
              Console.ReadKey();
            */
        }

        #region FUNCIONES

        /*PUBLIC or PRIVATE*/

        // FUNCION CON PARAMETROS
        // FUNCION CON RETORNO
        public static string crearCodigo(string nombre)  
        {
            var result = nombre.ToUpper() + "_" + DateTime.Now.Year + "-" + "0651635169851";
            return result;
        }

        // FUNCION SIN PARAMETROS
        // FUNCION CON RETORNO
        public static int anioActual()
        {
            var result = DateTime.Now.Year;
            return result;
        }

        // FUNCION SIN RETORNO
        public static void modificarNombre()
        {
            nombreAPP = "MIAPP.COM";
        }

        #endregion


       

    }

    //VARIABLES DE TIPO NO PRIMITIVO [OBJETO]//
    public class Persona   // public class nombre_clase
    {
        public string Nombre { get; set; } // Propiedades
        public DateTime FechaNacimient { get; set; }

        public string Direccion { get; set; }

        public void dormir() { } // Metodos

       public class TarjetaDebito {

        public TarjetaDebito(string numeroTarjeta)
        {
            NumeroTarjeta = numeroTarjeta; 
        }

            public string NumeroTarjeta { get; set; }
            public string FechaVencimiento { get; set; }
            public string Codigo { get; set; }            
            public bool Status { get; set; }
        
        }

    }

    /*
    public class Trabajador 
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public interface Modales
    {
        void SaludarAlLLegar();
        void SaludarAlDespedirme();
    }

    */
}
