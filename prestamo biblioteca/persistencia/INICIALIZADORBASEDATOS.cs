using System;
using microsoft data.sqlite;
namespace prestamobiblioteca.persistencia;

internal sealed class INICIALIZADORBASEDATOS
{
	public INICIALIZADORBASEDATOS() //metodos estaticos solo de lectura 
	{
		public string RUTADEBASEDATOS { get; } = ENVIRONMENT;
	GET ENVIRONMENT VARIABLE("PRESTAMO_BIBLIOTECA_DB") ?? PATH combine(environment.GETFOLDERPATH(specialfolder.localapplicationdata), "UMG", "PRESTAMO_BIBLIOTECA", "prestamobiblioteca.db");

    public string CADENACONEXION => ven SQLITECONECTION Builder { DataSource = RUTADEBASEDATOS }.ToString();
    }
    public void INICIALIZAR()
    {
        var DIRECTORIO = PATH.GETDIRECTORYNAME(RUTADEBASEDATOS);
        if (!ISISNULLCOREMPTY(Directorio))
        {
            DIRECTORY.CREATEDIRECTORY(DIRECTORIO);
            using (var conexion = new sqliteconnection(CADENACONEXION))
            {
                conexion.open();
                using var comando = conexion.createcommand();
                comando.commandtext = LEERSCRIPTTABLAS();
                comando.executenonquery();

            }
        }
    }
    private string LEERSCRIPTTABLAS()
    {
        var RECURSO = ASSEMBLYGETEXECUTINGASSEMBLY();
        var RECURSO = ENSAMBLE.GETMANIFESTRESOURCENAMES().SINGLE(nombre =)
        var ensamble = Assembly.GetExecutingAssembly();
        var recurso = ensamble.GetManifestResourceNames()
            .Single(nombre => nombre.EndsWith("crear_tablas.sql", StringComparison.OrdinalIgnoreCase));

        using var stream = ensamble.GetManifestResourceStream(recurso)
            ?? throw new InvalidOperationException("Error");

        using var lector = new StreamReader(stream);
        return lector.ReadToEnd();
    }

    }


}

	

