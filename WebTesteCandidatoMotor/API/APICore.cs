using EntitiesTesteCandidato;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTesteCandidatoMotor.API
{
    public static class APICore
    {
        public static Motorista ApiGet(int id)
        {
            var request = new RestRequest("api/BuscarMotorista?id=" + id, Method.GET);

            return JsonConvert.DeserializeObject<Motorista>(RestClient().Execute(request).Content);
        }
        public static List<Motorista> ApiGetAll()
        {
            var request = new RestRequest("api/BuscarLista", Method.GET);

            var queryResult = RestClient().Execute(request);

            return JsonConvert.DeserializeObject<List<Motorista>>(queryResult.Content);
        }

        public static void ApiPost(Motorista dados)
        {
            var request = new RestRequest("api/Cadastrar", Method.POST);
            request.AddJsonBody(dados);
            RestClient().Execute(request);
        }
        public static bool ApiPostEdit(Motorista dados)
        {
            var request = new RestRequest("api/Atualizar", Method.POST);
            request.AddJsonBody(dados);
            return RestClient().Execute(request).IsSuccessful == true? true: false ;
        }
        public static bool ApiDelete(Motorista motorista)
        {
            var request = new RestRequest("api/Delete", Method.DELETE);
            request.AddJsonBody(motorista);
            return RestClient().Execute(request).IsSuccessful == true ? true : false;
        }
        private static RestClient RestClient() {
            return new RestClient("https://localhost:44347/");
        }

    }
}
