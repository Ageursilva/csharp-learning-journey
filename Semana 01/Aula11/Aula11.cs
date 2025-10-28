using System;

// TypeCast
class Aula11
{
    static void Main()
    {
        Console.WriteLine("--- Exemplos de Typecasting em C# ---");
        Console.WriteLine("-----------------------------------");

        float n1 = 10.5f; // f de float
        int n2 = (int)n1; // type cast explícito de float para int
        Console.WriteLine("\nSeu exemplo original:");
        Console.WriteLine("float n1 = " + n1);
        Console.WriteLine("int n2 = (int)n1; -> n2: " + n2); // Saída: 10 (perda de decimal)


        // 1. Conversão Implícita (sem perda de dados, automática)
        Console.WriteLine("\n1. Conversão Implícita:");
        byte b = 150;
        int i = b; // byte para int
        Console.WriteLine("byte (150) para int (i): " + i);

        int meuInt = 75;
        double meuDouble = meuInt; // int para double
        Console.WriteLine("int (75) para double (meuDouble): " + meuDouble);

        char c = 'A';
        int charParaInt = c; // char para int (retorna o valor ASCII/Unicode)
        Console.WriteLine("char ('A') para int (charParaInt): " + charParaInt); // Saída: 65


        // 2. Conversão Explícita (casting com parênteses)
        Console.WriteLine("\n2. Conversão Explícita (Casting):");
        double dbl = 123.99;
        int intDoDbl = (int)dbl; // double para int (perde decimal)
        Console.WriteLine("double (123.99) para int (intDoDbl): " + intDoDbl);

        long l = 12345678912345L;
        // int intDoLong = (int)l; // CUIDADO: Isso pode causar overflow se 'l' for muito grande
        // Console.WriteLine("long para int (intDoLong): " + intDoLong); // Saída incorreta ou overflow

        int intGrande = 300;
        byte byteDoInt = (byte)intGrande; // int (300) para byte (overflow, 300 > 255)
        Console.WriteLine("int (300) para byte (byteDoInt) - Overflow: " + byteDoInt); // Saída: 44 (300 % 256)

        int intOutroGrande = 256;
        byte byteDoOutroInt = (byte)intOutroGrande; // int (256) para byte (overflow, 256 > 255)
        Console.WriteLine("int (256) para byte (byteDoOutroInt) - Overflow: " + byteDoOutroInt); // Saída: 0 (256 % 256)


        // 3. Classe Convert
        Console.WriteLine("\n3. Métodos da classe Convert (System.Convert):");
        string strNum = "567";
        int numConvertido = Convert.ToInt32(strNum);
        Console.WriteLine("string (\"567\") para int (numConvertido): " + numConvertido);

        double valorDecimal = 78.50;
        string strValorDecimal = Convert.ToString(valorDecimal);
        Console.WriteLine("double (78.50) para string (strValorDecimal): " + strValorDecimal);

        // Convert para booleanos
        string strTrue = "True";
        bool boolConvertido = Convert.ToBoolean(strTrue);
        Console.WriteLine("string (\"True\") para bool (boolConvertido): " + boolConvertido);
        string strZero = "0";
        bool boolZero = Convert.ToBoolean(strZero); // "0" é false, qualquer outro número não-zero é true
        Console.WriteLine("string (\"0\") para bool (boolZero): " + boolZero);

        // Tentativa de conversão inválida (comenta para evitar FormatException)
        // string strInvalida = "hello";
        // int numInvalido = Convert.ToInt32(strInvalida); // Lançaria FormatException


        // 4. Métodos Parse() e TryParse()
        Console.WriteLine("\n4. Métodos Parse() e TryParse():");
        string strNumeroValido = "987";
        int parsedInt = int.Parse(strNumeroValido);
        Console.WriteLine("string (\"987\") com int.Parse(): " + parsedInt);

        // Usando TryParse (preferível para segurança)
        string strNumeroInvalido = "abc";
        int resultadoTryParse;
        bool sucessoParse = int.TryParse(strNumeroInvalido, out resultadoTryParse);
        // AQUI ESTAVA O PROBLEMA: string interpolada
        Console.WriteLine(string.Format("Tentando parse \"{0}\": Sucesso={1}, Resultado={2}",
                                        strNumeroInvalido, sucessoParse, resultadoTryParse));
        // Saída: Tentando parse "abc": Sucesso=False, Resultado=0 (valor padrão de int)

        string strNumeroValidoDecimal = "123.45";
        double parsedDouble;
        if (double.TryParse(strNumeroValidoDecimal, out parsedDouble))
        {
            // AQUI ESTAVA O PROBLEMA: string interpolada
            Console.WriteLine(string.Format("string (\"{0}\") para double: {1}", strNumeroValidoDecimal, parsedDouble));
        }
        else
        {
            Console.WriteLine(string.Format("Falha ao converter \"{0}\" para double.", strNumeroValidoDecimal));
        }


        // 5. Operadores 'as' e 'is' (para tipos de referência)
        Console.WriteLine("\n5. Operadores 'as' e 'is' (para tipos de referência):");
        object objString = "Isso é uma string";
        object objInt = 42;
        object objNull = null;

        // Usando 'as'
        string strResult1 = objString as string; // Sucesso
        string strResult2 = objInt as string;   // Falha, retorna null
        Console.WriteLine("objString como string ('as'): " + (strResult1 ?? "null"));
        Console.WriteLine("objInt como string ('as'): " + (strResult2 ?? "null"));

        // Usando 'is'
        if (objString is string)
        {
            Console.WriteLine("objString ('" + objString + "') É uma string.");
        }
        if (objInt is int)
        {
            Console.WriteLine("objInt ('" + objInt + "') É um int.");
        }
        if (objNull is string) // 'is' com null sempre é false
        {
             Console.WriteLine("objNull É uma string. (Nunca executa)");
        }
        else
        {
             Console.WriteLine("objNull NÃO É uma string (objNull is string retorna false).");
        }

        // Padrão de tipo 'is' com declaração de variável (C# 7.0+, pode dar erro no seu compilador C# 5)
        // if (objInt is int intValue)
        // {
        //     Console.WriteLine("objInt é int, e seu valor é: " + intValue);
        // }


        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine("Exemplos de Typecasting concluídos.");
    }
}