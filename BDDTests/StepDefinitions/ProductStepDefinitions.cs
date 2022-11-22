using Domain.Models;
using System.Net.Http.Json;
using TechTalk.SpecFlow.Assist;

namespace BDDTests.StepDefinitions
{
    [Binding]
    public class ProductStepDefinitions
    {
        public BddTestsApplicationFactory _factory = new BddTestsApplicationFactory();
        public HttpClient _client { get; set; } = null!;
        private HttpResponseMessage _response { get; set; } = null!;

        public ProductStepDefinitions()
        {
            _client = _factory.CreateDefaultClient(new Uri($"http://localhost/"));
        }

        [Given(@"Database contains products :")]
        public void GivenDatabaseContainsProducts(Table table)
        {
            var products = table.CreateSet<Product>();
            _factory.ProductRepository.Init(products);
        }

        [When(@"A call is made to '([^']*)'")]
        public async Task WhenACallIsMadeTo(string path)
        {
            _response = await _client.GetAsync(path);
        }

        [Then(@"The Result Should be :")]
        public async Task ThenTheResultShouldBe(Table table)
        {
            var expected = table.CreateSet<Product>();
            var actual = await _response.Content.ReadFromJsonAsync<List<Product>>();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
