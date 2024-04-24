using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            return CreatedAtAction(nameof(ObterPorId), new {id = contato.Id}, contato);// retorna a rota que pode ser visualizada a entrada do registro
            // retorna a função, o id recem criado e as informações passadas no contato.
        }        

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id){
            var contato = _context.Contatos.Find(id); // contatos é o dbset
            
            if(contato == null){
                return NotFound();
            }
            
            return Ok(contato);    
        }
        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome){
            var contato = _context.Contatos.Where(x => x.Nome.Contains(nome));

            if (contato == null){
                return NotFound();
            }

            return Ok(contato);
        }
        [HttpGet("ObterContatos")]
        public IActionResult ObterTodos(){
            var contatos = _context.Contatos.Select(_context => _context);

            if(contatos == null){
                return NotFound();
            }

            return Ok(contatos);

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
        [HttpDelete("{id}")]
        public IActionResult DeletarContato(int id){
            var contatoBanco = _context.Contatos.Find(id);

           if (contatoBanco == null){
            return NotFound();
           }

           _context.Contatos.Remove(contatoBanco);
           _context.SaveChanges();

           return NoContent();
        }
    }
}