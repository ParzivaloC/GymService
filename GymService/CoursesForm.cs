using System;
using System.Linq;
using System.Windows.Forms;
using GymService.Services;
using GymService.Models;

namespace GymService
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        private void EnrollUser(string course)
        {
            var user = UserStorage.LoadUser();
            if (user == null)
            {
                using var r = new RegisterForm();
                if (r.ShowDialog() != DialogResult.OK) return;
                user = UserStorage.LoadUser();
            }

            if (user == null) return;

            if (!user.EnrolledCourses.Any(s => s.Equals(course, StringComparison.OrdinalIgnoreCase)))
            {
                user.EnrolledCourses.Add(course);
                UserStorage.SaveUser(user);
            }

            MessageBox.Show($"Вы успешно записались на курс «{course}»", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var course = btn?.Tag?.ToString() ?? "Курс";
            EnrollUser(course);
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var course = btn?.Tag?.ToString() ?? "Курс";

            var desc = course switch
            {
                "Тренировки" => "Идеальная программа для тех, кто только начинает свой путь в фитнесе. Пошаговое освоение техники выполнения упражнений, постепенный рост нагрузки и понятная система тренировок.",
                "Питание" => "План питания для тех, кто хочет правильно питаться и достигать целей — похудение или набор массы. Рекомендации по БЖУ и примерное меню.",
                "Восстановление" => "Программа восстановления после травм и интенсивных нагрузок. Упражнения на гибкость, рекомендации по отдыху и питанию.",
                _ => "Описание курса"
            };

            var bullets = course switch
            {
                "Тренировки" => new[] { "3 тренировки в неделю с постепенным увеличением нагрузки", "Детальные видео-инструкции по технике выполнения", "Программа рассчитана на 12 недель с прогрессией", "Подходит для зала и дома", "Рекомендации по разминке и заминке" },
                "Питание" => new[] { "Сбалансированное питание", "Программа для набора массы или похудения", "Режим питания и примерные блюда" },
                "Восстановление" => new[] { "Базовые упражнения для восстановления", "Рекомендации по реабилитации", "План восстановления после травм" },
                _ => new string[0]
            };

            using var details = new CourseDetailsForm(course, desc, bullets);
            if (details.ShowDialog() == DialogResult.OK)
            {
                EnrollUser(course);
            }
        }
    }
}
