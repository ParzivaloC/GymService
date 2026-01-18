using System;
using System.Linq;
using System.Windows.Forms;
using GymService.Services;

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

                //если юзер зарегался нев мейн а в курсах, чтобы в мейн кнопка тож менялась
                try
                {
                    Main mainForm = Application.OpenForms//поиск экземпляра Main среди запущ форм
                        .OfType<Main>()
                        .FirstOrDefault();

                    if (mainForm != null)
                    {
                        mainForm.RefreshAccountButton();
                    }
                }
                catch
                {
                    //пепе шнеле 
                }
            }

            if (user == null) return;

            if (!user.EnrolledCourses.Any(s => s.Equals(course, StringComparison.OrdinalIgnoreCase)))
            {
                user.EnrolledCourses.Add(course);
                UserStorage.SaveUser(user);
            }

            MessageBox.Show($"Вы успешно записались на курс «{course}»", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string course = "Курс";

            if (btn != null && btn.Tag != null)
            {
                course = btn.Tag.ToString();
            }

            EnrollUser(course);
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string course = "Курс";

            if (btn != null && btn.Tag != null)
            {
                course = btn.Tag.ToString();
            }

            string desc;
            if (course == "Тренировки")
            {
                desc = "Идеальная программа для тех, кто только начинает свой путь в фитнесе. Пошаговое освоение техники выполнения упражнений, постепенный рост нагрузки и понятная система тренировок.";
            }
            else if (course == "Питание")
            {
                desc = "План питания для тех, кто хочет правильно питаться и достигать целей — похудение или набор массы. Рекомендации по БЖУ и примерное меню.";
            }
            else if (course == "Восстановление")
            {
                desc = "Программа восстановления после травм и интенсивных нагрузок. Упражнения на гибкость, рекомендации по отдыху и питанию.";
            }
            else
            {
                desc = "Описание курса";
            }

            string[] bullets;
            if (course == "Тренировки")
            {
                bullets = new[]
                {
                    "3 тренировки в неделю с постепенным увеличением нагрузки",
                    "Детальные видео-инструкции по технике выполнения",
                    "Программа рассчитана на 12 недель с прогрессией",
                    "Подходит для зала и дома",
                    "Рекомендации по разминке и заминке"
                };
            }
            else if (course == "Питание")
            {
                bullets = new[]
                {
                    "Сбалансированное питание",
                    "Программа для набора массы или похудения",
                    "Режим питания и примерные блюда"
                };
            }
            else if (course == "Восстановление")
            {
                bullets = new[]
                {
                    "Базовые упражнения для восстановления",
                    "Рекомендации по реабилитации",
                    "План восстановления после травм"
                };
            }
            else
            {
                bullets = new string[0];
            }

            this.Hide();
            CourseDetailsForm detailsForm = new CourseDetailsForm(course, desc, bullets);
            var detailsResult = detailsForm.ShowDialog();
            this.Show();

            if (detailsResult == DialogResult.OK)
            {
                EnrollUser(course);
            }
        }
    }
}
