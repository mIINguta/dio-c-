using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webApi.Context;
using webApi.Entities;

namespace webApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context){
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato){
            _context.Add(contato);
            _context.SaveChanges();

            return Ok(contato);

        }        

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id){
            var contato = _context.Contatos.Find(id); // contatos é o dbset
            
            if(contato == null){
                return NotFound();
            }
            
            return Ok(contato);    
        }
        
        [HttpPut("{id}")]
        public IActionResult AtualizarContato(int id, Contato contato){
            var contatoBanco = _context.Contatos.Find(id);

            if(contatoBanco == null){
                return NotFound();
            }
            
            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoBanco);
            _context.SaveChanges();
            return Ok(contatoBanco);


        }
    }
}