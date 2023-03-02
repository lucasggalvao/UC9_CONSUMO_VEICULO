double valorabastecido, kmrodado, valorlitro, consumo;

valorabastecido = 0;
kmrodado = 0;
valorlitro = 0;
consumo = 0;

Console.WriteLine("Qual o valor pago pelo abastecimento?");
valorabastecido = double.Parse(Console.ReadLine());

Console.WriteLine("Quantos KMs você percorreu com este abastecimento?");
kmrodado = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o valor do Litro de Combustível?");
valorlitro = double.Parse(Console.ReadLine());

consumo = kmrodado / (valorabastecido / valorlitro);

Console.WriteLine("O consumo do seu veículo é (KM / l): " + consumo);