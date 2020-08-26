using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Cadastro
{
    public static class Biblioteca
    {
        
        public static void LerCarreira(ArrayList id, ArrayList nome)
        {

            id.Clear();
            nome.Clear();

            if (File.Exists(@"D:\Projeto-versão1.2\Projeto\CRUD_CREA\Cadastro\carreira.txt"))
            {
                //Através da classe stream é possível transportar dados, seja de arquivos, memórias.

                Stream entrada = File.Open(@"D:\Projeto-versão1.2\Projeto\CRUD_CREA\Cadastro\carreira.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    // IndexOf serve para sabermos qual índice determinado pedaço da string corresponde, devolve o número inteiro.

                    int posicaoPrimeiroDelimitador = linha.IndexOf(";");

                    id.Add(linha.Substring(0, posicaoPrimeiroDelimitador));
                    nome.Add(linha.Substring(posicaoPrimeiroDelimitador + 1));

                    //Uso do split permite  dividir uma string em pequenos pedaços. Para isso, seu método retorna um array de strings.
                    //No caso abaixo o separador será o ponto e vírgula.
                    /*
                    String[] campos = new String[2];
                    campos = linha.Split(';');

                    idCarreira.Add(campos[0]);
                    nomeCarreira.Add(campos[1]);
                    */

                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();

            }
            else
            {
                MessageBox.Show("Arquivo de carreiras não encontrado.");
            }
            
        }


        public static void EscreverCarreira(ArrayList id, ArrayList nome)
        {
            
        Stream saida = File.Open(@"D:\Projeto-versão1.2\Projeto\CRUD_CREA\Cadastro\carreira.txt", FileMode.Create);
        StreamWriter escritor = new StreamWriter(saida);
        for (int i = 0; i < id.Count; i++)
        {
            escritor.WriteLine(Convert.ToString(id[i]) + ";" + Convert.ToString(nome[i]));                    
        }
        escritor.Close();
        saida.Close();                                             
            
        }


        public static void LerProfissional(ArrayList id, ArrayList nome, ArrayList telefone, ArrayList carreira)
        {

            id.Clear();
            nome.Clear();
            telefone.Clear();
            carreira.Clear();

            if (File.Exists(@"D:\Projeto-versão1.2\Projeto\CRUD_CREA\Cadastro\profissional.txt"))
            {
                Stream entrada = File.Open(@"D:\Projeto-versão1.2\Projeto\CRUD_CREA\Cadastro\profissional.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {

                    
                    int posicaoPrimeiroDelimitador = linha.IndexOf(";");
                    int posicaoSegundoDelimitador = linha.IndexOf(";", posicaoPrimeiroDelimitador + 1);
                    int posicaoTerceiroDelimitador = linha.IndexOf(";", posicaoSegundoDelimitador + 1);

                    int diferencaSegundoPrimeiro = posicaoSegundoDelimitador - posicaoPrimeiroDelimitador -1;
                    int diferencaTerceiroSegundo = posicaoTerceiroDelimitador - posicaoSegundoDelimitador -1;

                    id.Add(linha.Substring(0, posicaoPrimeiroDelimitador));
                    nome.Add(linha.Substring(posicaoPrimeiroDelimitador + 1, diferencaSegundoPrimeiro));
                    telefone.Add(linha.Substring(posicaoSegundoDelimitador + 1, diferencaTerceiroSegundo));
                    carreira.Add(linha.Substring(posicaoTerceiroDelimitador + 1));
                    
                    /*
                    String[] campos = new String[4];
                    campos = linha.Split(';');

                    idProfissional.Add(campos[0]);
                    nomeProfissional.Add(campos[1]);
                    telefoneProfissional.Add(campos[2]);
                    carreiraProfissional.Add(campos[3]);
                    */

                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();

            }
            else
            {
                MessageBox.Show("Arquivo de profissionais não encontrado.");
            }

        }
        public static void EscreverProfissional(ArrayList id, ArrayList nome, ArrayList telefone, ArrayList carreira)
        {

            Stream saida = File.Open(@"D:\Projeto-versão1.2\Projeto\CRUD_CREA\Cadastro\profissional.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
           
            for (int i = 0; i < id.Count; i++)
            {
                escritor.WriteLine(Convert.ToString(id[i]) + ";" + Convert.ToString(nome[i]) + ";" + Convert.ToString(telefone[i]) + ";" + Convert.ToString(carreira[i]).Substring(0,1));
            }
            escritor.Close();
            saida.Close();

        }


        public static void PopularNomeCarreira(ArrayList id, ArrayList nome, ArrayList carreira, ArrayList nomeCarreira)
        {
            
            
            for (int i = 0; i < carreira.Count; i++)
            {
                for (int j = 0; j < id.Count; j++)
                {
                    if (Convert.ToInt32(carreira[i]) == Convert.ToInt32(id[j]))
                    {
                        nomeCarreira.Add(nome[j]);
                        break;
                    }
                }
            }
        }

        public static void CriarCarreira(ArrayList id, ArrayList nome, string novaCarreira)
        {
            int novoId;
            bool existeCarreira = false;

            

            for (int i = 0; i < nome.Count; i++)
            {
                if (Convert.ToString(nome[i]) == novaCarreira)
                {
                    existeCarreira = true;
                }
            }

            if (existeCarreira)
            {
                MessageBox.Show("Não é possivel criar a Carreira " + novaCarreira + " pois já existe uma carreira com este nome.");
            }
            else
            {
                if (id.Count > 0)
                {
                    novoId = Convert.ToInt32(id[id.Count - 1]) + 1;
                }
                else
                {
                    novoId = 1;
                }
                id.Add(novoId);

                nome.Add(novaCarreira);

                Biblioteca.EscreverCarreira(id, nome);

                MessageBox.Show("Nova carreira: id= " + Convert.ToString(id[id.Count - 1]) + " carreira= " + Convert.ToString(nome[nome.Count - 1]) + " criada com sucesso!");
            }
                      
        }

        public static void CriarProfissional(ArrayList id, ArrayList nome, ArrayList telefone, ArrayList carreira, string novoNome, string novoTelefone, string carreiraEscolhida)
        {
            int novoId;
            string idFormatado = "";
            Biblioteca.LerProfissional(id, nome, telefone, carreira);

            if (id.Count > 0)
            {
                novoId = Convert.ToInt32(id[id.Count - 1]) + 1;

            }
            else
            {
                novoId = 1;

            }

            if (Convert.ToString(novoId).Length == 1)
            {
                idFormatado = "00" + Convert.ToString(novoId);
            }
            else if (Convert.ToString(novoId).Length == 2)
            {
                idFormatado = "0" + Convert.ToString(novoId);
            }

            id.Add(idFormatado);

            nome.Add(novoNome);
            telefone.Add(novoTelefone);
            carreira.Add(carreiraEscolhida);

            Biblioteca.EscreverProfissional(id, nome, telefone, carreira);

            MessageBox.Show("Nova profissional cadastrado com sucesso!");
            

        }

        public static void SalvarCarreira(ArrayList id,ArrayList nome, string nomeAtualizado, int indiceArray, bool salvarNovo)
        {
            if (salvarNovo==false && MessageBox.Show("Tem certeza que deseja alterar carreira " + nome[indiceArray] + " ?", "CREA INFORMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string nomeAnterior = Convert.ToString(nome[indiceArray]);
                nome[indiceArray] = nomeAtualizado;
                Biblioteca.EscreverCarreira(id, nome);
                MessageBox.Show("Carreira " + nomeAnterior + " foi alterada para " + nomeAtualizado + " com sucesso!");
                           
            }

            else if (salvarNovo == true)
            {

                Biblioteca.CriarCarreira(id, nome, nomeAtualizado);


            }
            
        }

        public static void ExcluirCarreira(ArrayList id, ArrayList carreira, ArrayList nome, int indiceArray)
        {
           bool existeProfissional = false;
           string nomeSelecionado=Convert.ToString(nome[indiceArray]);

           
            
           for (int i = 0; i < carreira.Count; i++)
           {
              if (Convert.ToInt32(carreira[i]) == Convert.ToInt32(id[Convert.ToInt32(indiceArray)]))
              {
                   existeProfissional = true;
              }
           }

       

           if (existeProfissional)
           {
               MessageBox.Show("Não é possivel excluir a Carreira " + nomeSelecionado + " pois existem profissionais cadastrados na mesma.");

           }
           else
           {

                id.RemoveAt(Convert.ToInt32(indiceArray));
                nome.RemoveAt(Convert.ToInt32(indiceArray));

                Biblioteca.EscreverCarreira(id, nome);

                MessageBox.Show("Carreira " + nomeSelecionado + " foi excluída com sucesso!");
           }

            
        }

        public static void SalvarProfissional(ArrayList id,ArrayList nome, ArrayList telefone,ArrayList carreira, string nomeAtualizado, string telefoneAtualizado, string categoriaAtualizada, int indiceArray, bool salvarNovo)
        {
            if (salvarNovo == false && MessageBox.Show("Tem certeza que deseja editar o registro " + id[indiceArray] + " ?", "CREA INFORMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nome[indiceArray] = nomeAtualizado;
                telefone[indiceArray] = telefoneAtualizado;
                carreira[indiceArray] = categoriaAtualizada;

                Biblioteca.EscreverProfissional(id, nome, telefone, carreira);
                MessageBox.Show("Profissional " + id[indiceArray] + " foi alterado com sucesso!");

            }

            else if (salvarNovo == true)
            {
                
                Biblioteca.CriarProfissional(id, nome, telefone,carreira, nomeAtualizado, telefoneAtualizado, categoriaAtualizada);
                Biblioteca.EscreverProfissional(id, nome, telefone, carreira);

            }

        }

        public static void ExcluirProfissional(ArrayList id, ArrayList nome, ArrayList telefone, ArrayList carreira, int indiceArray)
        {
           
            string nomeSelecionado = Convert.ToString(nome[indiceArray]);

            id.RemoveAt(Convert.ToInt32(indiceArray));
            nome.RemoveAt(Convert.ToInt32(indiceArray));
            telefone.RemoveAt(Convert.ToInt32(indiceArray));
            carreira.RemoveAt(Convert.ToInt32(indiceArray));
            Biblioteca.EscreverProfissional(id, nome, telefone, carreira);
 
            MessageBox.Show("Profissional " + nomeSelecionado + " foi excluído com sucesso!");
  
        }

    }
} 


