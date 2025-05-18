namespace TallerAPIs.Interfaces
{
    public interface IChatbotService
    {
        public Task <string> ObtenerRespuestaChatbot(string promt);
        public bool GuardarRespuestaBaseDatosLocal(string promt,string respuesta);
    }
}
