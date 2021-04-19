using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Control;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        //teste do método PegaLogin(), que compara se login de funcionário está registrado
        [TestMethod]
        public void TesteFuncionario()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Login = "hugo@gmail.com";

            Assert.AreEqual(1, funcionario.PegaLogin());
        }

        /*teste do método PegaPegaStatus(), que preenche os atributos de nome e status de um funcionário 
        baseado em em um login informado */
        [TestMethod]
        public void TesteFuncionario2()
        {
            Funcionario funcionario = new Funcionario();

            Assert.AreEqual(null, funcionario.Nome);

            funcionario.Login = "hugo@gmail.com";

            funcionario.PegaStatus();

            Assert.AreEqual("Hugo César", funcionario.Nome);
        }

        //teste do método Checa(), que compara se nome de fornecedor já está registrado
        [TestMethod]
        public void TesteFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = "teste";

            Assert.AreEqual(1, fornecedor.Checa());
        }

        //teste do método Confirma(), que compara se código de venda informado está nos registros
        [TestMethod]
        public void TesteVenda()
        {
            Venda venda = new Venda();
            venda.Codigo = 1;

            Assert.AreEqual(1, venda.Confirma());
        }

        /*teste do método NovaQtd(), que atualiza a quantidade do produto em estoque baseado
        na quantidade de saída em venda */
        [TestMethod]
        public void TesteProduto()
        {
            Produto produto = new Produto();
            produto.Codigo = 9;

            Assert.AreEqual(1, produto.NovaQtd(3));
        }  
    }
}
