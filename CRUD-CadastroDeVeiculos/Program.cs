using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_CadastroDeVeiculos
{
    class Program
    {
        //INSTANCIANDO OBJETOS
        static CarroPasseioRepositorio interacaoCarroRepositorio = new CarroPasseioRepositorio();
        static MotoRepositorio interacaoMotoRepositorio = new MotoRepositorio();
        static CaminhaoRepositorio interacaoCaminhaoRepositorio = new CaminhaoRepositorio();
        
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();//TRABALHANDO ESCOLHA DO USUÁRIO
            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarCarroPasseio();
                        break;
                    case "2":
                        ListarMoto();
                        break;
                    case "3":
                        ListarCaminhao();
                        break;
                    case "4":
                        InserirCarroPasseio();
                        break;
                    case "5":
                        InserirMoto();
                        break;
                    case "6":
                        InserirCaminhao();
                        break;
                    case "7":
                        AtualizarCarroPasseio();
                        break;
                    case "8":
                        AtualizarMoto();
                        break;
                    case "9":
                        AtualizarCaminhao();
                        break;
                    case "10":
                        ExcluirCarroPasseio();
                        break;
                    case "11":
                        ExcluirMoto();
                        break;
                    case "12":
                        ExcluirCaminhao();
                        break;
                    case "13":
                        VisualizarCarrosPasseio();
                        break;
                    case "14":
                        VisualizarMoto();
                        break;
                    case "15":
                        VisualizarCaminhao();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida !");
                        break;
                }
                Console.WriteLine("\n");
                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static void VisualizarCarrosPasseio()//MÉTODO PARA VISUALIZAR REGISTRO CARROS
        {
            var lista = interacaoCarroRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Visualizar Carros de Pesseio");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Carro Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Id do Carro: ");
                int indiceCarro = int.Parse(Console.ReadLine());
                var carro = interacaoCarroRepositorio.RetornaPorId(indiceCarro);
                Console.WriteLine(carro);
            }
        }

        private static void VisualizarMoto()//MÉTODO PARA VISUALIZAR REGISTRO DE MOTO
        {
            var lista = interacaoMotoRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Visualizar Motos");
            Console.WriteLine("=-=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Moto Cadastrada\n");
            }
            else
            {
                Console.Write("Digite o Id da Moto: ");
                int indiceMoto = int.Parse(Console.ReadLine());
                var moto = interacaoMotoRepositorio.RetornaPorId(indiceMoto);
                Console.WriteLine(moto);
            }
        }

        private static void VisualizarCaminhao()//MÉTODO PARA VISUALIZAR REGISTRO DE CAMINHÕES
        {
            var lista = interacaoCaminhaoRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Visualizar Caminhões");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Caminhão Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Id do Caminhão: ");
                int indiceCaminhao = int.Parse(Console.ReadLine());
                var caminhao = interacaoCaminhaoRepositorio.RetornaPorId(indiceCaminhao);
                Console.WriteLine(caminhao);
            }
        }

        private static void ExcluirCarroPasseio()//MÉTODO PARA MARCAR CARRO COMO EXCLUÍDO(NÃO SERÁ EXCLUÍDO)
        {
            var lista = interacaoCarroRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Excluir Carro de Passeio");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Carro Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Id do Carro: ");
                int indiceCarro = int.Parse(Console.ReadLine());
                Console.Write($"Deseja Mesmo Excluir o Carro {indiceCarro} [S] ou [N]: ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    interacaoCarroRepositorio.Exclui(indiceCarro);
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
        }

        private static void ExcluirMoto()//MÉTODO PARA MARCAR MOTO COMO EXCLUÍDA(NÃO SERÁ EXCLUÍDA)
        {
            var lista = interacaoMotoRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-");
            Console.WriteLine("Excluir Moto");
            Console.WriteLine("=-=-=-=-=-=-=-");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Moto Cadastrada\n");
            }
            else
            {
                Console.Write("Digite o Id da Moto: ");
                int indiceMoto = int.Parse(Console.ReadLine());
                Console.Write($"Deseja Mesmo Excluir a Moto {indiceMoto} [S] ou [N]: ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    interacaoMotoRepositorio.Exclui(indiceMoto);
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
        }

        private static void ExcluirCaminhao()//MÉTODO PARA MARCAR CAMINHÃO COMO EXCLUÍDO(NÃO SERÁ EXCLUÍDO)
        {
            var lista = interacaoCaminhaoRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Excluir Caminhão");
            Console.WriteLine("=-=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Caminhão Cadastrado\n");
            }
            else
            {
                Console.Write("Digite o Id do Caminhão: ");
                int indiceCaminhao = int.Parse(Console.ReadLine());
                Console.Write($"Deseja Mesmo Excluir o Caminhão {indiceCaminhao} [S] ou [N]: ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    interacaoCaminhaoRepositorio.Exclui(indiceCaminhao);
                }
                else
                {
                    Console.WriteLine("Ok");
                }
            }
        }

        private static void AtualizarCarroPasseio()//MÉTODO PARA ATUALIZAR REGISTRO DE CARROS
        {
            var lista = interacaoCarroRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Atualizar Registro de Carro");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Carro Cadastrado\n");
            }
            else
            {
                Console.Write("Atualize o Id do Carro: ");
                int indiceCarro = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserir Novo Carro");
                Console.Write("Digite o Modelo do Carro: ");
                string entradaModelo = Console.ReadLine();
                Console.Write("Digite a Marca do Carro: ");
                string entradaMarca = Console.ReadLine();
                Console.Write("Digite o Ano do Carro: ");
                int entradaAno = int.Parse(Console.ReadLine());
                Console.Write("Digite o Preço do Carro: ");
                double entradaPreco = double.Parse(Console.ReadLine());
                Console.Write("Digite a Kilometragem do Carro: ");
                int entradaKilometragem = int.Parse(Console.ReadLine());

                CarroPasseio atualizaCarro = new CarroPasseio(id: indiceCarro,
                                                modelo: entradaModelo,
                                                marca: entradaMarca,
                                                ano: entradaAno,
                                                preco: entradaPreco,
                                                kilometragem: entradaKilometragem);

                interacaoCarroRepositorio.Atualiza(indiceCarro, atualizaCarro);
            }

        }

        private static void AtualizarMoto()//MÉTODO PARA ATUALIZAR REGISTRO DE MOTO
        {
            var lista = interacaoMotoRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Atualizar Registro de Moto");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Moto Cadastrada\n");
            }
            else
            {
                Console.Write("Atualize o Id da Moto: ");
                int indiceMoto = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserir Nova Moto");
                Console.Write("Digite o Modelo da Moto: ");
                string entradaModelo = Console.ReadLine();
                Console.Write("Digite a Marca da Moto: ");
                string entradaMarca = Console.ReadLine();
                Console.Write("Digite o Ano da Moto: ");
                int entradaAno = int.Parse(Console.ReadLine());
                Console.Write("Digite o Preço da Moto: ");
                double entradaPreco = double.Parse(Console.ReadLine());
                Console.Write("Digite a Cilindrada da Moto: ");
                int entradaCilindrada = int.Parse(Console.ReadLine());

                Moto atualizaMoto = new Moto(id: indiceMoto,
                                                modelo: entradaModelo,
                                                marca: entradaMarca,
                                                ano: entradaAno,
                                                preco: entradaPreco,
                                                cilindrada: entradaCilindrada);

                interacaoMotoRepositorio.Atualiza(indiceMoto, atualizaMoto);
            }
        }

        private static void AtualizarCaminhao()//MÉTODO PARA ATUALIZAR REGISTRO DE CAMINHÃO
        {
            var lista = interacaoCaminhaoRepositorio.Lista();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Atualizar Registro de Caminhão");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Caminhão Cadastrado\n");
            }
            else
            {
                Console.Write("Atualize o Id do Caminhão: ");
                int indiceCaminhao = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserir Novo Caminhão");
                Console.Write("Digite o Modelo do Caminhão: ");
                string entradaModelo = Console.ReadLine();
                Console.Write("Digite a Marca do Caminhão: ");
                string entradaMarca = Console.ReadLine();
                Console.Write("Digite o Ano do Caminhão: ");
                int entradaAno = int.Parse(Console.ReadLine());
                Console.Write("Digite o Preço do Caminhão: ");
                double entradaPreco = double.Parse(Console.ReadLine());
                Console.Write("Digite o Peso do Caminhão: ");
                int entradaPeso = int.Parse(Console.ReadLine());

                Caminhao atualizaCaminhao = new Caminhao(id: indiceCaminhao,
                                                modelo: entradaModelo,
                                                marca: entradaMarca,
                                                ano: entradaAno,
                                                preco: entradaPreco,
                                                toneladas: entradaPeso);

                interacaoCaminhaoRepositorio.Atualiza(indiceCaminhao, atualizaCaminhao);
            }
        }

        private static void InserirCarroPasseio()//MÉTODO PARA INSERIR NOVO REGISTRO DE CARRO
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Inserir Novo Carro");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
            Console.Write("Digite o Modelo do Carro: ");
            string entradaModelo = Console.ReadLine();
            Console.Write("Digite a Marca do Carro: ");
            string entradaMarca = Console.ReadLine();
            Console.Write("Digite o Ano do Carro: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite o Preço do Carro: ");
            double entradaPreco = double.Parse(Console.ReadLine());
            Console.Write("Digite a Kilometragem do Carro: ");
            int entradaKilometragem = int.Parse(Console.ReadLine());

            CarroPasseio novoCarro = new CarroPasseio(id: interacaoCarroRepositorio.ProximoId(),
                                            modelo: entradaModelo,
                                            marca: entradaMarca,
                                            ano: entradaAno,
                                            preco: entradaPreco,
                                            kilometragem: entradaKilometragem);

            interacaoCarroRepositorio.Insere(novoCarro);
        }

        private static void InserirMoto()//MÉTODO PARA INSERIR NOVO REGISTRO DE MOTO
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Inserir Nova Moto");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-");
            Console.Write("Digite o Modelo da Moto: ");
            string entradaModelo = Console.ReadLine();
            Console.Write("Digite a Marca da Moto: ");
            string entradaMarca = Console.ReadLine();
            Console.Write("Digite o Ano da Moto: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite o Preço da Moto: ");
            double entradaPreco = double.Parse(Console.ReadLine());
            Console.Write("Digite a Cilindrada da Moto: ");
            int entradaCilindrada = int.Parse(Console.ReadLine());

            Moto novaMoto = new Moto(id: interacaoMotoRepositorio.ProximoId(),
                                            modelo: entradaModelo,
                                            marca: entradaMarca,
                                            ano: entradaAno,
                                            preco: entradaPreco,
                                            cilindrada: entradaCilindrada);

            interacaoMotoRepositorio.Insere(novaMoto);
        }

        private static void InserirCaminhao()//MÉTODO PARA INSERIR NOVO REGISTRO DE CAMINHÃO
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Inserir Novo Caminhão");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Digite o Modelo do Caminhão: ");
            string entradaModelo = Console.ReadLine();
            Console.Write("Digite a Marca do Caminhão: ");
            string entradaMarca = Console.ReadLine();
            Console.Write("Digite o Ano do Caminhão: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite o Preço do Caminhão: ");
            double entradaPreco = double.Parse(Console.ReadLine());
            Console.Write("Digite o Peso do Caminhão: ");
            int entradaPeso = int.Parse(Console.ReadLine());

            Caminhao novoCaminhao = new Caminhao(id: interacaoCaminhaoRepositorio.ProximoId(),
                                            modelo: entradaModelo,
                                            marca: entradaMarca,
                                            ano: entradaAno,
                                            preco: entradaPreco,
                                            toneladas: entradaPeso);

            interacaoCaminhaoRepositorio.Insere(novoCaminhao);
        }

        private static void ListarCarroPasseio()//MÉTODO PARA LISTAR REGISTROS DE CARRO
        {
            Console.WriteLine("=-=-=-=-=-=-=-=");
            Console.WriteLine("Listar Carros");
            Console.WriteLine("=-=-=-=-=-=-=-=");
            var lista = interacaoCarroRepositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Carro Cadastrado\n");
            }

            foreach (var carro in lista)
            {
                var excluido = carro.RetornaExcluido();
                Console.WriteLine($"#ID {carro.RetornaId()}: - {carro.RetornaModelo()}  {(excluido ? "Excluído" : "")}");
            }
        }

        private static void ListarMoto()//MÉTODO PARA LISTAR REGISTROS DE MOTO
        {
            Console.WriteLine("=-=-=-=-=-=-=-");
            Console.WriteLine("Listar Motos");
            Console.WriteLine("=-=-=-=-=-=-=-");
            var lista = interacaoMotoRepositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Moto Cadastrada\n");
            }

            foreach (var moto in lista)
            {
                var excluido = moto.RetornaExcluido();
                Console.WriteLine($"#ID {moto.RetornaId()}: - {moto.RetornaModelo()}  {(excluido ? "Excluído" : "")}");
            }
        }

        private static void ListarCaminhao()//MÉTODO PARA LISTAR REGISTROS DE CAMINHÃO
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Listar Caminhões");
            Console.WriteLine("=-=-=-=-=-=-=-=-=");
            var lista = interacaoCaminhaoRepositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Caminhão Cadastrado\n");
            }

            foreach (var caminhao in lista)
            {
                var excluido = caminhao.RetornaExcluido();
                Console.WriteLine($"#ID {caminhao.RetornaId()}: - {caminhao.RetornaModelo()}  {(excluido ? "Excluído" : "")}");
            }
        }

        private static string ObterOpcaoUsuario()//MÉTODO PARA APRESENTAR MENU PARA USUÁRIO
        {

            Console.WriteLine("1 - Listar Carros");
            Console.WriteLine("2 - Listar Motos");
            Console.WriteLine("3 - Listar Caminhões");
            Console.WriteLine("4 - Inserir Novo Carro");
            Console.WriteLine("5 - Inserir Nova Moto");
            Console.WriteLine("6 - Inserir Novo Caminhão");
            Console.WriteLine("7 - Atualizar Carro");
            Console.WriteLine("8 - Atualizar Moto");
            Console.WriteLine("9 - Atualizar Caminhão");
            Console.WriteLine("10 - Excluir Carro");
            Console.WriteLine("11 - Excluir Moto");
            Console.WriteLine("12 - Excluir Caminhão");
            Console.WriteLine("13 - Visualizar Carro");
            Console.WriteLine("14 - Visualizar Moto");
            Console.WriteLine("15 - Visualizar Caminhão");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("\n");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine("\n");
            return opcaoUsuario;

        }
    }
}
