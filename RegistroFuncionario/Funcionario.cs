using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace RegistroFuncionario
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salario { get; set; }


        public Funcionario(int id, string name,double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }
        public void Soma(double aumento)
        {
            Salario += Salario * aumento / 100.0;
        }
        public override string ToString()
        {
            return Id 
                + ", "
                + Name
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
