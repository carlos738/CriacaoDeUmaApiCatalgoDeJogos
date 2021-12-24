using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CriaçãoDeUmaApiCatlogoDeJogos.InputModel;
using CriaçãoDeUmaApiCatlogoDeJogos.ViewModel;

namespace CriaçãoDeUmaApiCatlogoDeJogos.Services
{
   public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int página, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preço);
        Task Remover(Guid id);
    }
}
