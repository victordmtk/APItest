using Refit;
using System;
using consumeAPIteste;

class program
{
    static async Task Main(string[] args)
    {
        try
        {//mapeamento da url
            var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
            Console.WriteLine("Informe seu Cep:");
            string cepInformado = Console.ReadLine().ToString();
            Console.WriteLine("Consultando Informações do CEP: " + cepInformado);
            var enderecoObtido = await cepClient.GetAddressAsync(cepInformado);
            Console.WriteLine($"\nLogradouro: {enderecoObtido.Logradouro},\nBairro:{enderecoObtido.Bairro},\nCidade:{enderecoObtido.Localidade}");


        }
        catch (Exception e)
        {
            Console.WriteLine("Erro na consulta");
        }
    }
}

