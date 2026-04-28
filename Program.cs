// ===============================================
// SISTEMA DE INVENTARIO - CLASE 1.1
// Estado: mensaje de bienvenida
// ===============================================
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("==========================================");
Console.WriteLine("    SISTEMA DE GESTIÓN DE INVENTARIO      ");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine($"Version: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}"); // Sistema operativo que estamos usando
Console.WriteLine($".NET Version: {Environment.Version}"); // Version del framework que estamos usando
Console.WriteLine();
Console.WriteLine("Estructura del proyecto");
Console.WriteLine("Configuración csproj");
Console.WriteLine("Carpeta src/ creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine();
Console.WriteLine("Proximos pasos: agregar argumentos CLI y configuración del repositorio en GIthub");