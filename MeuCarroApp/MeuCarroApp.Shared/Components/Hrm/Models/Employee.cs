using MeuCarroApp.Shared.Components.Core.Entities;
using MeuCarroApp.Shared.Components.WorkShops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Hrm.Models
{
    // Cargo - Position
    public class JobTile : BaseAuditableEntity
    {
        public WorkShop? WorkShop { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<EmployeePosition>? EmployeePositions { get; set; }
    }

    // Funcionário
    public class Employee : BaseAuditableEntity
    {
        public Person? Person { get; set; }
        public DateTime AdmissionDate { get; set; }
    }

    // Registro do cargo ocupado no período
    public class EmployeePosition : BaseAuditableEntity
    {
        public Employee? Employee { get; set; }
        public JobTile? JobTile { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    // Salário base do Funcionário de acordo com o contrato de Trabalho
    public class Salary : BaseAuditableEntity
    {
        public EmployeePosition? EmployeePosition { get; set; }
        public double SalaryAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    // Pagamento efetivo de Salário, vulgo Contra-cheque
    public class Payroll : BaseAuditableEntity
    {
        // Funcionário e Cargo relacionado
        public EmployeePosition? EmployeePosition { get; set; }
        // Salário base do funcionário
        public Salary? Salary { get; set; }
        // TODO: criar as funcionalidades que fazem os descontos (INSS, FGTS, PIS, etc)
        // Valor Total devido incluído os descontos
        public double TotalValue { get; set; }
        // Valor líquido que o funcionário irá receber diminuído os descontos
        public double NetTotal { get; set; }
        // Mês trabalhado pelo funcionário
        public DateTime ReferenceMonth { get; set; }
        // Data efetiva do pagamento
        public DateTime CreationDate { get; set; }
    }
}
