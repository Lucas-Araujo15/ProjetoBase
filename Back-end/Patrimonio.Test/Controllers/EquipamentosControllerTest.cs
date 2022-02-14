using Moq;
using Patrimonio.Controllers;
using Patrimonio.Domains;
using Patrimonio.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Patrimonio.Test.Controllers
{
    public class EquipamentosControllerTest
    {
        [Fact]
        public void Deve_cadastrar_um_equipamento()
        {
            //  Pré-Condição
            var fakeRepository = new Mock<IEquipamentoRepository>();
            fakeRepository
                .Setup(x => x.Cadastrar(It.IsAny<Equipamento>()));

            var equipamentoFake = new Equipamento()
            {
                Ativo = true,
                NomePatrimonio = "patrimonioTeste",
                DataCadastro = DateTime.Now,
                Descricao = "Este é um teste",
                Imagem = "ed41c37b-a105-4b51-9cb3-377065b5a643.png"
            };

            var controller = new EquipamentosController(fakeRepository.Object);
            //  Procedimento

            //  Reusultado esperado

        }
    }
}
