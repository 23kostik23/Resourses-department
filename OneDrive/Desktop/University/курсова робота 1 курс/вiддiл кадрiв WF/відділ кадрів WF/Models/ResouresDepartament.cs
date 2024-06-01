using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace відділ_кадрів_WF.Models
{
    public class ResouresDepartament
    {
        private List<Worker> workers = new List<Worker>();
        public override string ToString()
        {
            if (workers.Count == 0)
            {
                return $"Відділ кадрів пустий";
            }
            string result = "";
            foreach (Worker worker in workers)
            {
                result += worker.ToString();
                result += "\r\n\r\n";
            }
            return result;
        }
        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
            CreateHireOrderTxt(worker);
        }

        private void CreateHireOrderTxt(Worker worker)
        {
            string folderPath = @"C:\Users\kk648\OneDrive\Desktop\University\курсова робота 1 курс\вiддiл кадрiв WF\Накази\Прийняття на роботу";
            string fileName = $"HireOrder {worker.DateOfAppearence:yyyy.MM.dd HH mm ss}, {worker.Name} {worker.Surname}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            File.WriteAllText(filePath, $"Наказ про прийняття на роботу.\n" +
                $"{worker.Name} {worker.Surname} було призначено на пост {worker.Position} у віці {worker.Age}.\n" +
                $"Отримуватиме фіксовану заробітню плату у розмірі: {worker.Salary}.\n" +
                $"Має {worker.Education} освіту.\n" +
                $"Стать співробітника: {worker.Sex}.\n" +
                $"Підрозділ у якому працюватиме: {worker.Division}.\n" +
                $"Дата надходження у фірму: {worker.DateOfAppearence}.\n" +
                $"Дата останньої зміни параметрів робітника: {worker.DateOfLastAppointment}.\n");
        }

        private void CreateFireOrderTxt(Worker worker)
        {
            string folderPath = @"C:\Users\kk648\OneDrive\Desktop\University\курсова робота 1 курс\вiддiл кадрiв WF\Накази\Звільнення з роботи";
            string fileName = $"FireOrder {worker.DateOfAppearence:yyyy.MM.dd HH mm ss}, {worker.Name} {worker.Surname}.txt";
            string filePath = Path.Combine(folderPath, fileName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            File.WriteAllText(filePath, $"Наказ про звільнення з роботи.\n" +
                $"{worker.Name} {worker.Surname} було звільнено з посту {worker.Position} у віці {worker.Age}.\n" +
                $"Отримував фіксовану заробітню плату у розмірі: {worker.Salary}.\n" +
                $"Має {worker.Education} освіту.\n" +
                $"Стать співробітника: {worker.Sex}.\n" +
                $"Підрозділ у якому працював: {worker.Division}.\n" +
                $"Дата надходження у фірму: {worker.DateOfAppearence}.\n" +
                $"Дата останньої зміни параметрів робітника: {worker.DateOfLastAppointment}.\n");
        }
        private void CreateEditOrderTxt(Worker workerBeforeChange, Worker workerAfterChange)
        {
            string folderPath = @"C:\Users\kk648\OneDrive\Desktop\University\курсова робота 1 курс\вiддiл кадрiв WF\Накази\Зміни параметрів робітникiв";
            string fileName = $"EditOrder {workerAfterChange.DateOfAppearence:yyyy.MM.dd HH mm ss}, {workerAfterChange.Name} {workerAfterChange.Surname}.txt";
            string filePath = Path.Combine(folderPath, fileName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            File.WriteAllText(filePath, $"Наказ про зміну параметрів робітника з роботи.\n" +
                $"БУЛО----------------------------\n" +
                $"Name: {workerBeforeChange.Name}\n" +
                $"Surname: {workerBeforeChange.Surname}\n" +
                $"Age: {workerBeforeChange.Age}\n" +
                $"Salary: {workerBeforeChange.Salary}\n" +
                $"Sex: {workerBeforeChange.Sex}\n" +
                $"Education: {workerBeforeChange.Education}\n" +
                $"Position: {workerBeforeChange.Position}\n" +
                $"Division: {workerBeforeChange.Division}\n" +
                $"Date of Appearence: {workerBeforeChange.DateOfAppearence}\n" +
                $"Date of last Edit: {workerBeforeChange.DateOfLastAppointment}\n" +
                $"СТАЛО---------------------------\n" +
                $"Name: {workerAfterChange.Name}\n" +
                $"Surname: {workerAfterChange.Surname}\n" +
                $"Age: {workerAfterChange.Age}\n" +
                $"Salary: {workerAfterChange.Salary}\n" +
                $"Sex: {workerAfterChange.Sex}\n" +
                $"Education: {workerAfterChange.Education}\n" +
                $"Position: {workerAfterChange.Position}\n" +
                $"Division: {workerAfterChange.Division}\n" +
                $"Date of Appearence: {workerAfterChange.DateOfAppearence}\n" +
                $"Date of last Edit: {workerAfterChange.DateOfLastAppointment}\n");
        }
        public void LoadFromFile()
        {
            workers.Clear();
            string FilePath = @"C:\Users\kk648\OneDrive\Desktop\University\курсова робота 1 курс\вiддiл кадрiв WF\База даних робітників\База даних.txt";
            try
            {
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        string thisName = parts[0].Substring(6);
                        string thisSurname = parts[1].Substring(10);
                        int thisAge = int.Parse(parts[2].Substring(6));
                        int thisSalary = int.Parse(parts[3].Substring(8));
                        string thisSex = parts[4].Substring(6);
                        string thisEducation = parts[5].Substring(12);
                        string thisPosition = parts[6].Substring(11);
                        string thisDivision = parts[7].Substring(11);
                        DateTime thisDateOfAppearence = DateTime.Parse(parts[8].Substring(21));
                        DateTime thisDateOfLastAppointment = DateTime.Parse(parts[9].Substring(19));
                        Worker thisWorker = new Worker(thisName, thisSurname, thisAge, thisSalary, thisSex, thisEducation, thisPosition, thisDivision, thisDateOfAppearence, thisDateOfLastAppointment);
                        workers.Add(thisWorker);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SaveToFile()
        {
            string FolderPath = @"C:\Users\kk648\OneDrive\Desktop\University\курсова робота 1 курс\вiддiл кадрiв WF\База даних робітників";
            string FilePath = Path.Combine(FolderPath, "База даних.txt");
            if (Directory.Exists(FolderPath))
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (var worker in workers)
                    {
                        writer.Write(worker.ToString() + "\r\n");
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(FolderPath);
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (var worker in workers)
                    {
                        writer.Write(worker.ToString() + "\r\n");
                    }
                }
            }
        }
        public void DeleteWorker(Worker worker)
        {
            bool checker = false;
            for (int i = workers.Count - 1; i >= 0; i--)
            {
                if (AreWorkersEqual(worker, workers[i]))
                {
                    workers.RemoveAt(i);
                    checker = true;
                    break;
                }
            }
            if (checker == true)
            {
                MessageBox.Show("Worker has succesfully been Fired");
                CreateFireOrderTxt(worker);
            }
            else
            {
                MessageBox.Show("There is no workers with this Parameters");
            }
        }
        private bool AreWorkersEqual(Worker a, Worker b)
        {
            if (a.Name != b.Name)
            {
                return false;
            }
            if (a.Age != b.Age)
            {
                return false;
            }
            if (a.Sex != b.Sex)
            {
                return false;
            }
            if (a.Salary != b.Salary)
            {
                return false;
            }
            if (a.Education != b.Education)
            {
                return false;
            }
            if (a.Position != b.Position)
            {
                return false;
            }
            if (a.Division != b.Division)
            {
                return false;
            }
            return true;
        }

        public void DeleteWorkerWithDateTime(Worker worker)
        {
            bool checker = false;
            for (int i = workers.Count - 1; i >= 0; i--)
            {
                if (AreWorkersEqualWithDateTime(worker, workers[i]))
                {
                    workers.RemoveAt(i);
                    checker = true;
                    break;
                }
            }
            if (checker == true)
            {
                MessageBox.Show("Worker has succesfully been Fired");
                CreateFireOrderTxt(worker);
                //ChangeWorkerDateOfLastAppointment(worker);  
            }
            else
            {
                MessageBox.Show("There is no workers with this Parameters");
            }
        }
        private bool AreWorkersEqualWithDateTime(Worker a, Worker b)
        {
            if (a.Name != b.Name)
            {
                return false;
            }
            if (a.Age != b.Age)
            {
                return false;
            }
            if (a.Sex != b.Sex)
            {
                return false;
            }
            if (a.Salary != b.Salary)
            {
                return false;
            }
            if (a.Education != b.Education)
            {
                return false;
            }
            if (a.Position != b.Position)
            {
                return false;
            }
            if (a.Division != b.Division)
            {
                return false;
            }
            if (a.DateOfAppearence != b.DateOfAppearence)
            {
                return false;
            }
            if (a.DateOfLastAppointment != b.DateOfLastAppointment)
            {
                return false;
            }
            return true;
        }

        public void EditWorker(Worker workerBeforeChange, Worker workerAfterChange)
        {
            for (int i = workers.Count - 1; i >= 0; i--)
            {
                if (AreWorkersEqualWithDateTime(workerBeforeChange, workers[i]))
                {
                    DateTime temp = workers[i].DateOfAppearence;
                    workers[i] = workerAfterChange;
                    workers[i].DateOfAppearence = temp;
                    workers[i].DateOfLastAppointment = DateTime.Now;
                    CreateEditOrderTxt(workerBeforeChange, workerAfterChange);
                    break;
                }
            }
            MessageBox.Show("Worker has succesfully been changed");
        }

        public List<Worker> GetWorkersInList()
        {
            return workers;
        }
        public int Count()
        {
            return workers.Count;
        }
    }
}
