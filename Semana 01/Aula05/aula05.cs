using System;
//Operadores aritméticos, lógicos e de comparação.
class Aula05
{
    static void Main()
    {
        Console.WriteLine("--- Exemplos de Operadores em C# ---");
        Console.WriteLine("-----------------------------------");

        // 1. Operadores Aritméticos: Usados para realizar operações matemáticas.
        Console.WriteLine("\n1. Operadores Aritméticos:");
        int a = 10;
        int b = 3;
        int c = 5;

        int soma = a + b;           // Adição: 10 + 3 = 13
        int subtracao = a - b;      // Subtração: 10 - 3 = 7
        int multiplicacao = a * b;  // Multiplicação: 10 * 3 = 30
        int divisao = a / b;        // Divisão: 10 / 3 = 3 (divisão de inteiros trunca)
        int modulo = a % b;         // Módulo (resto da divisão): 10 % 3 = 1

        Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
        Console.WriteLine("a + b = " + soma);
        Console.WriteLine("a - b = " + subtracao);
        Console.WriteLine("a * b = " + multiplicacao);
        Console.WriteLine("a / b = " + divisao + " (divisão inteira)");
        Console.WriteLine("a % b = " + modulo);

        // Operadores de incremento e decremento (unários)
        int num = 5;
        num++; // Incrementa num em 1 (num agora é 6)
        Console.WriteLine("num++ (incremento): " + num);
        num--; // Decrementa num em 1 (num agora é 5)
        Console.WriteLine("num-- (decremento): " + num);

        // Ordem de precedência: Multiplicação/Divisão antes da Adição/Subtração
        int resultadoPrecedencia = (a + b) * c; // (10 + 3) * 5 = 13 * 5 = 65
        Console.WriteLine("(a + b) * c = " + resultadoPrecedencia);


        // 2. Operadores de Atribuição: Usados para atribuir valores a variáveis.
        Console.WriteLine("\n2. Operadores de Atribuição:");
        int x = 20; // Atribuição simples
        Console.WriteLine("x = 20 -> x: " + x);

        x += 5; // x = x + 5; (x agora é 25)
        Console.WriteLine("x += 5 -> x: " + x);

        x -= 10; // x = x - 10; (x agora é 15)
        Console.WriteLine("x -= 10 -> x: " + x);

        x *= 2; // x = x * 2; (x agora é 30)
        Console.WriteLine("x *= 2 -> x: " + x);

        x /= 3; // x = x / 3; (x agora é 10)
        Console.WriteLine("x /= 3 -> x: " + x);

        x %= 3; // x = x % 3; (x agora é 1)
        Console.WriteLine("x %= 3 -> x: " + x);


        // 3. Operadores de Comparação (Relacionais): Usados para comparar dois valores.
        // O resultado é sempre um valor booleano (true ou false).
        Console.WriteLine("\n3. Operadores de Comparação (Relacionais):");
        int val1 = 15;
        int val2 = 10;
        int val3 = 15;

        bool igual = (val1 == val2); // 15 é igual a 10? False
        bool diferente = (val1 != val2); // 15 é diferente de 10? True
        bool maiorQue = (val1 > val2); // 15 é maior que 10? True
        bool menorQue = (val1 < val2); // 15 é menor que 10? False
        bool maiorOuIgual = (val1 >= val3); // 15 é maior ou igual a 15? True
        bool menorOuIgual = (val1 <= val2); // 15 é menor ou igual a 10? False

        Console.WriteLine("val1 = " + val1 + ", val2 = " + val2 + ", val3 = " + val3);
        Console.WriteLine("val1 == val2: " + igual);
        Console.WriteLine("val1 != val2: " + diferente);
        Console.WriteLine("val1 > val2: " + maiorQue);
        Console.WriteLine("val1 < val2: " + menorQue);
        Console.WriteLine("val1 >= val3: " + maiorOuIgual);
        Console.WriteLine("val1 <= val2: " + menorOuIgual);

        // Seu exemplo original:
        bool resOriginal = 10 < 5;
        Console.WriteLine("Seu exemplo original (10 < 5): " + resOriginal);


        // 4. Operadores Lógicos: Usados para combinar ou inverter condições booleanas.
        Console.WriteLine("\n4. Operadores Lógicos:");
        bool condicao1 = true;
        bool condicao2 = false;
        bool condicao3 = true;

        bool E_logico = condicao1 && condicao2; // AND lógico: true && false = False
        bool OU_logico = condicao1 || condicao2; // OR lógico: true || false = True
        bool NOT_logico = !condicao1;         // NOT lógico (negação): !true = False
        bool E_logico_composto = (condicao1 && condicao3); // true && true = True

        Console.WriteLine("condicao1 = " + condicao1 + ", condicao2 = " + condicao2 + ", condicao3 = " + condicao3);
        Console.WriteLine("condicao1 && condicao2: " + E_logico);
        Console.WriteLine("condicao1 || condicao2: " + OU_logico);
        Console.WriteLine("!condicao1: " + NOT_logico);
        Console.WriteLine("(condicao1 && condicao3): " + E_logico_composto);


        // 5. Operador Condicional Ternário: Uma forma concisa de if/else.
        // Sintaxe: condição ? valor_se_verdadeiro : valor_se_falso;
        Console.WriteLine("\n5. Operador Condicional Ternário:");
        int idade = 18;
        string statusIdade = (idade >= 18) ? "Maior de idade" : "Menor de idade";
        Console.WriteLine("Idade: " + idade + " -> Status: " + statusIdade);

        int temperatura = 25;
        string recomendacao = (temperatura > 30) ? "Muito quente!" : (temperatura < 10 ? "Muito frio!" : "Temperatura agradável.");
        Console.WriteLine("Temperatura: " + temperatura + " -> Recomendação: " + recomendacao);


        // 6. Operadores Bitwise (operam em bits individuais dos números)
        Console.WriteLine("\n6. Operadores Bitwise:");
        // Para simplificar, usaremos inteiros e mostraremos o resultado decimal
        // Exemplo: 5 (0101 em binário) e 3 (0011 em binário)
        int valA = 5; // 0101
        int valB = 3; // 0011

        int bitwiseAND = valA & valB;   // 0101 & 0011 = 0001 (1)
        int bitwiseOR = valA | valB;    // 0101 | 0011 = 0111 (7)
        int bitwiseXOR = valA ^ valB;   // 0101 ^ 0011 = 0110 (6)
        int bitwiseNOT_A = ~valA;       // ~0101 = 1010 (em complemento de dois, -6)
        int shiftLeft = valA << 1;      // 0101 << 1 = 1010 (10) - equivalente a multiplicar por 2
        int shiftRight = valA >> 1;     // 0101 >> 1 = 0010 (2) - equivalente a dividir por 2

        Console.WriteLine("valA = " + valA + " (0101), valB = " + valB + " (0011)");
        Console.WriteLine("valA & valB (AND): " + bitwiseAND);
        Console.WriteLine("valA | valB (OR): " + bitwiseOR);
        Console.WriteLine("valA ^ valB (XOR): " + bitwiseXOR);
        Console.WriteLine("~valA (NOT): " + bitwiseNOT_A); // Cuidado com inteiros sinalizados!
        Console.WriteLine("valA << 1 (Shift Left): " + shiftLeft);
        Console.WriteLine("valA >> 1 (Shift Right): " + shiftRight);


        // 7. Operadores de Tipo (Type Operators)
        Console.WriteLine("\n7. Operadores de Tipo:");
        object obj = "Olá Mundo"; // obj é um string
        object numObj = 123;      // numObj é um int

        // is: Verifica se um objeto é compatível com um determinado tipo.
        bool isString = obj is string;   // true
        bool isInt = obj is int;         // false
        Console.WriteLine("obj é string? " + isString);
        Console.WriteLine("obj é int? " + isInt);

        // as: Tenta converter um objeto para um tipo específico. Se a conversão falhar, retorna null.
        // No C# 5, o operador 'as' para int? não é tão direto, pois int é tipo de valor.
        // Podemos testar com string para ilustrar, ou usar boxing/unboxing e casting.
        string str = obj as string;
        // int? inteiro = numObj as int?; // Isso não funciona diretamente em C# 5 com tipos de valor
        // Para C# 5, você faria assim para converter para um int (com possível exceção)
        int inteiroConvertido = (numObj is int) ? (int)numObj : 0; // Exemplo de como lidar sem o 'as int?'
        string outroStr = numObj as string; // outroStr será null (numObj não é string)

        Console.WriteLine("Convertido para string (com 'as'): " + (str ?? "null"));
        Console.WriteLine("Convertido para int (com casting explícito): " + inteiroConvertido);
        Console.WriteLine("Tentando converter numObj para string (com 'as'): " + (outroStr ?? "null"));


        // 8. Operador null-coalescing (??)
        // Usado para definir um valor padrão para tipos anuláveis ou referências nulas.
        Console.WriteLine("\n8. Operador null-coalescing (??):");
        string nomeUsuario = null;
        string nomeExibido = nomeUsuario ?? "Visitante"; // Se nomeUsuario for null, usa "Visitante"
        Console.WriteLine("Nome do usuário: " + nomeExibido);

        string nomeReal = "João";
        string outroNomeExibido = nomeReal ?? "Convidado"; // Se nomeReal não for null, usa nomeReal
        Console.WriteLine("Outro nome: " + outroNomeExibido);

        // Operador null-coalescing de atribuição (??=) - Introduzido no C# 8.0, NÃO funciona no C# 5.
        // Para C# 5, você precisaria de um 'if' explícito:
        string configuracao = null;
        if (configuracao == null)
        {
            configuracao = "Padrão";
        }
        Console.WriteLine("Configuração: " + configuracao);

        configuracao = "Personalizada";
        if (configuracao == null) // Esta condição não será verdadeira aqui
        {
            configuracao = "Novo Padrão";
        }
        Console.WriteLine("Configuração (após atribuição condicional manual): " + configuracao);


        // 9. Operador de chamada condicional de nulos (Null-conditional operator) (?.)
        // C# 6.0+. NÃO funciona no C# 5.
        // Para C# 5, você precisaria de verificações de nulo explícitas:
        Console.WriteLine("\n9. Operador de chamada condicional de nulos (?.): (Requere C# 6 ou superior)");
        string texto = "Teste";
        string textoNulo = null;

        // Equivalente a:
        int? comprimento1 = (texto != null) ? (int?)texto.Length : null;
        int? comprimento2 = (textoNulo != null) ? (int?)textoNulo.Length : null;

        Console.WriteLine("Comprimento de 'Teste': " + (comprimento1.HasValue ? comprimento1.ToString() : "null"));
        Console.WriteLine("Comprimento de 'null': " + (comprimento2.HasValue ? comprimento2.ToString() : "0")); // Usa para exibir 0 em vez de null

        string resultadoUpper = (textoNulo != null) ? textoNulo.ToUpper() : null;
        Console.WriteLine("ToUpper em nulo: " + (resultadoUpper ?? "null"));


        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine("Exemplos concluídos.");
    }
}