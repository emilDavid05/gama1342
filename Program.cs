// See https://aka.ms/new-console-template for more information


empleados empleados = new empleados();
salario salario = new salario();

empleados.id = 101;
empleados.Nombre = "Eliseo Monteverde";
empleados.Cargo = "Analista fiananciero";
empleados.Pago_hora = 1500;
salario.Diastrabajados = 10;


//llamada a el metodo calcular salario del objeto salario.

double resultado = salario.CalcularSalario (empleados.Pago_hora, salario.Diastrabajados);

Console.WriteLine("ID: 48 " + empleados.id);
Console.WriteLine("Nombre:emil" + empleados.id);
Console.WriteLine("Cargo: Gerente " + empleados.id);
Console.WriteLine("Pago por hora:" + empleados.id);
Console.WriteLine("Dias trabajados:" + empleados.id);
Console.WriteLine($"El sueldo del empleado es {resultado}");
  
class empleados
{
    public int id { get; set; }
    public string Nombre { get; set; }

    public string Cargo { get; set; }

    public int Pago_hora { get; set; }

}

class salario
{
     public int Diastrabajados { get; set; }

    //Metodo para calcular el salario

    public double CalcularSalario(double ph, int dt)
    {
        double resultado = ph * dt;
        return resultado;
    
    }
}