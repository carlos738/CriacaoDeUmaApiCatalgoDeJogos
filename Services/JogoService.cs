using CriaçãoDeUmaApiCatlogoDeJogos.Entities;
using CriaçãoDeUmaApiCatlogoDeJogos.Exceptions;
using CriaçãoDeUmaApiCatlogoDeJogos.InputModel;
using CriaçãoDeUmaApiCatlogoDeJogos.Repositories;
using CriaçãoDeUmaApiCatlogoDeJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriaçãoDeUmaApiCatlogoDeJogos.Services
{
    public class JogoService : IJogoService
    {
        private readonly IjogoRepository _jogoRepository;
        public JogoService(IJogoRepository jogoRepository);
        {
            _jogoRepository = jogoRepository;
        }
        public async Task<List<JogoViewModel>> Obter(int página, int quantidade) {
    }
            var jogos = await _jogoRepository.Obter(página, quantidade);
            return Jogo.Select(jogo => new JogoViewModel
        {
            id = jogo.Id,
            Nome = jogo.Nome,
            Produtora = jogo.Produtora,
            Preço = jogo.Preço
        })
        ´.ToList();
        
    }
    
}
