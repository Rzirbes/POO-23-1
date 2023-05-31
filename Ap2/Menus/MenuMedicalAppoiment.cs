using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Data;
using Ap2.Data.Repository;
using Ap2.Domain.Entities;

namespace Ap2.Menus
{
    public class MenuMedicalAppoiment
    {

        private DataContext db;
        private MedicalAppoimentRepository medicalAppoimentRepository;
        private DoctorRepository doctorRepository;
        private PatientRepository patientRepository;

        public MenuMedicalAppoiment(DataContext db, MedicalAppoimentRepository medicalAppoimentRepository, DoctorRepository doctorRepository, PatientRepository patientRepository)
        {
            this.db = db;
            this.medicalAppoimentRepository = medicalAppoimentRepository;
            this.doctorRepository = doctorRepository;
            this.patientRepository = patientRepository;
        }

        // public MenuMedicalAppoiment()
        // {
        //     db = new DataContext();
        //     medicalAppoimentRepository = new MedicalAppoimentRepository(db);
        //     doctorRepository = new DoctorRepository(db);
        //     patientRepository = new PatientRepository(db);
        // }
        public void AppoimentMenu()
        {
            while (true)
            {
                Show("");
                Show("Digite a opção desejada:");
                Show("1 - Fazer cadastro de uma nova Consulta!");
                Show("2 - Exibir consultas agendadas!");
                Show("3 - Exibir consultas agendadas por id do paciente!");
                Show("4 - Apagar uma consulta agendada!");
                Show("5 - Para retornar ao menu anterior");
                Show("0 - Sair do programa");
                Show("");

                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        insertMedicalAppoiment();
                        break;
                    case 2:
                        ShowMedicalAppoiment();
                        break;
                    case 3:
                        DeleteMedicalAppoiment();
                        break;
                    case 4:
                        ShowAppoimentForPatient();
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

        private void insertMedicalAppoiment()
        {
            Show("Digite data e horário da consulta (formato: dd/mm/aaaa hh:mm:ss)");
            DateTime appoimentDate = DateTime.Parse(Console.ReadLine()!);
            if (medicalAppoimentRepository.CheckIfAppoimentExists(appoimentDate))
            {
                Show("Data de agendamento já existe, escolha outra data");
                return;
            }

            Doctor doctor = null!;
            while (doctor == null)
            {
                Show("Digite o id do médico");
                int doctorId = int.Parse(Console.ReadLine()!);
                doctor = doctorRepository.GetById(doctorId);
                if (doctor == null)
                {
                    Show("ID do médico inválido");
                }
            }

            Patient patient = null!;
            while (patient == null)
            {
                Show("Digite o id do paciente");
                int patientId = int.Parse(Console.ReadLine()!);
                patient = patientRepository.GetById(patientId);
                if (patient == null)
                {
                    Show("ID do paciente inválido");
                }
            }


            MedicalAppoiment medicalAppoiment = new MedicalAppoiment() { AppoimentDate = appoimentDate, Doctor = doctor, Patient = patient };

            medicalAppoimentRepository.Save(medicalAppoiment);
        }

        private void ShowMedicalAppoiment()
        {
            foreach (var medicalAppoiment in medicalAppoimentRepository.GetAll())
            {
                Show("============================================");
                Show($"Código da consulta: {medicalAppoiment.Id}");

                if (medicalAppoiment.Patient != null)
                {
                    Show($"Nome do paciente: {medicalAppoiment.Patient.Name}, Doença: {medicalAppoiment.Patient.Illness}");
                    Show($"CPF: {medicalAppoiment.Patient.CPF}");
                    Show($"Telefone do Paciente: {medicalAppoiment.Patient.Phone}");
                }

                if (medicalAppoiment.Doctor != null)
                {
                    Show($"Nome do Médico: {medicalAppoiment.Doctor.Name}, CRM: {medicalAppoiment.Doctor.CRM}");
                }

                Show($"Hora da consulta: {medicalAppoiment.AppoimentDate.ToString()}");
                Show("============================================");
            }
        }



        // private void ShowMedicalAppoiment()
        // {
        //     foreach (var medicalAppoiment in medicalAppoimentRepository.GetAll())
        //     {
        //         Show("============================================");
        //         Show($"Código da consulta: {medicalAppoiment.Id}");

        //         if (medicalAppoiment.Patient != null)
        //         {
        //             Show($"Nome do paciente: {medicalAppoiment.Patient.Name}, Doença: {medicalAppoiment.Patient.Illness}");
        //             Show($"CPF: {medicalAppoiment.Patient.CPF}");
        //             Show($"Telefone do Paciente: {medicalAppoiment.Patient.Phone}");
        //         }

        //         if (medicalAppoiment.Doctor != null)
        //         {
        //             Show($"Nome do Médico: {medicalAppoiment.Doctor.Name}, CRM: {medicalAppoiment.Doctor.CRM}");
        //         }

        //         Show($"Hora da consulta: {medicalAppoiment.AppoimentDate.ToString()}");
        //         Show("============================================");
        //     }
        // }


        private void DeleteMedicalAppoiment()
        {
            Show("Digite o número de cadastro que quer excluir");
            int id = int.Parse(Console.ReadLine()!);
            MedicalAppoiment appoimentRemove = medicalAppoimentRepository.GetById(id)!;
            medicalAppoimentRepository.Delete(appoimentRemove);

        }

        private void ShowAppoimentForPatient()
        {
            Show("Digite o id do paciente que deseja consultar: ");
            int idPatient = int.Parse(Console.ReadLine()!);
            patientRepository.GetById(idPatient);
            foreach (var appoiment in medicalAppoimentRepository.GetAll())
            {
                if (idPatient == appoiment.Patient.Id)
                {
                    Show("============================================");
                    Show($"Código da consulta: {appoiment.Id}");
                    Show($"Nome do paciente: {appoiment.Patient.Name}, Doença: {appoiment.Patient.Illness}");
                    Show($"CPF: {appoiment.Patient.CPF}");
                    Show($"Nome do Médico: {appoiment.Doctor.Name}, CRM: {appoiment.Doctor.CRM}");
                    Show($"Hora da consulta: {appoiment.AppoimentDate.ToString()}");
                    Show($"Telefone do Paciente: {appoiment.Patient.Phone}");
                    Show("============================================");
                }
            }

        }
        void Show(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}