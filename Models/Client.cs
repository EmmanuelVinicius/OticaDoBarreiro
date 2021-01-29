using System;

namespace otica_do_barreiro.Models
{
    public class Client
    {
        public int id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String CPF { get; set; }
        public String ModeloOculos { get; set; }
        public int CodigoCompra { get; set; }
        public DateTime UltimaManutencao { get; set; }
        public DateTime ProximoContato { get; set; }
        public Boolean isActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
