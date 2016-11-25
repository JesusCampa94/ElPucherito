
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using GgesGenNHibernate.EN.Gges;
using GgesGenNHibernate.CEN.Gges;
using GgesGenNHibernate.CAD.Gges;
using GgesGenNHibernate.CP.Gges;


/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes


                #region Usuarios

                UsuarioCAD usuarioCAD = new UsuarioCAD();
                UsuarioCEN usuarioCEN = new UsuarioCEN(usuarioCAD);
                UsuarioEN usuarioEN = null;

                #region Usuario 1

                usuarioEN = new UsuarioEN();

                usuarioEN.Nick = "pep";
                usuarioEN.Pass = "123";
                usuarioEN.Nombre = "Pepe";
                usuarioEN.Apellidos = "Pina";
                usuarioEN.Correo = "pepe@cosa.com";
                usuarioEN.FechaNa = new DateTime(2010, 5, 12);
                usuarioEN.Sexo = 1; //supondremos que el 1 es hombre
                usuarioEN.Pais = "Wonderland";
                usuarioEN.Provincia = "Pulgarcity";
                usuarioEN.Imagen = "imagen.jpg";
                usuarioEN.Baneado = false;

                usuarioCAD.CrearUsuario(usuarioEN);

                if (usuarioCEN.Login(usuarioEN.Nick, usuarioEN.Pass))
                    Console.WriteLine(usuarioEN.Nick + " logueado.");

                UsuarioCP usuCP = new UsuarioCP();
                usuCP.HacerAdmin("pep");

                usuarioEN = null;

                #endregion

                #region Usuario 2

                usuarioEN = new UsuarioEN();

                usuarioEN.Nick = "yisus";
                usuarioEN.Pass = "cawendie";
                usuarioEN.Nombre = "Jesus";
                usuarioEN.Apellidos = "Fernandez";
                usuarioEN.Correo = "jfv10@alu.ua.es";
                usuarioEN.FechaNa = new DateTime(1994, 5, 29);
                usuarioEN.Sexo = 1; //supondremos que el 1 es hombre
                usuarioEN.Pais = "España";
                usuarioEN.Provincia = "Alicante";
                usuarioEN.Imagen = "imagen.jpg";
                usuarioEN.Baneado = false;

                usuarioCAD.CrearUsuario(usuarioEN);

                if (usuarioCEN.Login(usuarioEN.Nick, usuarioEN.Pass))
                    Console.WriteLine(usuarioEN.Nick + " logueado.");

                usuarioEN = null;

                #endregion

                #region Usuario 3

                usuarioEN = new UsuarioEN();

                usuarioEN.Nick = "maermka";
                usuarioEN.Pass = "odioelmundo";
                usuarioEN.Nombre = "Manuel";
                usuarioEN.Apellidos = "Quirante";
                usuarioEN.Correo = "mqa6@alu.ua.es";
                usuarioEN.FechaNa = new DateTime(1995, 7, 8);
                usuarioEN.Sexo = 1; //supondremos que el 1 es hombre
                usuarioEN.Pais = "Mundo Feliz";
                usuarioEN.Provincia = "Alegria";
                usuarioEN.Imagen = "imagen.jpg";
                usuarioEN.Baneado = false;

                usuarioCAD.CrearUsuario(usuarioEN);
                if (usuarioCEN.Login(usuarioEN.Nick, usuarioEN.Pass))
                    Console.WriteLine(usuarioEN.Nick + " logueado.");

                usuarioEN = null;

                #endregion

                #region Usuario 4

                usuarioEN = new UsuarioEN();

                usuarioEN.Nick = "kyou";
                usuarioEN.Pass = "50zanahorias";
                usuarioEN.Nombre = "Sus";
                usuarioEN.Apellidos = "Valiente";
                usuarioEN.Correo = "jvg26@alu.ua.es";
                usuarioEN.FechaNa = new DateTime(1992, 9, 14);
                usuarioEN.Sexo = 1; //supondremos que el 1 es hombre
                usuarioEN.Pais = "Japon";
                usuarioEN.Provincia = "Shibuya";
                usuarioEN.Imagen = "imagen.jpg";
                usuarioEN.Baneado = false;

                usuarioCAD.CrearUsuario(usuarioEN);
                if (usuarioCEN.Login(usuarioEN.Nick, usuarioEN.Pass))
                    Console.WriteLine(usuarioEN.Nick + " logueado.");

                usuarioEN = null;

                #endregion

                #region Usuario 5

                usuarioEN = new UsuarioEN();

                usuarioEN.Nick = "jesucristo";
                usuarioEN.Pass = "hallelujah";
                usuarioEN.Nombre = "Thomas";
                usuarioEN.Apellidos = "Cafaro";
                usuarioEN.Correo = "ggsus@heaven.com";
                usuarioEN.FechaNa = new DateTime(1996, 9, 30);
                usuarioEN.Sexo = 1; //supondremos que el 1 es hombre
                usuarioEN.Pais = "Il Vaticano";
                usuarioEN.Provincia = "Vaticano";
                usuarioEN.Imagen = "imagen.jpg";
                usuarioEN.Baneado = false;

                usuarioCAD.CrearUsuario(usuarioEN);
                if (usuarioCEN.Login(usuarioEN.Nick, usuarioEN.Pass))
                    Console.WriteLine(usuarioEN.Nick + " logueado.");

                usuarioEN = null;

                #endregion

                #region Administrador 

                AdministradorCAD adminCAD = new AdministradorCAD();
                AdministradorCEN adminCEN = new AdministradorCEN(adminCAD);
                AdministradorEN adminEN = new AdministradorEN();

                adminEN.Nick = "Admin";
                adminEN.Pass = "123";
                adminEN.Nombre = "Juanito";
                adminEN.Apellidos = "Valdemoros";
                adminEN.Correo = "juanito@overlord.com";
                adminEN.FechaNa = new DateTime(1974, 2, 4);
                adminEN.Sexo = 1; //supondremos que el 1 es hombre
                adminEN.Pais = "Wonderland";
                adminEN.Provincia = "Pulgarcity";
                adminEN.Imagen = "imagen.jpg";
                adminEN.Baneado = false;

                adminCAD.CrearAdministrador(adminEN);

                Console.WriteLine("CREANDO ADMIN");
                Console.WriteLine(adminEN.Nick);
                Console.WriteLine(adminEN.Nombre);

                AdministradorCP adminCP = new AdministradorCP();
                UsuarioEN usuParaBanear = usuarioCAD.ReadOIDDefault("pep");
                Console.WriteLine(usuParaBanear.Nick + " esta baneado: " + usuParaBanear.Baneado);
                Console.WriteLine("Baneando a " + usuParaBanear.Nick + "...");
                adminCP.BanearUsuario("pep");

                #endregion

                #endregion

                #region Publicaciones

                PublicacionCAD publicacionCAD = new PublicacionCAD();
                PublicacionCEN publicacionCEN = new PublicacionCEN(publicacionCAD);

                System.Collections.Generic.List<int> publicacionesOID = new List<int>();

                System.Collections.Generic.List<string> listaEtiquetas1 = new List<string>();
                listaEtiquetas1.Add("genial");
                listaEtiquetas1.Add("gracioso");
                listaEtiquetas1.Add("epico");
                listaEtiquetas1.Add("delicioso");
                listaEtiquetas1.Add("original");

                System.Collections.Generic.List<string> listaEtiquetas2 = new List<string>();
                listaEtiquetas2.Add("fantasmagorico");
                listaEtiquetas2.Add("dantesco");
                listaEtiquetas2.Add("grotesco");
                listaEtiquetas2.Add("espeluznante");
                listaEtiquetas2.Add("horrible");

                //Para ir iterando por las publicaciones
                int indexPubli = -1;

                #region Recetas

                RecetaCAD recetaCAD = new RecetaCAD();
                RecetaCEN recetaCEN = new RecetaCEN(recetaCAD);
                RecetaEN recetaEN = null;

                #region Ingredientes

                System.Collections.Generic.List<IngredientesEN> listaIngredientes1 = new List<IngredientesEN>();
                System.Collections.Generic.List<IngredientesEN> listaIngredientes2 = new List<IngredientesEN>();
                System.Collections.Generic.List<IngredientesEN> listaIngredientes3 = new List<IngredientesEN>();

                IngredientesCAD ingredientesCAD = new IngredientesCAD();
                IngredientesCEN ingredientesCEN = new IngredientesCEN(ingredientesCAD);
                IngredientesEN ingredientesEN = new IngredientesEN();


                ingredientesEN.Nombre = "Salchichas";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)4;
                listaIngredientes1.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Patatas fritas";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)2;
                listaIngredientes1.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Ketchup";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)1;
                listaIngredientes1.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Fresas";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)1;
                listaIngredientes2.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Chocolate";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)7;
                listaIngredientes2.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Nata";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)7;
                listaIngredientes2.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Lentejas";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)6;
                listaIngredientes3.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Garbanzos";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)6;
                listaIngredientes3.Add(ingredientesEN);
                ingredientesEN = null;

                ingredientesEN = new IngredientesEN();
                ingredientesEN.Nombre = "Arroz";
                ingredientesEN.Tipo = (GgesGenNHibernate.Enumerated.Gges.TipoIngredienteEnum)5;
                listaIngredientes3.Add(ingredientesEN);
                ingredientesEN = null;

                #endregion

                #region Receta 1

                recetaEN = new RecetaEN();

                recetaEN.Titulo = "Receta 1";
                recetaEN.Etiquetas = listaEtiquetas1;
                recetaEN.FechaCrea = System.DateTime.Now;
                recetaEN.Contenido = "Contenido de receta 1";
                recetaEN.Likes = 2;
                recetaEN.Visualizaciones = 30;
                recetaEN.Ingredientes = listaIngredientes1;
                recetaEN.Usuario = usuarioCAD.ReadOIDDefault("pep");

                publicacionesOID.Add(recetaCAD.CrearReceta(recetaEN));
                publicacionCEN.DarLike(publicacionesOID[++indexPubli]);

                recetaEN = null;

                #endregion

                #region Receta 2

                recetaEN = new RecetaEN();

                recetaEN.Titulo = "Receta 2";
                recetaEN.Etiquetas = listaEtiquetas1;
                recetaEN.FechaCrea = System.DateTime.Now;
                recetaEN.Contenido = "Contenido de receta 2";
                recetaEN.Likes = 3;
                recetaEN.Visualizaciones = 30;
                recetaEN.Ingredientes = listaIngredientes2;
                recetaEN.Usuario = usuarioCAD.ReadOIDDefault("yisus");

                publicacionesOID.Add(recetaCAD.CrearReceta(recetaEN));
                publicacionCEN.DarLike(publicacionesOID[++indexPubli]);

                recetaEN = null;

                #endregion

                #region Receta 3

                recetaEN = new RecetaEN();

                recetaEN.Titulo = "Receta 3";
                recetaEN.Etiquetas = listaEtiquetas2;
                recetaEN.FechaCrea = System.DateTime.Now;
                recetaEN.Contenido = "Contenido de receta 3";
                recetaEN.Likes = 4;
                recetaEN.Visualizaciones = 30;
                recetaEN.Ingredientes = listaIngredientes3;
                recetaEN.Usuario = usuarioCAD.ReadOIDDefault("maermka");

                publicacionesOID.Add(recetaCAD.CrearReceta(recetaEN));
                publicacionCEN.DarLike(publicacionesOID[++indexPubli]);

                recetaEN = null;

                #endregion

                #endregion

                #region Noticias

                NoticiaCAD noticiaCAD = new NoticiaCAD();
                NoticiaCEN noticiaCEN = new NoticiaCEN();
                NoticiaEN noticiaEN = null;

                #region Noticia 1

                noticiaEN = new NoticiaEN();

                noticiaEN.Titulo = "Noticia 1";
                noticiaEN.Etiquetas = listaEtiquetas2;
                noticiaEN.FechaCrea = System.DateTime.Now;
                noticiaEN.Contenido = "Contenido de noticia 1";
                noticiaEN.Likes = 2;
                noticiaEN.Visualizaciones = 30;
                noticiaEN.Usuario = usuarioCAD.ReadOIDDefault("kyou");

                publicacionesOID.Add(noticiaCAD.CrearNoticia(noticiaEN));
                publicacionCEN.DarLike(publicacionesOID[++indexPubli]);

                noticiaEN = null;

                #endregion

                #region Noticia 2

                noticiaEN = new NoticiaEN();

                noticiaEN.Titulo = "Noticia 2";
                noticiaEN.Etiquetas = listaEtiquetas1;
                noticiaEN.FechaCrea = System.DateTime.Now;
                noticiaEN.Contenido = "Contenido de noticia 2";
                noticiaEN.Likes = 3;
                noticiaEN.Visualizaciones = 30;
                noticiaEN.Usuario = usuarioCAD.ReadOIDDefault("jesucristo");

                publicacionesOID.Add(noticiaCAD.CrearNoticia(noticiaEN));
                publicacionCEN.DarLike(publicacionesOID[++indexPubli]);

                noticiaEN = null;

                #endregion

                #endregion

                #region Eventos

                EventoCAD eventoCAD = new EventoCAD();
                EventoCEN eventoCEN = new EventoCEN(eventoCAD);
                EventoEN eventoEN = null;

                #region Evento 1

                eventoEN = new EventoEN();

                eventoEN.Titulo = "Evento 1";
                eventoEN.Etiquetas = listaEtiquetas1;
                eventoEN.FechaCrea = System.DateTime.Now;
                eventoEN.Contenido = "Contenido del evento 1";
                eventoEN.Likes = 3;
                eventoEN.Visualizaciones = 30;
                eventoEN.Usuario = usuarioCAD.ReadOIDDefault("maermka");
                eventoEN.Lugar = "Madrid";

                publicacionesOID.Add(eventoCAD.CrearEvento(eventoEN));
                publicacionCEN.DarLike(publicacionesOID[++indexPubli]);

                eventoEN = null;

                #endregion

                #endregion

                #region Entrevistas

                EntrevistaCAD entrevistaCAD = new EntrevistaCAD();
                EntrevistaCEN entrevistaCEN = new EntrevistaCEN(entrevistaCAD);
                EntrevistaEN entrevistaEN = null;

                #region Entrevista 1

                entrevistaEN = new EntrevistaEN();
                entrevistaEN.Titulo = "Entrevista 1";
                entrevistaEN.Etiquetas = listaEtiquetas1;
                entrevistaEN.FechaCrea = System.DateTime.Now;
                entrevistaEN.Contenido = "Contenido de entrevista 1";
                entrevistaEN.Likes = 2;
                entrevistaEN.Visualizaciones = 30;
                entrevistaEN.Usuario = usuarioCAD.ReadOIDDefault("kyou");
                entrevistaEN.Entrevistado = "Alberto Chicote";

                publicacionesOID.Add(entrevistaCAD.CrearEntrevista(entrevistaEN));
                publicacionCEN.DarLike(publicacionesOID[++indexPubli]);

                noticiaEN = null;

                #endregion

                #endregion

                #endregion

                #region Comentarios

                ComentarioCAD comentarioCAD = new ComentarioCAD();
                ComentarioCEN comentarioCEN = new ComentarioCEN(comentarioCAD);
                ComentarioEN comentarioEN = null;

                System.Collections.Generic.List<int> comentariosOID = new List<int>();
                int indexCom = 0;

                #region Comentario 1

                comentarioEN = new ComentarioEN();

                comentarioEN.Contenido = "Es lo mejor que he visto en mi vida.";
                comentarioEN.FechaCom = System.DateTime.Now;
                comentarioEN.Likes = 2;
                comentarioEN.Publicacion = publicacionCAD.ReadOIDDefault(publicacionesOID[indexPubli]);
                comentarioEN.Usuario = usuarioCAD.ReadOIDDefault("yisus");

                comentariosOID.Add(comentarioCAD.CrearComentario(comentarioEN));
                comentarioCEN.DarLikes(comentariosOID[indexCom++]);

                comentarioEN = null;

                #endregion

                #endregion
                /*PROTECTED REGION END*/
            }
            catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
