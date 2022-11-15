using bytebank;
using bytebank.Titular;

//ContaCorrente contadoAndre = new ContaCorrente();
//contadoAndre.titular = "André Silva";
//contadoAndre.numeroAgencia = 15;
//contadoAndre.conta = "1010-X";
//contadoAndre.saldo = 100;

//Console.WriteLine($"Titular da Conta: {contadoAndre.titular}");
//Console.WriteLine($"Número da Conta: {contadoAndre.conta} ");
//Console.WriteLine($"Agência: {contadoAndre.numeroAgencia}");
//Console.WriteLine($"Saldo $ {String.Format("{0:0.00}", contadoAndre.saldo)}");

//ContaCorrente contadaAna = new ContaCorrente();
//contadaAna.titular = "Ana Souza";
//contadaAna.numeroAgencia = 19;
//contadaAna.conta = "2135-B";
//contadaAna.saldo = 430;
/*
Console.WriteLine($"Titular da Conta: {contadaAna.titular}");
Console.WriteLine($"Número da conta: {contadaAna.conta}");
Console.WriteLine($"Agência: {contadaAna.numeroAgencia}");
Console.WriteLine($"Saldo $ {String.Format("{0:0.00}", contadaAna.saldo)}");
*/
//contadaAna.exibirDadosConta();

//contadoAndre.Depositar(100);

//Console.WriteLine($"Saldo do André pós-deposito: $ {contadoAndre.saldo}");


//if (contadoAndre.Sacar(300) == true)
//{
//    Console.WriteLine($"Saldo do Andre pós-saque: $ {contadoAndre.saldo}");
//}

//contadoAndre.Transferir(50, contadaAna);
//Console.WriteLine($"Saldo conta do André: $ {contadoAndre.saldo}");
//Console.WriteLine($"Saldo conta da Ana: $ {contadaAna.saldo}");

////------------- CRIANDO CONTA ---------------------
//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente(19, "1010-x");
//conta.titular = cliente;
//conta.setSaldo(100);


//conta.exibirDadosConta();
////-------------------------------------------------

////-------------- CRIANDO CONTA 2 ------------------
//ContaCorrente conta2 = new ContaCorrente(18, "1012-B");
//conta2.titular = new Cliente();

//conta2.titular.nome = "José Perreira";
//conta2.titular.cpf = "123413666789";
//conta2.titular.profissao = "Pedreiro";

//conta2.setSaldo(100);

//conta2.Depositar(300);

//conta2.exibirDadosConta();

//Console.WriteLine(conta2.getSaldo());
////-------------------------------------------------

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-2");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(285, "1111-2");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);