using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2.Data;
using Ap2.Data.Repository;
using Ap2.Domain.Entities;

namespace Ap2.Menus
{
    public class MenuDoctor
    {

        private DataContext db;
        private DoctorRepository doctorRepository;

        public MenuDoctor(DataContext db, DoctorRepository doctorRepository)
        {
            this.db = db;
            this.doctorRepository = doctorRepository;
        }

        // public MenuDoctor()
        // {
        //     db = new DataContext();
        //     doctorRepository = new DoctorRepository(db);
        // }



        public void DoctorMenu()
        {
        while(true)
        {
            Show("");
            Show("Digite a opção desejada:");
            Show("1 - Fazer cadastro");
            Show("2 - Exibir todos os médicos");
            Show("3 - Alterar um cadastro pelo ID");
            Show("4 - Excluir um cadastro");
            Show("5 - Para retornar ao menu anterior");
            Show("0 - Sair do programa");
            Show("");

            int opcao = int.Parse(Console.ReadLine()!);

            switch(opcao)
            {
                case 1:
                    insertDoctor();
                break;
                case 2:
                    ShowDoctor();
                break;
                case 3:
                    AlterDoctor();
                break;
                case 4:
                    DeleteDoctor();
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


        //Menu Médico ínicio

        private void insertDoctor()
        {
            Show("Digite seu nome");
            string doctorName = Console.ReadLine()!;
            Show("Digite seu telefone");
            string doctorPhone = Console.ReadLine()!;
            Show("Digite seu CPF");
            string doctorCPF = Console.ReadLine()!;
            Show("Digite seu CRM");
            string doctorCRM = Console.ReadLine()!;
            Show("Digite sua área de atuação");
            string doctorOccupationArea = Console.ReadLine()!;
            Show("Você possui uma especialização? (s/n)");
            string isSpecialization = Console.ReadLine()!;
            if (isSpecialization == "s")
            {
                Show("Qual área de especialização");
                string specialization = Console.ReadLine()!;

                Doctor doctor = new Doctor() { Name = doctorName, CPF = doctorCPF, Phone = doctorPhone, CRM = doctorCRM, OccupationArea = doctorOccupationArea, Specialization = specialization };
                doctorRepository.Save(doctor);
            }
            else
            {
                Doctor doctor = new Doctor() { Name = doctorName, CPF = doctorCPF, Phone = doctorPhone, CRM = doctorCRM, OccupationArea = doctorOccupationArea };
                doctorRepository.Save(doctor);
            }
        }

        private void ShowDoctor()
        {
            foreach (var doctor in doctorRepository.GetAll())
            {
                Show("============================================");
                Show($"Id: {doctor.Id}");
                Show($"Nome do médico: {doctor.Name}");
                Show($"CRM: {doctor.CRM}");
                Show($"Área de atuação: {doctor.OccupationArea}");
                Show($"Especialização: {doctor.Specialization}");
                Show("============================================");
            }
        }

        private void AlterDoctor()
        {
            Show("Digide o Id da pessoa que quer alterar o cadastro");
            int id = int.Parse(Console.ReadLine()!);

            Doctor doctorUpdate = doctorRepository.GetById(id)!;

            Doctor oldDoctor = doctorUpdate;
            Show("Digite seu nome");
            doctorUpdate.Name = Console.ReadLine()!;
            Show("Digite seu telefone");
            doctorUpdate.Phone = Console.ReadLine()!;
            Show("Digite seu CPF");
            doctorUpdate.CPF = Console.ReadLine()!;
            Show("Digite seu CRM");
            doctorUpdate.CRM = Console.ReadLine()!;
            Show("Digite seu área de atuação");
            doctorUpdate.OccupationArea = Console.ReadLine()!;
            Show("Você possui uma especialização? (s/n)");
            string isSpecialization = Console.ReadLine()!;
            if (isSpecialization == "s")
            {
                Show("Qual área de especialização");
                string specialization = Console.ReadLine()!;

                doctorUpdate.Specialization = specialization;
                doctorRepository.Update(oldDoctor.Id, doctorUpdate);
            }
            else
            {
                doctorUpdate.Specialization = "";
                doctorRepository.Update(oldDoctor.Id, doctorUpdate);
            }
        }

        private void DeleteDoctor()
        {
            Show("Digite o número de cadastro que quer excluir");
            int id = int.Parse(Console.ReadLine()!);
            Doctor doctorRemove = doctorRepository.GetById(id)!;
            doctorRepository.Delete(doctorRemove);

        }

        private void Show(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}