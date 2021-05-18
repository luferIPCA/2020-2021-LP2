using Aulas.Controllers;
using Aulas.Models;
using System;
using System.Globalization;

namespace Aulas.View
{
    public class PlataformaView
    {
        private Menu _menuState;
        private ArtigoController _artigoController;

        public PlataformaView()
        {
            _artigoController = new ArtigoController();
        }

        public void InicializarPlataformaView()
        {
            while (_menuState != Menu.Sair)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opcao");
                Console.WriteLine(((int)Menu.InserirArtigo) + " Para inserir artigos");
                Console.WriteLine(((int)Menu.EliminarArtigo) + " Para eliminar artigos");
                Console.WriteLine(((int)Menu.ListarArtigos) + " Para listar artigos");
                Console.WriteLine(((int)Menu.Sair) + " Para saír");
                string opcao = Console.ReadLine();

                if (!Menu.TryParse(opcao, out _menuState))
                {
                    _menuState = Menu.Invalido;
                }
                #region Menu
                switch (_menuState)
                {
                    case Menu.InserirArtigo:
                        OpcaoInserirArtigo();
                        break;
                    case Menu.EliminarArtigo:
                        OpcaoEliminarArtigo();
                        break;
                    case Menu.ListarArtigos:
                        OpcaoListArtigos();
                        break;
                    case Menu.Sair:
                        break;
                    case Menu.Invalido:
                    default:
                        OpcaoInvalidoDefault();
                        break;
                }
                #endregion

                Console.ReadLine();
            }

        }

        private void OpcaoInserirArtigo()
        {
            Console.WriteLine("Insira o nome do artigo");
            string nomeArtigoInserir = Console.ReadLine();
            Console.WriteLine("Insira o preço do artigo");
            float precoArtigoInserir;
            string valorArtigoInserir;
            do
            {
                valorArtigoInserir = Console.ReadLine();
            } while (!float.TryParse(
                valorArtigoInserir,
                NumberStyles.Any,
                new CultureInfo("PT-pt"),
                out precoArtigoInserir));
            Artigo artigoInserir = new Artigo(nomeArtigoInserir, precoArtigoInserir, _artigoController.GetArtigos().Count);
            _artigoController.InserirArtigo(artigoInserir);
        }

        private void OpcaoEliminarArtigo()
        {
            Console.WriteLine("Introduza um nome ou id do artigo a eliminar ");
            string nome = Console.ReadLine();
            int id;
            if (int.TryParse(nome, out id))
            {
                if (_artigoController.RemoverArtigo(id))
                {
                    Console.WriteLine("Removeu o artigo com sucesso");
                }
                else
                {
                    Console.WriteLine("Artigo não encontrado");
                }
            }
            else
            {
                if (_artigoController.RemoverArtigo(nome))
                {
                    Console.WriteLine("Removeu o artigo com sucesso");
                }
                else
                {
                    Console.WriteLine("Artigo não encontrado");
                }
            }
        }

        private void OpcaoListArtigos()
        {
            foreach (Artigo artigo in _artigoController.GetArtigos())
            {
                Console.WriteLine(
                    string.Concat(
                        artigo.Identificador,
                        "     ",
                        artigo.Nome,
                        "     ",
                        artigo.Preco));
            }
        }

        private void OpcaoInvalidoDefault()
        {
            Console.WriteLine("Opcao invalida");
        }

    }
}
