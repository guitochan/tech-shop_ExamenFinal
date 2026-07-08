public class tech_shop
{
    public static void Main(String [] args)
    {
        int opcion;

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
                BuscarProductoxCodigo();
                break;
            case 4:
                ActualizarStock();
                break;
            case 5:
                OrdenarCatalogoxPrecio();
                break;
            case 6:
                InsertarProductoxPosicionEspecifica();
                break;
            case 7:
                EliminarProductoxCodigo();
                break;
            case 8:
                OrdenarCatalogoAlfabeticamente();
                break;
            case 9:
                ValorVsReferencia();
                break;
            case 0:
                Console.WriteLine("Saliendo del programa... ");
                break;
        }

    }

    public static void MostrarMenu()
    {
        Console.WriteLine("=============================================================");
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

    public static void MostrarCatalogo()
    {
        Console.WriteLine("\nCatalogo de Productos");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("|   Producto        |  Precio      |  Stock  |");
        Console.WriteLine("----------------------------------------------");
        
        for(int i=0; i < productos.Length; i++){
            Console.WriteLine($"| {productos[i], -17} | S/ {precios[i], -8}  | {stock[i], -8}|");
        }
    }
}