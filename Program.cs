// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("My names is Lizandro");

/* Tipos mais utilizados 
bool b;
char c;
byte by;
int i;
long l;
float f;
double d;
decimal dec;
string s;

b = true;
c = 'd';
by = 255;
l = -9223372036854775808;
f = 3.4028235E+38f;
d = 1.7976931348623157E+308;
dec = 7922816251426433759;
s = "Lizandro";

int i2 = i = 2147483647;

Console.WriteLine(i2);

int ternario;

ternario = 10;

int result = ternario == 10 ? 20 : 10;

Console.WriteLine(result);

*/

// Console.BackgroundColor = ConsoleColor.Blue;
// Console.WriteLine("Lizandro");

// Calcular IMC

float abaixoDoPeso = 18.5f;
float pesoNormal = 24.9f;
float excessoDePeso = 29.9f;
byte obesidade = 30;
byte obesidadeExtrema = 35;

Console.Write("Digite seu peso: ");
float peso = float.Parse(Console.ReadLine());
Console.Write("Digite sua altura: ");
float altura = float.Parse(Console.ReadLine());

float IMCAtual = (float)Math.Round(peso / (altura * altura), 2);
byte IMCIdeal = 22;
float kgNecesario = (float)Math.Round(IMCIdeal * altura * altura, 2);

// Math.Raoud assim como javascript existe o objeto Math com o metodo   Round que arredonda o valor flutuante, Round(var , casasDecimais)
// Exemplo:
// float valorFlutuante = 2.566f;
// float valorArredondadoDuasCasas = Math.Round(valorFlutuante, 2);
// Sainda: 2.57


Console.WriteLine($"Seu Peso: {peso}");
Console.WriteLine($"Sua Altura: {altura}");
Console.WriteLine($"Seu IMC: {IMCAtual}");

if (IMCAtual < abaixoDoPeso)
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Você Está abaixo do peso! ");
    kgNecesario -= peso;
    Console.WriteLine($"Você Precisa ganhar {Math.Round(kgNecesario, 2)}Kg para chegar no peso adequado para a sua altura!");
}
else if (IMCAtual < pesoNormal)
{
    Console.BackgroundColor = ConsoleColor.Green;
    Console.WriteLine("Você Está com o peso normal! ");
}
else if(IMCAtual < excessoDePeso)
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Você está com exesso de peso! ");
    kgNecesario = peso - kgNecesario;
    Console.WriteLine($"Você Precisa perder {Math.Round(kgNecesario, 2)}Kg para chegar no peso adequado para a sua altura!");
}
else if(IMCAtual > obesidade || IMCAtual < obesidadeExtrema)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Você está na faixa da Obesidade!");
    kgNecesario = peso - kgNecesario;
    Console.WriteLine($"Você Precisa perder {Math.Round(kgNecesario, 2)}Kg para chegar no peso adequado para a sua altura!");
}
else if (IMCAtual > obesidadeExtrema)
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você está na faixa da Obesidade extrema!");
    kgNecesario = peso - kgNecesario;
    Console.WriteLine($"Você Precisa perder {Math.Round(kgNecesario, 2)}Kg para chegar no peso adequado para a sua altura!");
}
else
{
    Console.WriteLine("Hocorreu algum erro em seu calculo IMC!");
}

