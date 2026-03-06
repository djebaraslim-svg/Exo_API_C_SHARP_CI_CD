using API_SIMPLE_CI_CD.Service;

namespace TestUnitaire
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {        
            AdditionService service = new AdditionService();
            int nb1 = 40;
            int nb2 = 2;
           
            int resultat = service.Addition(nb1,nb2);

            Assert.Equal(42, resultat);
        }
    }
}