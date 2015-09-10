using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Web.UI;

/// Creado por Francisco Javier Jiménez Gómez  3/9/2015
/// <summary>
/// Código detrás en C# para consumir una REST API usando HTTPClient
/// utilizando la libreria Web API Client.
/// </summary>

namespace WebApplication
{

    public partial class _Default : Page
    {
        private const string URL = "http://Localhost:8084/";

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Se crea una instancia de HttpClient para peticiones y respuestas HTTP mediante la URI.
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Establece y comunica al servidor la cabecera de aceptación para datos en formato JSON.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Envio de solicitud GET al terminar obtiene respuesta HTTP.
            HttpResponseMessage response = client.GetAsync("RESTAPIServer/webapi/service/").Result;
            if (response.IsSuccessStatusCode)
            {
                var estudiantes = response.Content.ReadAsAsync<IEnumerable<Estudiante>>().Result;
                GridView1.DataSource = estudiantes;
                GridView1.DataBind();
            }
            else
            {   
                // Mensaje que muestra el codigo de respuesta HTTP en caso de error.
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('"+ (int)response.StatusCode + "');", true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}