using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Data;
using Ap2.Menus;

namespace Ap2.Menus
{
    public class IndexMenu
    {
        private DataContext db;
        private MenuDoctor menuDoctor;
        private MenuPatient menuPatient;
        private MenuMedicalAppoiment menuAppoiment;

        public IndexMenu(DataContext db, MenuDoctor menuDoctor, MenuPatient menuPatient, MenuMedicalAppoiment menuAppoiment)
        {
            this.db = db;
            this.menuDoctor = menuDoctor;
            this.menuPatient = menuPatient;
            this.menuAppoiment = menuAppoiment;
        }



        // public IndexMenu()
        // {
        //     db = new DataContext();
        //     menuDoctor = new MenuDoctor();
        //     menuPatient = new MenuPatient();
        //     menuAppoiment = new MenuMedicalAppoiment();
        // }


        public void MenuIndex()
        {
             while(true)
        {
            Show("");
            Show("Digite a opção desejada:");
            Show("1 - Abrir Menu médico!");
            Show("2 - Abrir Menu paciente!");
            Show("3 - Abrir Menu Consulta!");
            Show("0 - Sair");
            Show("");

            int opcao = int.Parse(Console.ReadLine()!);

            switch(opcao)
            {
                case 1:
                    menuDoctor.DoctorMenu();
                break;
                case 2:
                    menuPatient.PatientMenu();
                break;
                case 3:
                    menuAppoiment.AppoimentMenu();
                break;
                case 0:
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Opção inválida!");
                break;
            }
        }
        }

       

    void Show(string msg)
    {
        Console.WriteLine(msg);
    }

    }
    }
