using System;
using System.Linq;
using System.Windows.Forms;
using GymService.Services;

namespace GymService
{
    enum CourseType
    {
        Training,
        Nutrition,
        Recovery
    }
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
                this.Hide();
                RegisterForm registerForm = new RegisterForm();//не зареган(в юзере неичего нет, открываает модалку)
                DialogResult regRes = registerForm.ShowDialog();
                this.Show();

                if (regRes != DialogResult.OK)
                {
                    //не зареган? - выход
                    return;
                }

                //зареган? - загружай
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


        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void OpenCourseForm(CourseType type)
        {
            string desk, course;
            string[] bullets;
            switch (type)
            {
                case CourseType.Training:
                    course = "Тренировки";
                    desk = "Идеальная программа для тех, кто только начинает свой путь в фитнесе. Пошаговое освоение техники выполнения упражнений, постепенный рост нагрузки и понятная система тренировок.";
                    break;
                case CourseType.Nutrition:
                    course = "Питание";
                    desk = "План питания для тех, кто хочет правильно питаться и достигать целей — похудение или набор массы. Рекомендации по БЖУ и примерное меню.";
                    break;
                case CourseType.Recovery:
                    course = "Восстановление";
                    desk = "Программа восстановления после травм и интенсивных нагрузок. Упражнения на гибкость, рекомендации по отдыху и питанию.";
                    break;
                default:
                    course = "Курс";
                    desk = "Описание курса";
                    break;
            }
            switch (course)
            {
                case "Тренировки":
                    bullets = new[]
                    {
                        "3 тренировки в неделю с постепенным увеличением нагрузки",
                        "Детальные видео-инструкции по технике выполнения",
                        "Программа рассчитана на 12 недель с прогрессией",
                        "Подходит для зала и дома",
                        "Рекомендации по разминке и заминке"
                    };
                    break;
                case "Питание":
                    bullets = new[]
                    {
                        "Сбалансированное питание",
                        "Программа для набора массы или похудения",
                        "Режим питания и примерные блюда"
                    };
                    break;
                case "Восстановление":
                    bullets = new[]
                    {
                        "Базовые упражнения для восстановления",
                        "Рекомендации по реабилитации",
                        "План восстановления после травм"
                    };
                    break;
                default:
                    bullets = new string[0];
                    break;
            }
            this.Hide();
            CourseDetailsForm detailsForm = new CourseDetailsForm(course, desk, bullets);
            var detailsResult = detailsForm.ShowDialog();
            this.Show();
            if (detailsResult == DialogResult.OK)
            {
                EnrollUser(course);
            }


        }

        private void btnTrainDetails_Click(object sender, EventArgs e)
        {
            OpenCourseForm(CourseType.Training);
        }

        private void btnNutritionDetails_Click(object sender, EventArgs e)
        {
            OpenCourseForm(CourseType.Nutrition);
        }

        private void btnRecoveryDetails_Click(object sender, EventArgs e)
        {
            OpenCourseForm(CourseType.Recovery);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            EnrollUser("Тренировки");
        }

        private void btnNutrition_Click(object sender, EventArgs e)
        {
            EnrollUser("Питание");
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            EnrollUser("Восстановление");
        }
    }
}
