using Microsoft.VisualBasic;

namespace entidades
{
    public class Persona
    {
        public int idpersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string imagenUrl { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool activo { get; set; }
        public int legajo { get; set; }
        public string Dni {  get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime? fechaBaja { get; set; }
        public string email { get; set; }
        public int? idDomicilio { get; set; }
        public Persona()

        {
        }
        public Persona(int idpersona,string nombre,string apellido,string imagenUrl,DateTime fechaNacimiento,bool activo,int legajo,string dni,DateTime fechaAlta,DateTime? fechaBaja,string email,int? idDomicilio)
        {
            this.idpersona = idpersona;
            this.nombre = nombre;
            this.apellido = apellido;
            this.imagenUrl=imagenUrl;
            this.FechaNacimiento = fechaNacimiento;
            this.activo = activo;
            this.legajo = legajo;
            this.Dni = dni;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.email = email;
            this.idDomicilio = idDomicilio;
        }
     
}}
