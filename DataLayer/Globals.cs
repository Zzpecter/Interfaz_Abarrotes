using Newtonsoft.Json;
using System.IO;

namespace DataLayer
{
    public static class Globals
    {
        public const string IP = "192.168.1.7";
        public const string PORT = "5000";
        public static string API_URL = IP + ":" + PORT + "/api/v1/";
        public static string URL_AUTH = "http://" + IP + ":" + PORT + "/auth/login";
        public static string URL_MOTIVOS = "http://" + API_URL + "motivos";
        public static string URL_CLIENTES = "http://" + API_URL + "clientes";
        public static string URL_NIVELES = "http://" + API_URL + "niveles";
        public static string URL_USUARIO = "http://" + API_URL + "users";
        public static string URL_USUARIO_NIVEL = "http://" + API_URL + "usuario-nivel";
        public static string URL_CONTACTOS = "http://" + API_URL + "contactos";
        public static string URL_CONTACTO_CORREO = "http://" + API_URL + "contactos_correo";
        public static string URL_CONTACTO_TELEFONO = "http://" + API_URL + "contactos_telefono";
        public static string URL_DEPARTAMENTO = "http://" + API_URL + "departamentos";
        public static string URL_LOCALIDAD = "http://" + API_URL + "localidades";
        public static string URL_CONTACTO_DIRECCION = "http://" + API_URL + "contactos_direccion";
        public static string URL_CONTACTOS_UNIFIED = "http://" + API_URL + "contactos_unified";
        public static string URL_ENTIDADES = "http://" + API_URL + "entidades";
        public static string URL_PROVEEDORES = "http://" + API_URL + "proveedores";
        public static string URL_UNIDAD_PRESENTACION = "http://" + API_URL + "unidad_presentacion";
        public static string URL_PRESENTACION_PRODUCTO = "http://" + API_URL + "presentacion_producto";
        public static string URL_PRODUCTOS = "http://" + API_URL + "productos";
        public static string URL_VI_PRODUCTOS = "http://" + API_URL + "views/producto_presentacion";
        public static string URL_PRODUCTO_ALMACEN = "http://" + API_URL + "producto_almacen";
        public static string URL_PRODUCTO_ALMACEN_PRODUCTO = "http://" + API_URL + "producto_almacen/producto";
        public static string URL_PRODUCTO_ALMACEN_ALMACEN = "http://" + API_URL + "producto_almacen/almacen";
        public static string URL_PRODUCTOS_BUSCAR = "http://" + API_URL + "productos/buscar";
        public static string URL_ALMACENES = "http://" + API_URL + "almacenes";
        public static string URL_CONTACTO_CORREO_BY_CONTACTO = "http://" + API_URL + "contactos_correo/contacto";
        public static string URL_CONTACTO_TELEFONO_BY_CONTACTO = "http://" + API_URL + "contactos_telefono/contacto";
        public static string URL_CONTACTO_DIRECCION_BY_CONTACTO = "http://" + API_URL + "contactos_direccion/contacto";
        public static string URL_LOCALIDAD_DEPARTAMENTO = "http://" + API_URL + "localidades/departamento";
        public static string URL_CONTACTO_CORREO_BY_ENTIDAD = "http://" + API_URL + "entidad/contacto_correo";
        public static string URL_CONTACTO_TELEFONO_BY_ENTIDAD = "http://" + API_URL + "entidad/contacto_telefono";
        public static string URL_CONTACTO_DIRECCION_BY_ENTIDAD = "http://" + API_URL + "entidad/contacto_direccion";

        public static string ACTUAL_API_TOKEN = String.Empty;

        public static Dictionary<string, string> HTTP_HEADERS = new Dictionary<string, string>()
                {
                    { "Authorization", ""}
                };



        #region Mensajes
        public const string MSJ_PASS_DEBIL = "La contraseña ingresada es muy débil, Intente:\n" +
            "- Aumentar más caracteres (8 es suficiente). O\n" +
            "- Agregue uno o más dígitos (0-9). O\n" +
            "- Agregue una o más mayúsculas (A-Z). O\n" +
            "- Agregue uno o más caracteres especiales ($%&).";

        public const string MSJ_PRODUCTO_EN_ALMACEN = "El producto que desea eliminar se encuentra registrado en almacenes.\n" +
            "Debe disponer de todo el stock en almacen del producto antes de eliminarlo.";

        public const string MSJ_ALMACEN_CONTIENE_PRODUCTOS = "El almacen que desea eliminar tiene productos registrados.\n" +
            "Debe disponer de todos los productos en almacen antes de poder eliminarlo.";
        #endregion
    }
}
