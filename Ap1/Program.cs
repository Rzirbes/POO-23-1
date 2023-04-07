
using Ap1.domain.models;
using Ap1.repository;

internal class Program
{
    private static void Main(string[] args)
    {
        DoctorRepository doctorRepository = new DoctorRepository();
        PatientRepository patientRepository = new PatientRepository();
        MedicalAppoimentRepository medicalAppoimentRepository = new MedicalAppoimentRepository();

        // Doctor doctor = new Doctor("Adalberto", "033033033-02", "51 989898989", "098767/RS", "Cardiologia");
        // Doctor doctor02 = new Doctor("João", "033033033-02", "51 989898989", "098767/RS", "Clinico geral");
        // Doctor doctor03 = new Doctor("Pedro", "0808080-02", "51 8080080", "098767/RS", "Cardiologia", "Cirugião cardio vascular");

        // doctorRepository.AddDoctor(doctor);
        // doctorRepository.AddDoctor(doctor02);
        // doctorRepository.AddDoctor(doctor03);

        // Patient patient = new Patient("Rômulo", "0932450349", "51 4576456", "Dor de cabeça");
        // Patient patient02 = new Patient("Anderson", "2343423", "51 9090909", "Diarreia");
        // Patient patient03 = new Patient("Rocha", "14234234", "51 445543434", "Pressão alta");

        // patientRepository.AddPatient(patient);
        // patientRepository.AddPatient(patient02);
        // patientRepository.AddPatient(patient03);

        

        // MedicalAppoiment medicalAppoimentTest = new MedicalAppoiment(new DateTime(2023, 04, 06, 14, 30, 0), doctor03, patient02);
        // MedicalAppoiment medicalAppoimentTest02 = new MedicalAppoiment(new DateTime(2023, 04, 17, 11, 30, 0), doctor02, patient03);
        // medicalAppoimentRepository.AddMedicalAppoiment(medicalAppoimentTest);
        // medicalAppoimentRepository.AddMedicalAppoiment(medicalAppoimentTest02);
        


        while(true)
        {
            Show("");
            Show("Digite a opção desejada:");
            Show("1 - Menu médico!");
            Show("2 - Menu paciente!");
            Show("3 - Fazer cadastro de uma nova Consulta!");
            Show("4 - Exibir consultas agendadas!");
            Show("5 - Apagar uma consulta agendada!");
            Show("0 - Sair");
            Show("");

            int opcao = int.Parse(Console.ReadLine()!);

            switch(opcao)
            {
                case 1:
                    DoctorMenu();
                break;
                case 2:
                    PatientMenu();
                break;
                case 3:
                    insertMedicalAppoiment();
                break;
                case 4:
                    ShowMedicalAppoiment();
                break;
                case 5:
                    DeleteMedicalAppoiment();
                break;
                case 0:
                    Environment.Exit(0);
                break;
                default:
                    Console.WriteLine("Opção inválida!");
                break;
            }
        }



    void DoctorMenu()
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

    void PatientMenu()
    {
        while(true)
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

            switch(opcao)
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



    //Menu Médico ínicio

    void insertDoctor()
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
        if(isSpecialization == "s")
        {
            Show("Qual área de especialização");
            string specialization = Console.ReadLine()!;

            Doctor doctor = new Doctor(doctorName, doctorCPF, doctorPhone, doctorCRM, doctorOccupationArea, specialization);
            doctorRepository.AddDoctor(doctor);
        }
        else
        {
            Doctor doctor = new Doctor(doctorName, doctorCPF, doctorPhone, doctorCRM, doctorOccupationArea);
            doctorRepository.AddDoctor(doctor);
        }
    }

    void ShowDoctor()
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

    void AlterDoctor()
    {
        Show("Digide o Id da pessoa que quer alterar o cadastro");
        int id = int.Parse(Console.ReadLine()!);

        Doctor doctorUpdate = doctorRepository.GetByIdDoctor(id)!;

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
        if(isSpecialization == "s")
        {
            Show("Qual área de especialização");
            string specialization = Console.ReadLine()!;
            
            doctorUpdate.Specialization = specialization;
            doctorRepository.UpdateDoctor(oldDoctor.Id, doctorUpdate);
        }
        else
        {
            doctorUpdate.Specialization = "";
            doctorRepository.UpdateDoctor(oldDoctor.Id, doctorUpdate);
        }
    }

    void DeleteDoctor()
    {
        Show("Digite o número de cadastro que quer excluir");
        int id = int.Parse(Console.ReadLine()!);
        Doctor doctorRemove = doctorRepository.GetByIdDoctor(id)!;
        doctorRepository.RemoveDoctor(doctorRemove);

    }

    //Menu Médico fim


    //Menu Paciente ínicio

    void insertPatient()
    {
        Show("Digite seu nome");
        string patientName = Console.ReadLine()!;
        Show("Digite seu telefone");
        string patientPhone = Console.ReadLine()!;
        Show("Digite seu CPF");
        string patientCPF = Console.ReadLine()!;
        Show("Digite sua Doença");
        string patientIllness = Console.ReadLine()!;

        Patient patient = new Patient(patientName, patientCPF, patientPhone, patientIllness);

        patientRepository.AddPatient(patient);
    }

    void ShowPatient()
    {
        foreach (var patient in patientRepository.GetAllPatient())
        {
            Show("============================================");
            Show($"ID do paciente: {patient.Id}, Nome do paciente: {patient.Name}, CPF: {patient.CPF}, Telefone: {patient.Phone}, Doença: {patient.Illness}");
            Show("============================================");
        }
    }

    void AlterPatient()
    {
        Show("Digide o Id da pessoa que quer alterar o cadastro");
        int id = int.Parse(Console.ReadLine()!);

        Patient PatientUpdate = patientRepository.GetByIdPatient(id)!;

        Patient oldPatient = PatientUpdate;
        Show("Digite seu nome");
        PatientUpdate.Name = Console.ReadLine()!;
        Show("Digite seu telefone");
        PatientUpdate.Phone = Console.ReadLine()!;
        Show("Digite seu CPF");
        PatientUpdate.CPF = Console.ReadLine()!;   
        Show("Digite sua doença");
        PatientUpdate.Illness = Console.ReadLine()!;   
        
        patientRepository.UpdatePatient(oldPatient.Id, PatientUpdate);
 
    }

    void DeletePatient()
    {
        Show("Digite o número de cadastro que quer excluir");
        int id = int.Parse(Console.ReadLine()!);
        Patient patientRemove = patientRepository.GetByIdPatient(id)!;
        patientRepository.RemovePatient(patientRemove);

    }

    //Menu Paciente fim

    void insertMedicalAppoiment()
    {
        Show("Digite data e horário da consulta (formato: dd/mm/aaaa hh:mm:ss)");
        DateTime appoimentDate = DateTime.Parse(Console.ReadLine()!);

        Doctor doctor = null!;
        while(doctor == null)
        {
            Show("Digite o id do médico");
            int doctorId = int.Parse(Console.ReadLine()!);
            doctor = doctorRepository.GetByIdDoctor(doctorId);
            if(doctor == null)
            {
                Show("ID do médico inválido");
            }
        }

        Patient patient = null!;
        while(patient == null)
        {
            Show("Digite o id do paciente");
            int patientId = int.Parse(Console.ReadLine()!);
            patient = patientRepository.GetByIdPatient(patientId);
            if(patient == null)
            {
                Show("ID do paciente inválido");
            }
        }
        

        MedicalAppoiment medicalAppoiment = new MedicalAppoiment(appoimentDate, doctor, patient);

        medicalAppoimentRepository.AddMedicalAppoiment(medicalAppoiment);
    }

    void ShowMedicalAppoiment()
    {
        foreach (var medicalAppoiment in medicalAppoimentRepository.GetAllMedicalAppoiment())
        {
            Show("============================================");
            Show($"Código da consulta: {medicalAppoiment.Id}");
            Show($"Nome do paciente: {medicalAppoiment.Patient.Name}, Doença: {medicalAppoiment.Patient.Illness}");
            Show($"Nome do Médico: {medicalAppoiment.Doctor.Name}, CRM: {medicalAppoiment.Doctor.CRM}");
            Show($"Hora da consulta: {medicalAppoiment.AppoimentDate.ToString()}, CPF: {patient.CPF}, Telefone: {patient.Phone}");
            Show($"Telefone do Paciente: {medicalAppoiment.Patient.Phone}");
            Show("============================================");
        }
    }

    void DeleteMedicalAppoiment()
    {
        Show("Digite o número de cadastro que quer excluir");
        int id = int.Parse(Console.ReadLine()!);
        MedicalAppoiment appoimentRemove = medicalAppoimentRepository.GetByIdMedicalAppoiment(id)!;
        medicalAppoimentRepository.RemoveMedicalAppoiment(appoimentRemove);

    }
    




    

    void Show(string msg)
    {
        Console.WriteLine(msg);
    }

    }

    


}