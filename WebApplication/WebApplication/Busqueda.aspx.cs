using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Web.UI;

namespace WebApplication
{
    public partial class About : Page
    {
        private const string URL = "http://Localhost:8084/";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            //Añadiendo cabecera de aceptación para el formato JSON
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Respuesta de datos
            HttpResponseMessage response = client.GetAsync("RESTAPIServer/webapi/service/"+txtEmail.Text).Result;
            if (response.IsSuccessStatusCode)
            {
                var estudiantes = response.Content.ReadAsAsync<Estudiante>().Result;
                txtNombre.Text = estudiantes.name;
                txtApellidos.Text = estudiantes.lastname;
                txtFechaNac.Text = Convert.ToString(estudiantes.birthDate);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + (int)response.StatusCode + "');", true);
            }
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}