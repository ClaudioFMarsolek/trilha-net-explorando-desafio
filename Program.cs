using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Bruno", sobrenome: "Ferreira");
Pessoa p2 = new Pessoa(nome: "Leticia", sobrenome: "Ferreira");
Pessoa p3 = new Pessoa(nome: "Thomas", sobrenome: "Ferreira");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 100);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Hóspedes Registrados: \n {p1.NomeCompleto} \n {p2.NomeCompleto} \n {p3.NomeCompleto}");
Console.WriteLine($"Valor a pagar: {reserva.CalcularValorDiaria().ToString("n2")}");