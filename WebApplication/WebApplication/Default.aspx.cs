using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Web.UI;

namespace WebApplication
{

    public partial class _Default : Page
    {
        private const string URL = "http://Localhost:8084/";

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            //Añadiendo cabecera de aceptación para el formato JSON
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Respuesta de datos
            HttpResponseMessage response = client.GetAsync("RESTAPIServer/webapi/service/").Result;
            if (response.IsSuccessStatusCode)
            {
                var estudiantes = response.Content.ReadAsAsync<IEnumerable<Estudiante>>().Result;
                GridView1.DataSource = estudiantes;
                GridView1.DataBind();
            }
            else
            {
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