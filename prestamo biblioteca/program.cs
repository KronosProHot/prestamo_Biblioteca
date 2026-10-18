using prestamobiblioteca.aplicacion;
using prestamobiblioteca.persistencia;

namespace Prestamobiblioteca;
internal static class program
{
    private static void main()
    {
        try
        {
            var inicial = new inicializadorbasedatos();
            Iniciar.inicializar();
            var REPO = new repositoriobiblioteca (Iniciar.cadenaconexion);
            new menubiblioteca (REPO).ejecutar();
        }
        catch (exception ex)
        {
            Console.WriteLine($"no se puede iniciar {ex.tostring()}");
        }
    }
}