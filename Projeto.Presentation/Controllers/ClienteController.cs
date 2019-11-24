using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Application.ApplicationServices.Contracts;
using Projeto.Application.ViewModels;
using System.Data;
using System.Data.SqlClient; 

namespace Projeto.Presentation.Controllers
{
    [RoutePrefix("api/cliente")]
    public class ClienteController : ApiController
    {
        private IAppServiceCliente appService; //atributo
        /// <summary>
        /// Script 2
        /// </summary>
        /// <param name="appService"></param>
        //construtor para injeção de dependência..
        public ClienteController(IAppServiceCliente appService)
        {
            this.appService = appService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public HttpResponseMessage Cadastrar(ClienteCadastroViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    appService.Cadastrar(model);
                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Cliente cadastrado com sucesso.");
                }
                catch (Exception e)
                {

                    return Request.CreateResponse
                        (HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse
                            (HttpStatusCode.BadRequest, ModelState);
            }
        }

        [HttpPut]
        [Route("alterar")]
        public HttpResponseMessage Alterar([FromBody] ClienteEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    appService.Alterar(model);
                    return Request.CreateResponse(HttpStatusCode.OK,
                        "Cliente alterado com sucesso.");
                }
                catch (Exception e)
                {

                    return Request.CreateResponse
                        (HttpStatusCode.InternalServerError, e.Message);
                }
            }
            else
            {
                return Request.CreateResponse
                            (HttpStatusCode.BadRequest, ModelState);
            }
        }

        [HttpGet]
        [Route("consultar")]
        public HttpResponseMessage Consultar()
        {
            try
            {
                return Request.CreateResponse(appService.Consultar());
            }
            catch (Exception e)
            {

                return Request.CreateResponse
                            (HttpStatusCode.InternalServerError, e.Message);
            }    
            
        }

        [HttpGet]
        [Route("consultarPorId")]
        public HttpResponseMessage ConsultarPorId([FromBody] int id)
        {
            try
            {
                return Request.CreateResponse(appService.ConsultarPorId(id));
            }
            catch (Exception e)
            {

                return Request.CreateResponse
                            (HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
