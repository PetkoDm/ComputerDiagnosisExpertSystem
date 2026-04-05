using System.Collections.Generic;
using ComputerDiagnosisExpertSystem.Models;

namespace ComputerDiagnosisExpertSystem.Logic
{
    public class InferenceEngine
    {
        public static Damage Diagnose(List<string> s)
        {
            if (s.Contains("G002") && s.Contains("G003") && s.Contains("G004"))
                return new Damage
                {
                    Code = "P001",
                    Name = "Повредено захранване",
                    Solution = "Проверете или сменете захранването."
                };

            if (s.Contains("G002") && s.Contains("G005") && s.Contains("G009") && s.Contains("G010"))
                return new Damage
                {
                    Code = "P002",
                    Name = "Повредена дънна платка",
                    Solution = "Необходим е ремонт или смяна на дънната платка."
                };

            if (s.Contains("G011") && s.Contains("G014"))
                return new Damage
                {
                    Code = "P003",
                    Name = "Дефектна RAM памет",
                    Solution = "Проверете RAM паметта или сменете модулите."
                };

            if (s.Contains("G016") && s.Contains("G019") && s.Contains("G020"))
                return new Damage
                {
                    Code = "P004",
                    Name = "Повреден твърд диск",
                    Solution = "Сменете или проверете твърдия диск."
                };

            if (s.Contains("G001") && s.Contains("G007") && s.Contains("G008"))
                return new Damage
                {
                    Code = "P005",
                    Name = "Повреден монитор",
                    Solution = "Проверете кабели и монитор, заменете ако е нужно."
                };

            if (s.Contains("G012") && s.Contains("G008") && !s.Contains("G007"))
                return new Damage
                {
                    Code = "P006",
                    Name = "Повреден процесор",
                    Solution = "Необходим е ремонт или смяна на процесора."
                };

            if (s.Contains("G025") && s.Contains("G028"))
                return new Damage
                {
                    Code = "P007",
                    Name = "Повредено CD/DVD устройство",
                    Solution = "Проверете или сменете CD/DVD устройството."
                };

            if (s.Contains("G030") && s.Contains("G029"))
                return new Damage
                {
                    Code = "P008",
                    Name = "Повредена звукова карта",
                    Solution = "Проверете драйверите или сменете звуковата карта."
                };

            if (s.Contains("G023") && s.Contains("G014"))
                return new Damage
                {
                    Code = "P009",
                    Name = "Повредена видео карта (VGA)",
                    Solution = "Проверете или сменете видео картата."
                };

            if (s.Contains("G034"))
                return new Damage
                {
                    Code = "P010",
                    Name = "Повредена мишка",
                    Solution = "Проверете мишката и кабелите, сменете ако е нужно."
                };

            if (s.Contains("G029"))
                return new Damage
                {
                    Code = "P011",
                    Name = "Проблем с драйвери",
                    Solution = "Обновете или преинсталирайте драйверите."
                };

            if (s.Contains("G017") && s.Contains("G020"))
                return new Damage
                {
                    Code = "P012",
                    Name = "Зловреден софтуер (вирус)",
                    Solution = "Сканирайте с антивирусен софтуер."
                };

            if (s.Contains("G014") && s.Contains("G019"))
                return new Damage
                {
                    Code = "P013",
                    Name = "Повредена операционна система",
                    Solution = "Реинсталирайте операционната система."
                };

            if (s.Contains("G017") && s.Contains("G014"))
                return new Damage
                {
                    Code = "P014",
                    Name = "Софтуерен конфликт",
                    Solution = "Проверете софтуера и премахнете конфликтите."
                };

            if (s.Contains("G030") && !s.Contains("G029"))
                return new Damage
                {
                    Code = "P014",
                    Name = "Софтуерен конфликт (аудио)",
                    Solution = "Проверете аудио настройките и софтуерните конфликти."
                };

            return new Damage
            {
                Name = "Неопределен проблем",
                Solution = "Няма достатъчно данни за диагностика."
            };
        }
    }
}