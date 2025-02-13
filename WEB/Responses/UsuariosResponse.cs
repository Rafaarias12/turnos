

namespace WEB.Responses
{
    public class UsuariosResponse
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int PerfilId { get; set; }
        public bool Activo { get; set; }
    }
}
