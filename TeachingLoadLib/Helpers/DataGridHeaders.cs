using System;
using System.Collections.Generic;
using System.Text;

namespace TeachingLoadCore.Helpers
{
    public static class DataGridHeaders
    {
        public static List<String> DisciplinesHeaders;
        public static List<String> GroupsHeaders;
        public static List<String> TeachersHeaders;
        public static List<String> DisciplinesPlanHeaders1;
        public static List<String> DisciplinesPlanHeaders2;
        public static List<String> DisciplinesTeachingLoadHeaders1;
        public static List<String> DisciplinesTeachingLoadHeaders2;

        static DataGridHeaders()
        {
            DisciplinesHeaders = new List<string>
            {
                "Назва",
                "Примітки"
            };
            GroupsHeaders = new List<string>()
            {
                "Курс",
                "Назва",
                "Форма навчання",
                "Бюджетників",
                "Контрактників",
                "Примітки"
            };
            TeachersHeaders = new List<string>()
            {
                "Прізвище",
                "Ім'я",
                "По-батькові",
                "Ставка",
                "Посада",
                "Звання",
                "Ступінь",
                "Примітки"
            };
            DisciplinesPlanHeaders1 = new List<string>
            {
                "Дисципліна",
                "Курс",
                "Форма",
                "Обсяг"
            };
            DisciplinesPlanHeaders2 = new List<string>
            {
                "Вид роботи",
                "Години"
            };
            DisciplinesTeachingLoadHeaders1 = new List<string>
            {
                "Дисципліна",
                "Курс",
                "Форма"
            };
            DisciplinesTeachingLoadHeaders2 = new List<string>
            {
                "Вид роботи",
                "Вільно"
            };
        }
    }
}
