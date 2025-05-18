namespace TallerAPIs.Interfaces
{
    public interface IChatBotService
    {
        public Task <string> ObtenerRespuestaChatBot(string promt);
        public bool GuardarRespuestaBaseDatosLocal(string promt,string respuesta);
    }
}
