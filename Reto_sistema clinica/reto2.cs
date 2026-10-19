Console.WriteLine("¿Cómo te llamas?");
string nombre = Console.ReadLine(); // Guarda lo que el usuario escriba
Console.WriteLine("Hola, " + nombre);
Console.WriteLine("=== Reporte de Atención Veterinaria ===");

string especieMascota = "perro";   // "perro", "gato", "conejo", "reptil"
int edadMascota = 7;               // edad en años
double peso = 28.5;                // peso en kilogramos
bool tieneVacunasAlDia = false;
bool esSocio = true;
string motivoConsulta = "cirugia"; // "vacuna", "revision", "cirugia", "urgencia"
string alertaVacuna;
decimal costoBase;
string recomendacion;

string etapaVida = edadMascota switch
{    < 1 => "Cachorro",
    >= 1 and <= 3 => "Joven",
    >= 4 and < 8 => "Adulto",
    > 8 => "Senior",
};

if ((especieMascota is "perro" or "gato") && !tieneVacunasAlDia)
{
  alertaVacuna = "ALERTA: vacunación urgente requerida";  
}
else if ((especieMascota is "perro" or "gato") && tieneVacunasAlDia)
{
    alertaVacuna = "Vacunación al día";
}
else
{
    alertaVacuna = "Esquema de vacunación no aplica";
};


switch (motivoConsulta)
{
    case "vacuna":
    costoBase = 35000;
    break;
    
    case "revision":
    costoBase = 50000;
    break;

    case "cirugia":
    costoBase = 280000;
    break;

    case "urgencia":
    costoBase = 150000;
    break;

    default:
    costoBase = 0;
    break;
}

double porcentajeDescuento = esSocio && peso > 25 ? 15.0 : esSocio ? 10.0 : 0.0;
decimal descuento = costoBase * (decimal)(porcentajeDescuento / 100);
decimal costoFinal = costoBase - descuento;

if (motivoConsulta is "cirugia")
{
    if (etapaVida is "Senior")
    {
        recomendacion = "Reposo absoluto por 10 días, control post-operatorio obligatorio";
    }
    else
    {
        recomendacion = "Reposo por 5 días, evitar ejercicio intenso";
    }
}
else if (motivoConsulta is "urgencia")
{
    if (!tieneVacunasAlDia)
    {
        recomendacion = "Atender urgencia y programar vacunación inmediata";
    }
    else
    {
        recomendacion = "Seguimiento en 48 horas";
    }
}
else
{
    recomendacion = "Seguimiento en próxima consulta de rutina";
}

Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} | Etapa: {etapaVida}");
Console.WriteLine($"Estado de vacunación:{alertaVacuna}");
Console.WriteLine($"Motivo: {motivoConsulta} | Costo base: ${costoBase}");
Console.WriteLine($"Descuento: {porcentajeDescuento}% | Costo Final: ${costoFinal}");
Console.WriteLine($"Recomendacio: {recomendacion}");