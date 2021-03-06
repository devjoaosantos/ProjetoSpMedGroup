﻿using Microsoft.AspNetCore.Mvc;
using SenaiSpMedGroup.WebApi.Domains;
using SenaiSpMedGroup.WebApi.Interfaces;
using SenaiSpMedGroup.WebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SenaiSpMedGroup.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository;

        public TipoUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Lista todos os Tipos de Usuario
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_tipoUsuarioRepository.Listar());
        }

        /// <summary>
        /// Busca um Tipo de Usuario pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok(_tipoUsuarioRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Deleta um Tipo de Usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("(id)")]
        public IActionResult Delete(int id)
        {
            _tipoUsuarioRepository.Deletar(id);
            return StatusCode(200);
        }

        /// <summary>
        /// Cadastra um novo Tipo de Usuario
        /// </summary>
        /// <param name="novoTipoUsuario"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(TipoUsuario novoTipoUsuario)
        {
            _tipoUsuarioRepository.Cadastrar(novoTipoUsuario);
            return StatusCode(200);
        }


        /// <summary>
        /// Atualiza um Tipo de Usuario existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tipoUsuario"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(int id, TipoUsuario tipoUsuario)
        {
            _tipoUsuarioRepository.Atualizar(id, tipoUsuario);
            return StatusCode(200);
        }
    }
}
