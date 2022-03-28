using System;

class Program {
  public static void Main (string[] args) {

    Calendario data = new Calendario();

    do
    {
      byte meses = 0;
      Console.Write("Informe o mês: ");
      Byte.TryParse(Console.ReadLine(), out meses);

      data.Mes = meses;
      if (data.isMesValido() == false)
      {
        Console.WriteLine("\n>> Esse não é um mês válido. Ele deve seguir um formato numérico padrão, de '1' a '12': Janeiro - 1; Fevereiro - 2; Março - 3 ...\n");
      }

    } while (data.isMesValido() == false);

    do
    {
      short anos = 0;
      Console.Write("Informe o ano: ");
      Int16.TryParse(Console.ReadLine(), out anos);

      data.Ano = anos;
      if (data.isAnoValido() == false)
      {
        Console.WriteLine("\n>> Esse não é um ano válido. Ele deve seguir um formato numérico padrão, de '1' a '9999': 2022, 2021, 2020...\n");
      }

    } while (data.isAnoValido() == false);

    data.Month = Convert.ToByte(data.Mes);
    data.Year = Convert.ToUInt16(data.Ano);

    Console.WriteLine(data.gerarCalendario());

  }
}