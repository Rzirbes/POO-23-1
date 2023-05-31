using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Data;
using Ap2.Data.Repository;
using Ap2.Domain.Entities;

namespace Ap2.Menus
{
    public class MenuPatient
    {
        private DataContext db;
        private PatientRepository patientRepository;

        public MenuPatient(DataContext db, PatientRepository patientRepository)
        {
            this.db = db;
            this.patientRepository = patientRepository;
        }

        // public MenuPatient()
        // {
        //     db = new DataContext();
        //     patientRepository = new PatientRepository(db);
        // }
        public void PatientMenu()
        {
            while (true)
            {
                Show("");
                Show("Digite a opção desejada:");
                Show("1 - Fazer cadastro");
                Show("2 - Exibir todos os pacientes");
                Show("3 - Alterar um cadastro pelo ID");
                Show("4 - Excluir um cadastro");
                Show("5 - Para retornar ao menu anterior");
                Show("0 - Sair do programa");
                Show("");

                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        insertPatient();
                        break;
                    case 2:
                        ShowPatient();
                        break;
                    case 3:
                        AlterPatient();
                        break;
                    case 4:
                        DeletePatient();
                        break;
                    case 5:
                        return;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

        }
        private void insertPatient()
        {
            Show("Digite seu nome");
            string patientName = Console.ReadLine()!;
            Show("Digite seu telefone");
            string patientPhone = Console.ReadLine()!;
            Show("Digite seu CPF");
            string patientCPF = Console.ReadLine()!;
            Show("Digite sua Doença");
            string patientIllness = Console.ReadLine()!;

            Patient patient = new Patient() { Name = patientName, CPF = patientCPF, Phone = patientPhone, Illness = patientIllness };

            patientRepository.Save(patient);
        }

        private void ShowPatient()
        {
            foreach (var patient in patientRepository.GetAll())
            {
                Show("============================================");
                Show($"ID do paciente: {patient.Id}, Nome do paciente: {patient.Name}, CPF: {patient.CPF}, Telefone: {patient.Phone}, Doença: {patient.Illness}");
                Show("============================================");
            }
        }

        private void AlterPatient()
        {
            Show("Digide o Id da pessoa que quer alterar o cadastro");
            int id = int.Parse(Console.ReadLine()!);

            Patient PatientUpdate = patientRepository.GetById(id)!;

            Patient oldPatient = PatientUpdate;
            Show("Digite seu nome");
            PatientUpdate.Name = Console.ReadLine()!;
            Show("Digite seu telefone");
            PatientUpdate.Phone = Console.ReadLine()!;
            Show("Digite seu CPF");
            PatientUpdate.CPF = Console.ReadLine()!;
            Show("Digite sua doença");
            PatientUpdate.Illness = Console.ReadLine()!;

            patientRepository.Update(oldPatient.Id, PatientUpdate);

        }

        private void DeletePatient()
        {
            Show("Digite o número de cadastro que quer excluir");
            int id = int.Parse(Console.ReadLine()!);
            Patient patientRemove = patientRepository.GetById(id)!;
            patientRepository.Delete(patientRemove);

        }
        void Show(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}