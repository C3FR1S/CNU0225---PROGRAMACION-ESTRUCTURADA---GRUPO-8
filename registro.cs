using System;

namespace ClinicaOdontologica
{
    public static class Registro
    {
        public static void RegistrarPaciente()
        {
            Paciente nuevoPaciente = new Paciente();

            Console.Write("Nombre: ");
            nuevoPaciente.Nombre = Console.ReadLine();

            Console.Write("Edad: ");
            nuevoPaciente.Edad = int.Parse(Console.ReadLine());

            Console.Write("Tratamiento: ");
            nuevoPaciente.Tratamiento = Console.ReadLine();

            Pacientes.ListaPacientes.Add(nuevoPaciente);
        }

        public static void MostrarPacientes()
        {
            foreach (var p in Pacientes.ListaPacientes)
            {
                Console.WriteLine($"Nombre: {p.Nombre}");
                Console.WriteLine($"Edad: {p.Edad}");
                Console.WriteLine($"Tratamiento: {p.Tratamiento}");
                Console.WriteLine("------------------------------");
            }
        }
    }
}
