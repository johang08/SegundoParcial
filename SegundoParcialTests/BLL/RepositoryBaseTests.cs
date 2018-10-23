using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SegundoParcial.BLL.Tests
{
    [TestClass()]
    public class RepositoryBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.IDVendedor = 1;
            vendedor.Nombre = "8FI9";
            vendedor.Retecion = 15;
            vendedor.Sueldo = 2100;
            vendedor.Total = 12021;
            RepositoryBase<Vendedor> repository;
            repository = new RepositoryBase<Vendedor>();
            Assert.IsTrue(repository.Guardar(vendedor));
        }
    }
}