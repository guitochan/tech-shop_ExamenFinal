public class tech_shop
{
    public static int capacidadMaxima = 0;

    public static string[] codigoArreglo = new string [20];
    public static string[] productosArreglo = new string [20];
    public static double[] preciosArreglo = new double [20];
    public static int[] stockArreglo = new int[20];

    public static void Main(String [] args)
    {
        int opcion;
        while(true)
        {
            MostrarMenu();
            opcion=LeerOpcion();

            switch(opcion)
            {
                case 1:
                    RegistrarProducto();
                    break;
                case 2:
                    MostrarCatalogo();
                    break;
                case 3:
                    //BuscarProductoxCodigo();
                    break;
                case 4:
                    //ActualizarStock();
                    break;
                case 5:
                    //OrdenarCatalogoxPrecio();
                    break;
                case 6:
                    //InsertarProductoxPosicionEspecifica();
                    break;
                case 7:
                    //EliminarProductoxCodigo();
                    break;
                case 8:
                    //OrdenarCatalogoAlfabeticamente();
                    break;
                case 9:
                    //ValorVsReferencia();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa... ");
                    return;
            }
        }
    }

    public static void MostrarMenu()
    {
        Console.WriteLine("\n=============================================================");
        Console.WriteLine("======================== TECH - SHOP ========================");
        Console.WriteLine("=================== SISTEMA DE CATALOGOS ====================");
        Console.WriteLine("=============================================================");
        Console.WriteLine("1. Registrar un producto");
        Console.WriteLine("2. Mostrar el catalogo completo");
        Console.WriteLine("3. Buscar un producto por codigo");
        Console.WriteLine("4. Actualizar el stock");
        Console.WriteLine("5. Ordenar el catalogo por precio");
        Console.WriteLine("6. Insertar un producto en una posicion especifica");
        Console.WriteLine("7. Eliminar un producto por codigo");
        Console.WriteLine("8. Ordenar el catalogo por nombre");
        Console.WriteLine("9. Demostracion: Parametro por valor vs. por referencia");
        Console.WriteLine("0. Salir del programa");
        Console.WriteLine("=============================================================");
    }

    public static int LeerOpcion()
    {
        int opcion;
        bool esValido = true;

        do
        {
            Console.WriteLine("Ingrese una opcion: ");

            esValido = int.TryParse(Console.ReadLine(), out opcion);

            if(!esValido)
            {
                Console.WriteLine("Error: Debe ingresar un numero entero");
            }

            if(opcion < 0 || opcion > 9)
            {
                Console.WriteLine("Error: Debe ingresar un numero entre 0 y 9");
                esValido = false;
            }
        } while(!esValido);

        return opcion;
    }

    public static bool ProductoEsValido(string _codigo, string _nombre, double _precio , int _stock)
    {
        if (_codigo == "")
        {
            Console.WriteLine("Codigo vacio. Ingresar un codigo.");
            return false;
        }
        for(int i = 0; i < 20; i++)
        {
            if (codigoArreglo[i] == _codigo)
            {
                Console.WriteLine("Codigo repetido. Ingresar un codigo unico.");
                return false;
            }
        }

        if(_nombre == "")
        {
            Console.WriteLine("Nombre de producto vacio. Ingresar un nombre para el producto.");
            return false;
        }
        for(int i = 0; i < 20; i++)
        {
            if (productosArreglo[i] == _nombre)
            {
                Console.WriteLine("Producto duplicado. Ingresar un producto distinto.");
                return false;
            }
        }

        if(_precio <= 0)
        {
            Console.WriteLine("Debe ingresar un valor para el precio mayor de 0.");
            return false;
        }

        if(_stock < 0)
        {
            Console.WriteLine("Debe ingresar un valor para el stock mayor o igual de 0.");
            return false;
        }

        return true;
    }

    public static void RegistrarProducto()
    {
        string codigo = "", nombre = "";
        double precio = 0.00;
        int stock = 0;

        if(capacidadMaxima >= 20)
        {
            Console.WriteLine("No se pueden registrar mas productos. Capacidad maxima alcanzada.");
        }

        do
        {
            Console.WriteLine("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            
            Console.WriteLine("Ingrese el nombre del producto: ");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Ingrese el precio del producto: ");
            precio = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el stock del producto: ");
            stock = int.Parse(Console.ReadLine());
            
        } while(ProductoEsValido(codigo, nombre, precio, stock) == false);


        codigoArreglo[capacidadMaxima] = codigo;
        productosArreglo[capacidadMaxima] = nombre;
        preciosArreglo[capacidadMaxima] = precio;
        stockArreglo[capacidadMaxima] = stock;

        capacidadMaxima++;
    }
    
    public static void MostrarCatalogo()
    {
        Console.WriteLine("\n                   CATALOGO DE PRODUCTOS                  ");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("|   Codigo   |   Producto        |  Precio      |  Stock  |");
        Console.WriteLine("-----------------------------------------------------------");
        
        if(capacidadMaxima == 0)
        {
            Console.WriteLine("|-------------- NO HAY PRODUCTOS REGISTRADOS -------------|");
        }
        else
        {
            for(int i=0; i < capacidadMaxima; i++){
                Console.WriteLine($"| {codigoArreglo[i], -10} | {productosArreglo[i], -17} | S/ {preciosArreglo[i], -8}  | {stockArreglo[i], -8}|");
            }
        }
    }
}