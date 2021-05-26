using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial02.Context;
using Parcial02.Entities.Questions;

namespace Parcial02
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using (var db = new UcaClinicContext())
            {
                // Limpiando tablas antes de ingresar nuevos datos
                db.Users.RemoveRange(db.Users);
                db.Questions.RemoveRange(db.Questions);

                var questions = new List<Question>()
                {
                    new Question()
                    {
                        Id = "1",
                        SecurityQuestion = "¿En qué año naciste?",
                    },
                    new Question()
                    {
                        Id = "2",
                        SecurityQuestion = "¿Cómo se llamó tu primer mascota?",
                    },
                    new Question()
                    {
                        Id = "3",
                        SecurityQuestion = "¿De qué colegio te graduaste de bachiller?",
                    },
                    new Question()
                    {
                        Id = "4",
                        SecurityQuestion = "¿Nombre de tu película favorita?",
                    },
                };
                
                questions.ForEach(qt => db.Add(qt));
                db.SaveChanges();

            }
        }
    }
}