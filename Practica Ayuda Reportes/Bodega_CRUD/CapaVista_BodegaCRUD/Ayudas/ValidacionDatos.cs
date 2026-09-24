using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CapaVista_BodegaCRUD.Ayudas
{
    // Envuelve el mecanismo de DataAnnotations para reutilizarlo con
    // cualquier objeto del Controlador que venga decorado con [Required], etc.
    public class ValidacionDatos
    {
        private readonly ValidationContext contexto;
        private readonly List<ValidationResult> resultados;
        private readonly bool valido;

        public ValidacionDatos(object instancia)
        {
            contexto = new ValidationContext(instancia);
            resultados = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, contexto, resultados, true);
        }

        public bool Validar()
        {
            if (!valido)
            {
                string mensaje = string.Empty;
                foreach (ValidationResult item in resultados)
                {
                    mensaje += item.ErrorMessage + "\n";
                }
                MessageBox.Show(mensaje, "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return valido;
        }
    }
}
